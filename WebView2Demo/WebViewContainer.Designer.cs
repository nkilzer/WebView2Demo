namespace WebView2Demo
{
    partial class WebViewContainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebViewContainer));
            this.tscMain = new System.Windows.Forms.ToolStripContainer();
            this.tsStatus = new System.Windows.Forms.ToolStrip();
            this.tsbSpinner = new System.Windows.Forms.ToolStripButton();
            this.tsbHttps = new System.Windows.Forms.ToolStripButton();
            this.tslCountUrl = new System.Windows.Forms.ToolStripLabel();
            this.tslCountScheme = new System.Windows.Forms.ToolStripLabel();
            this.tslCurrentUrl = new System.Windows.Forms.ToolStripLabel();
            this.wvBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tsHeader = new System.Windows.Forms.ToolStrip();
            this.tsbBack = new System.Windows.Forms.ToolStripButton();
            this.tsbForward = new System.Windows.Forms.ToolStripButton();
            this.tsbReload = new System.Windows.Forms.ToolStripButton();
            this.tstbUrl = new WebView2Demo.Support.ToolStripSpringTextBox();
            this.tsbGo = new System.Windows.Forms.ToolStripButton();
            this.tsQuickLinks = new System.Windows.Forms.ToolStrip();
            this.tsbLinkGoogle = new System.Windows.Forms.ToolStripButton();
            this.tsbLinkCustomScheme = new System.Windows.Forms.ToolStripButton();
            this.tsbLinkBing = new System.Windows.Forms.ToolStripButton();
            this.tscMain.BottomToolStripPanel.SuspendLayout();
            this.tscMain.ContentPanel.SuspendLayout();
            this.tscMain.TopToolStripPanel.SuspendLayout();
            this.tscMain.SuspendLayout();
            this.tsStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).BeginInit();
            this.tsHeader.SuspendLayout();
            this.tsQuickLinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscMain
            // 
            // 
            // tscMain.BottomToolStripPanel
            // 
            this.tscMain.BottomToolStripPanel.Controls.Add(this.tsStatus);
            // 
            // tscMain.ContentPanel
            // 
            this.tscMain.ContentPanel.Controls.Add(this.wvBrowser);
            this.tscMain.ContentPanel.Size = new System.Drawing.Size(676, 468);
            this.tscMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscMain.LeftToolStripPanelVisible = false;
            this.tscMain.Location = new System.Drawing.Point(0, 0);
            this.tscMain.Name = "tscMain";
            this.tscMain.RightToolStripPanelVisible = false;
            this.tscMain.Size = new System.Drawing.Size(676, 543);
            this.tscMain.TabIndex = 0;
            this.tscMain.Text = "toolStripContainer1";
            // 
            // tscMain.TopToolStripPanel
            // 
            this.tscMain.TopToolStripPanel.Controls.Add(this.tsHeader);
            this.tscMain.TopToolStripPanel.Controls.Add(this.tsQuickLinks);
            // 
            // tsStatus
            // 
            this.tsStatus.AllowMerge = false;
            this.tsStatus.CanOverflow = false;
            this.tsStatus.Dock = System.Windows.Forms.DockStyle.None;
            this.tsStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSpinner,
            this.tsbHttps,
            this.tslCountUrl,
            this.tslCountScheme,
            this.tslCurrentUrl});
            this.tsStatus.Location = new System.Drawing.Point(0, 0);
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(676, 25);
            this.tsStatus.Stretch = true;
            this.tsStatus.TabIndex = 0;
            // 
            // tsbSpinner
            // 
            this.tsbSpinner.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSpinner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSpinner.Image = global::WebView2Demo.Properties.Resources.SpinnerOff;
            this.tsbSpinner.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSpinner.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.tsbSpinner.Name = "tsbSpinner";
            this.tsbSpinner.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsbSpinner.Size = new System.Drawing.Size(23, 22);
            // 
            // tsbHttps
            // 
            this.tsbHttps.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbHttps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHttps.Image = global::WebView2Demo.Properties.Resources.SecureNeutral;
            this.tsbHttps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHttps.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.tsbHttps.Name = "tsbHttps";
            this.tsbHttps.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsbHttps.Size = new System.Drawing.Size(23, 22);
            // 
            // tslCountUrl
            // 
            this.tslCountUrl.Name = "tslCountUrl";
            this.tslCountUrl.Size = new System.Drawing.Size(34, 22);
            this.tslCountUrl.Text = "Url: 0";
            // 
            // tslCountScheme
            // 
            this.tslCountScheme.Name = "tslCountScheme";
            this.tslCountScheme.Size = new System.Drawing.Size(61, 22);
            this.tslCountScheme.Text = "Scheme: 0";
            // 
            // tslCurrentUrl
            // 
            this.tslCurrentUrl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslCurrentUrl.Name = "tslCurrentUrl";
            this.tslCurrentUrl.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tslCurrentUrl.Size = new System.Drawing.Size(59, 22);
            this.tslCurrentUrl.Text = "(pending)";
            // 
            // wvBrowser
            // 
            this.wvBrowser.CreationProperties = null;
            this.wvBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvBrowser.Location = new System.Drawing.Point(0, 0);
            this.wvBrowser.Name = "wvBrowser";
            this.wvBrowser.Size = new System.Drawing.Size(676, 468);
            this.wvBrowser.TabIndex = 0;
            this.wvBrowser.ZoomFactor = 1D;
            this.wvBrowser.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.HandleWebViewInitialized);
            // 
            // tsHeader
            // 
            this.tsHeader.AllowMerge = false;
            this.tsHeader.CanOverflow = false;
            this.tsHeader.Dock = System.Windows.Forms.DockStyle.None;
            this.tsHeader.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBack,
            this.tsbForward,
            this.tsbReload,
            this.tstbUrl,
            this.tsbGo});
            this.tsHeader.Location = new System.Drawing.Point(0, 0);
            this.tsHeader.Name = "tsHeader";
            this.tsHeader.Size = new System.Drawing.Size(676, 25);
            this.tsHeader.Stretch = true;
            this.tsHeader.TabIndex = 0;
            // 
            // tsbBack
            // 
            this.tsbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBack.Image = global::WebView2Demo.Properties.Resources.Back;
            this.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBack.Name = "tsbBack";
            this.tsbBack.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsbBack.Size = new System.Drawing.Size(23, 22);
            this.tsbBack.Text = "&Back";
            this.tsbBack.Click += new System.EventHandler(this.HandleBackClicked);
            // 
            // tsbForward
            // 
            this.tsbForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbForward.Image = global::WebView2Demo.Properties.Resources.Forward;
            this.tsbForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbForward.Name = "tsbForward";
            this.tsbForward.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsbForward.Size = new System.Drawing.Size(23, 22);
            this.tsbForward.Text = "&Forward";
            this.tsbForward.Click += new System.EventHandler(this.HandleForwardClicked);
            // 
            // tsbReload
            // 
            this.tsbReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReload.Image = global::WebView2Demo.Properties.Resources.Refresh;
            this.tsbReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReload.Name = "tsbReload";
            this.tsbReload.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsbReload.Size = new System.Drawing.Size(23, 22);
            this.tsbReload.Text = "Reload";
            this.tsbReload.ToolTipText = "Reload";
            this.tsbReload.Click += new System.EventHandler(this.HandleReloadClicked);
            // 
            // tstbUrl
            // 
            this.tstbUrl.Name = "tstbUrl";
            this.tstbUrl.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tstbUrl.Size = new System.Drawing.Size(550, 25);
            this.tstbUrl.ToolTipText = "Url";
            this.tstbUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleUrlKeyDown);
            // 
            // tsbGo
            // 
            this.tsbGo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGo.Image = global::WebView2Demo.Properties.Resources.Go;
            this.tsbGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGo.Name = "tsbGo";
            this.tsbGo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsbGo.Size = new System.Drawing.Size(23, 22);
            this.tsbGo.Text = "Go";
            this.tsbGo.Click += new System.EventHandler(this.HandleGoClicked);
            // 
            // tsQuickLinks
            // 
            this.tsQuickLinks.Dock = System.Windows.Forms.DockStyle.None;
            this.tsQuickLinks.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsQuickLinks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLinkBing,
            this.tsbLinkGoogle,
            this.tsbLinkCustomScheme});
            this.tsQuickLinks.Location = new System.Drawing.Point(0, 25);
            this.tsQuickLinks.Name = "tsQuickLinks";
            this.tsQuickLinks.Size = new System.Drawing.Size(676, 25);
            this.tsQuickLinks.Stretch = true;
            this.tsQuickLinks.TabIndex = 1;
            // 
            // tsbLinkGoogle
            // 
            this.tsbLinkGoogle.Image = ((System.Drawing.Image)(resources.GetObject("tsbLinkGoogle.Image")));
            this.tsbLinkGoogle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLinkGoogle.Name = "tsbLinkGoogle";
            this.tsbLinkGoogle.Size = new System.Drawing.Size(65, 22);
            this.tsbLinkGoogle.Tag = "https://www.google.com";
            this.tsbLinkGoogle.Text = "Google";
            this.tsbLinkGoogle.Click += new System.EventHandler(this.HandleQuickLinkClicked);
            // 
            // tsbLinkCustomScheme
            // 
            this.tsbLinkCustomScheme.Image = ((System.Drawing.Image)(resources.GetObject("tsbLinkCustomScheme.Image")));
            this.tsbLinkCustomScheme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLinkCustomScheme.Name = "tsbLinkCustomScheme";
            this.tsbLinkCustomScheme.Size = new System.Drawing.Size(114, 22);
            this.tsbLinkCustomScheme.Tag = "app-scheme://myapp/user/details";
            this.tsbLinkCustomScheme.Text = "Custom Scheme";
            this.tsbLinkCustomScheme.Click += new System.EventHandler(this.HandleQuickLinkClicked);
            // 
            // tsbLinkBing
            // 
            this.tsbLinkBing.Image = ((System.Drawing.Image)(resources.GetObject("tsbLinkBing.Image")));
            this.tsbLinkBing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLinkBing.Name = "tsbLinkBing";
            this.tsbLinkBing.Size = new System.Drawing.Size(51, 22);
            this.tsbLinkBing.Tag = "https://www.bing.com";
            this.tsbLinkBing.Text = "Bing";
            this.tsbLinkBing.Click += new System.EventHandler(this.HandleQuickLinkClicked);
            // 
            // WebViewContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 543);
            this.Controls.Add(this.tscMain);
            this.Name = "WebViewContainer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HandleWebViewContainerLoad);
            this.tscMain.BottomToolStripPanel.ResumeLayout(false);
            this.tscMain.BottomToolStripPanel.PerformLayout();
            this.tscMain.ContentPanel.ResumeLayout(false);
            this.tscMain.TopToolStripPanel.ResumeLayout(false);
            this.tscMain.TopToolStripPanel.PerformLayout();
            this.tscMain.ResumeLayout(false);
            this.tscMain.PerformLayout();
            this.tsStatus.ResumeLayout(false);
            this.tsStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).EndInit();
            this.tsHeader.ResumeLayout(false);
            this.tsHeader.PerformLayout();
            this.tsQuickLinks.ResumeLayout(false);
            this.tsQuickLinks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscMain;
        private System.Windows.Forms.ToolStrip tsHeader;
        private System.Windows.Forms.ToolStripButton tsbBack;
        private System.Windows.Forms.ToolStripButton tsbForward;
        private System.Windows.Forms.ToolStripButton tsbReload;
        private WebView2Demo.Support.ToolStripSpringTextBox tstbUrl;
        private System.Windows.Forms.ToolStripButton tsbGo;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvBrowser;
        private System.Windows.Forms.ToolStrip tsQuickLinks;
        private System.Windows.Forms.ToolStripButton tsbLinkGoogle;
        private System.Windows.Forms.ToolStrip tsStatus;
        private System.Windows.Forms.ToolStripButton tsbSpinner;
        private System.Windows.Forms.ToolStripButton tsbHttps;
        private System.Windows.Forms.ToolStripLabel tslCurrentUrl;
        private System.Windows.Forms.ToolStripButton tsbLinkCustomScheme;
        private System.Windows.Forms.ToolStripLabel tslCountScheme;
        private System.Windows.Forms.ToolStripLabel tslCountUrl;
        private System.Windows.Forms.ToolStripButton tsbLinkBing;
    }
}

