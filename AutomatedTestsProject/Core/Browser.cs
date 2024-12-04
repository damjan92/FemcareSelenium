using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;

namespace AutomatedTests.Framework.Core
{
    public class Browser
    {
        public IWebDriver BrowserDriver { get; set; }

        private string downloadPath;

        public string DownloadPath
        {
            get
            {
                if (downloadPath == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Init.");
                }
                return downloadPath;
            }

            private set => downloadPath = value;
        }

        public Browser(BrowserSettings settings)
        {
            Init(settings);
        }

        private ChromeDriver BuildChromeDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("download.default_directory", DownloadPath);
			chromeOptions.AddArgument("--headless");
			chromeOptions.AddArgument("--incognito");

			return new ChromeDriver(chromeOptions);
        }

        private InternetExplorerDriver BuildInternetExplorerDriver()
        {
            // There is no clean way to set download directory for Internet Explorer
            return new InternetExplorerDriver();
        }

        private FirefoxDriver BuildFirefoxDriver()
        {
            FirefoxProfile firefoxProfile = new FirefoxProfile();
            firefoxProfile.SetPreference("browser.download.dir", DownloadPath);

            FirefoxOptions firefoxOptions = new FirefoxOptions()
            {
                Profile = firefoxProfile
            };

            return new FirefoxDriver(firefoxOptions);
        }

        private void Init(BrowserSettings settings)
        {
            var browser = settings.BrowserType;

            DownloadPath = Path.Combine(settings.AssemblyDirectory, Path.GetRandomFileName());
            Directory.CreateDirectory(DownloadPath);

            switch (browser)
            {
                case BrowserType.Chrome:
                    BrowserDriver = BuildChromeDriver();
                    break;
                case BrowserType.InternetExplorer:
                    BrowserDriver = BuildInternetExplorerDriver();
                    break;
                case BrowserType.Firefox:
                    BrowserDriver = BuildFirefoxDriver();
                    break;
                default:
                    BrowserDriver = BuildChromeDriver();
                    break;
            }

            BrowserDriver.Manage().Window.Maximize();
        }

        public void Close()
        {
            Directory.Delete(DownloadPath, true);
            BrowserDriver.Close();
        }

        public void Quit()
        {
            Directory.Delete(DownloadPath, true);
            BrowserDriver.Quit();
        }
    }
}
