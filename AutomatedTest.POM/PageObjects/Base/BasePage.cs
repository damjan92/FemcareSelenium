using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomatedTest.POM.PageObjects
{
    public abstract class BasePage
    {
        public Browser Browser { get; set; }
        public IWebDriver Driver { get; set; }
        public TestSettings AutomatedTestSettings = TestSettings.GetTestSettings();

        public virtual By RootSelector { get; set; }

        protected BasePage(Browser browser)
        {
            this.Browser = browser;
            this.Driver = browser.BrowserDriver;
        }
		public bool IsDisplayed(By by, int timeout = 10)
		{
			try
			{				
				IWebElement webElement = Driver.FindElementWait(by, ExpectedConditions.ElementIsVisible(by));
				Console.WriteLine($"Element: [{by}] is Displayed");
				return webElement.Displayed;
			}
			catch (NoSuchElementException)
			{
				Console.WriteLine($"Element: [{by}] not found");
				return false;
			}
			catch (WebDriverTimeoutException)
			{
				Console.WriteLine($"Element: [{by}] waiting timeout");
				return false;
			}
		}

		public bool IsDisplayedAndClickable(By by, int timeout = 10)
		{
			try
			{
				IWebElement webElement = Driver.FindElementWait(by, ExpectedConditions.ElementToBeClickable(by));
				Console.WriteLine($"Element: [{by}] is Displayed");
				return webElement.Displayed;
			}
			catch (NoSuchElementException)
			{
				Console.WriteLine($"Element: [{by}] not found");
				return false;
			}
			catch (WebDriverTimeoutException)
			{
				Console.WriteLine($"Element: [{by}] waiting timeout");
				return false;
			}
		}

		public bool IsClicked(By by)
		{
			try
			{
				IWebElement webElement = Driver.FindElementWait(by, ExpectedConditions.ElementToBeClickable(by));
				webElement.Click();
				Console.WriteLine($"Element[{webElement.Text}]Element is clicked");
				return true;
			}
			catch
			{
				throw new ElementNotVisibleException($"Element [{by.Criteria}] is not clickable nor visible");
			}
		}


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
        public IWebElement RootElement => Driver.FindElementWait(RootSelector);
		public bool IsRootSelectorVisible() => true;
    }
}
