using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebView2Demo.Properties;
using WebView2Demo.Support;

namespace WebView2Demo
{
    public partial class WebViewContainer : Form
    {
        private int _linkCountScheme;
        private int _linkCountUrl;
        private bool _loading;
        private SecurityState _securityState;
        private CoreWebView2DevToolsProtocolEventReceiver _securityStateReceiver;
        private string _securitySummary;

        public WebViewContainer()
        {
            InitializeComponent();
        }

        private void HandleBackClicked(object sender, EventArgs e)
        {
            wvBrowser.CoreWebView2.GoBack();
        }

        private void HandleForwardClicked(object sender, EventArgs e)
        {
            wvBrowser.CoreWebView2.GoForward();
        }

        private void HandleGoClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tstbUrl.Text) && Uri.TryCreate(tstbUrl.Text, UriKind.Absolute, out var targetUri))
                wvBrowser.CoreWebView2.Navigate(targetUri.ToString());
        }

        private void HandleNavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            _loading = false;
            UpdateUiState();
        }

        private void HandleNavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            _loading = true;
            UpdateUiState();
        }

        private void HandleQuickLinkClicked(object sender, EventArgs e)
        {
            var link = (sender as ToolStripButton)?.Tag?.ToString().NullIf();
            if (link != null && Uri.TryCreate(link, UriKind.Absolute, out var linkUri))
            {
                tstbUrl.Text = linkUri.ToString();
                wvBrowser.CoreWebView2.Navigate(linkUri.ToString());
            }
        }

        private void HandleReloadClicked(object sender, EventArgs e)
        {
            wvBrowser.CoreWebView2.Reload();
        }

        private void HandleSecurityStateChanged(object sender, CoreWebView2DevToolsProtocolEventReceivedEventArgs e)
        {
            var json = JsonConvert.DeserializeObject<JObject>(e.ParameterObjectAsJson);
            switch (json?[@"securityState"]?.Value<string>().NullIf())
            {
                case @"unknown":
                    _securityState = SecurityState.Unknown;
                    break;
                case @"neutral":
                    _securityState = SecurityState.Neutral;
                    break;
                case @"insecure":
                    _securityState = SecurityState.Insecure;
                    break;
                case @"secure":
                    _securityState = SecurityState.Secure;
                    break;
                case @"info":
                    _securityState = SecurityState.Info;
                    break;
                case @"insecure-broken":
                    _securityState = SecurityState.InsecureBroken;
                    break;
                default:
                    _securityState = SecurityState.Invalid;
                    break;
            }

            _securitySummary = json[@"summary"]?.Value<string>().NullIf();
            UpdateUiState();
        }

        private void HandleUrlKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    tsbGo.PerformClick();
                    break;
                default:
                    return;
            }

            e.SuppressKeyPress = true;
            e.Handled = true;
        }

        private void HandleWebResourceRequested(object sender, CoreWebView2WebResourceRequestedEventArgs e)
        {
            if (e.ResourceContext == CoreWebView2WebResourceContext.Document)
            {
                _linkCountUrl += 1;

                if (Uri.TryCreate(e.Request.Uri, UriKind.Absolute, out var requestUri))
                {
                    if (requestUri.Scheme.Equals(@"app-scheme", StringComparison.OrdinalIgnoreCase))
                    {
                        _linkCountScheme += 1;
                    }
                }
            }

            UpdateUiState();
        }

        private async void HandleWebViewContainerLoad(object sender, EventArgs e)
        {
            var rtVersion = CoreWebView2Environment.GetAvailableBrowserVersionString();
            var sdkVersion = typeof(CoreWebView2).Assembly.GetName().Version.ToString();
            Text = $@"WebView2 Demo - RT: {rtVersion} - SDK: {sdkVersion}";

            await wvBrowser.EnsureCoreWebView2Async();
            UpdateUiState();
        }

        private async void HandleWebViewInitialized(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            var coreWebView = ((WebView2)sender).CoreWebView2;

            var settings = coreWebView.Settings;
            settings.UserAgent += @" WebView2Demo/1.0";
            settings.AreDefaultContextMenusEnabled = false;
            settings.AreHostObjectsAllowed = false;
            settings.IsGeneralAutofillEnabled = false;
            settings.IsPasswordAutosaveEnabled = false;
            settings.IsWebMessageEnabled = true;
            settings.IsPinchZoomEnabled = false;

            coreWebView.AddWebResourceRequestedFilter(@"*", CoreWebView2WebResourceContext.All);

            coreWebView.NavigationStarting += HandleNavigationStarting;
            coreWebView.NavigationCompleted += HandleNavigationCompleted;
            coreWebView.WebResourceRequested += HandleWebResourceRequested;

            await coreWebView.CallDevToolsProtocolMethodAsync(@"Security.enable", @"{}");
            _securityStateReceiver = coreWebView.GetDevToolsProtocolEventReceiver(@"Security.securityStateChanged");
            _securityStateReceiver.DevToolsProtocolEventReceived += HandleSecurityStateChanged;
        }

        private void UpdateUiState()
        {
            SuspendLayout();
            if (_loading)
            {
                tsbSpinner.Image = Resources.SpinnerOn;
                tsbSpinner.ToolTipText = @"Loading...";
                tsbSpinner.Text = @"Loading...";
            }
            else
            {
                tsbSpinner.Image = Resources.SpinnerOff;
                tsbSpinner.ToolTipText = string.Empty;
                tsbSpinner.Text = string.Empty;
            }

            tsbHttps.ToolTipText = _securitySummary.NullIf() ?? _securityState.ToString();
            tsbHttps.Text = _securityState.ToString();
            if (_securityState == SecurityState.Secure)
            {
                tsbHttps.Image = Resources.Secure;
            }
            else if (_securityState == SecurityState.Neutral || _securityState == SecurityState.Info)
            {
                tsbHttps.Image = Resources.SecureNeutral;
            }
            else
            {
                tsbHttps.Image = Resources.Insecure;
            }

            tslCurrentUrl.Text = wvBrowser.CoreWebView2.Source;
            tslCountUrl.Text = $@"Url: {_linkCountUrl}";
            tslCountScheme.Text = $@"Scheme: {_linkCountScheme}";

            tsbBack.Enabled = wvBrowser.CoreWebView2.CanGoBack;
            tsbForward.Enabled = wvBrowser.CoreWebView2.CanGoForward;
            ResumeLayout(true);
        }
    }
}