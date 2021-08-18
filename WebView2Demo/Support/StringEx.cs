namespace WebView2Demo.Support
{
    internal static class StringEx
    {
        internal static string NullIf(this string input)
        {
            return string.IsNullOrWhiteSpace(input) ? null : input;
        }
    }
}