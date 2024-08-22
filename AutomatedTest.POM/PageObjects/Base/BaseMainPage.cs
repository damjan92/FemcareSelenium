using AutomatedTests.Framework.Core;
using AutomatedTest.POM.PageObjects;

namespace AutomatedTest.PageObjects
{
    public abstract class BaseMainPage : BasePage
    {
        private readonly string _pageUrl;

        protected BaseMainPage(Browser browser, string url = "", bool navigate = true) : base(browser)
        {
            _pageUrl = url;

            if (navigate)
            {
                Navigate(_pageUrl);
            }
        }

        public void Navigate(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public void LoadPage()
        {
            Navigate(_pageUrl);
        }

        public string GetCurrentUrl()
        {
            return Driver.Url;
        }
    }
}
