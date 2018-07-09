using CefSharp;
using CefSharp.WinForms;
using System;
using System.Windows.Forms;

namespace JapaneseApp.UserControls
{
    public partial class CefSharpBrowser : UserControl
    {
        public ChromiumWebBrowser chromeBrowser { get; private set; }
        public CefSharpBrowser()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            // Set BrowserSubProcessPath based on app bitness at runtime
            settings.BrowserSubprocessPath = System.IO.Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
                                                   Environment.Is64BitProcess ? "x64" : "x86",
                                                   "CefSharp.BrowserSubprocess.exe");
            // Make sure you set performDependencyCheck false
            Cef.Initialize(settings, performDependencyCheck: false, browserProcessHandler: null);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("https://djtguide.neocities.org/");

            chromeBrowser.Dock = DockStyle.Fill;

            chromeBrowserPanel.Controls.Add(chromeBrowser);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.CanGoBack)
            {
                chromeBrowser.Back();
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.CanGoForward)
            {
                chromeBrowser.Forward();
            }
        }

        public void Load(string url)
        {
            chromeBrowser.Load(url);
        }

        public void Close()
        {
            Cef.Shutdown();
        }
    }
}
