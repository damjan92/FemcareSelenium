using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Femcare.Selenium.Framework.Extensions
{
    public static class WebDriverExtensions
    {
        private static readonly TimeSpan DefaultFindElementTimeout = TimeSpan.FromSeconds(10);
       
        public static bool WaitUntil(this IWebDriver webDriver, Func<IWebDriver, bool> func, int timeoutInSeconds = 5)
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(func);
        }

        public static IWebElement WaitUntil(this IWebDriver webDriver, Func<IWebDriver, IWebElement> func, int timeoutInSeconds = 5)
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(func);
        }

        public static IWebElement FindElementWait(
            this IWebDriver driver,
            By by, Func<IWebDriver, IWebElement> condition = null, int timeoutInSeconds = 5)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));

                return condition != null ? wait.Until(condition) : wait.Until(ExpectedConditions.ElementExists(by));

            }
            catch (Exception e)
            {
                throw new Exception($"No such element with selector [{by.Criteria}]");
            }
        }

        public static IWebElement? FindElementWait(
            this IWebDriver driver,
            By by, Func<IWebDriver, bool> condition, int timeoutInSeconds = 2)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));

                if (condition != null)
                {
                    return wait.Until(condition) ? wait.Until(ExpectedConditions.ElementExists(by)) : null;
                }

                return wait.Until(drv => drv.FindElement(by));
            }
            catch (Exception e)
            {
                throw new Exception($"No such element with selector [{by.Criteria}]");
            }
        }

        public static IList<IWebElement> FindElementsWait(this IWebDriver driver, By by, int timeoutSeconds = 5)
        {
            try
            {
                if (timeoutSeconds > 0)
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));

                    wait.Until(drv => drv.FindElementWait(by));
                }

                return driver.FindElements(by);
            }
            catch (Exception e)
            {
                throw new Exception($"No such elements with selector [{by.Criteria}]");
            }
        }

        public static void WaitForElementToBeClickable(this IWebDriver webDriver, By by, int timeoutSeconds = 5)
        {
            try
            {
                var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeoutSeconds));

                wait.Until(ExpectedConditions.ElementToBeClickable(by));
            }
            catch (Exception)
            {
                throw new Exception($"Element is not clickable [{by.Criteria}]");
            }
        }
             
        public static bool WaitForElementIsVisible(this IWebDriver webDriver, By by, int timeoutSeconds = 5)
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeoutSeconds));

            try
            {
                return wait.Until(ExpectedConditions.ElementIsVisible(by)) != null;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        ///<summary>
        ///Generic method to check if an element is present in the page DOM - using as input an BY type definition.
        ///</summary>
        public static bool IsElementContainedBy(this IWebDriver webDriver, By by, int timeoutSeconds = 5)
        {
            try
            {
                return webDriver.FindElements(by).Any();
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        ///<summary>
        ///Generic method to check if an element defined by a BY locator is displayed on the current screen view - using selenium.
        ///</summary>
        public static bool IsElementDisplayedBy(this IWebDriver webDriver, By by)
        {
            try
            {
                return webDriver.FindElementWait(by).Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static void SwitchToTab(this IWebDriver webDriver, int tab)
        {
            webDriver.SwitchTo().Window(webDriver.WindowHandles[tab]);
        }

        public static void CloseTab(this IWebDriver webDriver, int tab)
        {
            webDriver.SwitchTo().Window(webDriver.WindowHandles[tab]).Close();
        }

        public static void ScrollElementIntoCenterOfView(this IWebDriver driver, IWebElement element)
        {
            var scrollElementIntoMiddleScript = "var viewPortHeight = Math.max(document.documentElement.clientHeight, window.innerHeight || 0);"
                                                + "var elementTop = arguments[0].getBoundingClientRect().top;"
                                                + "window.scrollBy(0, elementTop-(viewPortHeight/2));";

            ((IJavaScriptExecutor)driver).ExecuteScript(scrollElementIntoMiddleScript, element);
        }
    }
}
