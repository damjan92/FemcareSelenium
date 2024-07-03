using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;

namespace AutomatedTest.POM.PageObjects
{
    public abstract class BasePage
    {
        public Browser Browser { get; set; }
        public IWebDriver Driver { get; set; }
        public TestSettings AutomatedTestSettings = TestSettings.GetTestSettings();

        public virtual By RootSelector { get; set; }
        public IWebElement RootElement => Driver.FindElementWait(RootSelector);

        protected BasePage(Browser browser)
        {
            this.Browser = browser;
            this.Driver = browser.BrowserDriver;
        }

        public bool IsRootSelectorVisible() => true;

        public virtual bool IsPageLoaded()
        {
            return Driver.FindElement(RootSelector).Displayed;
        }

        public void GoBack()
        {
            Driver.Navigate().Back();
        }
    
        public string GetCurrentWindowHandle()
        {
            return Driver.CurrentWindowHandle;
        }

        public void SwitchToTab(string windowHandle)
        {
            Driver.SwitchTo().Window(windowHandle);
        }

        public void CloseTab(string windowHandleToClose)
        {
            SwitchToTab(windowHandleToClose);
            Driver.Close();
        }
    }
}
