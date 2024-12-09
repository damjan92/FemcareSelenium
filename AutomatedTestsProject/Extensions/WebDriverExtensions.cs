using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;

namespace AutomatedTests.Framework.Extensions
{
    public static class WebDriverExtensions
    {
        private static readonly TimeSpan DefaultFindElementTimeout = TimeSpan.FromSeconds(10);

		
        /// <summary>
        /// Wait Until function
        /// </summary>       
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

        /// <summary>
        /// Find Element Wait - ExpectedCondition
        /// </summary>
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
		/// <summary>
		/// Send keys
		/// </summary>        
		public static void WaitForElementToSendKeys(this IWebDriver webDriver, By by, string data, int timeoutSeconds = 5)
		{
			try
			{
				var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeoutSeconds));
				Actions action = new(webDriver);


				wait.Until(ExpectedConditions.ElementToBeClickable(by));
				IWebElement webElement = by.FindElement(webDriver);

				webElement.SendKeys(data);
				webElement.SendKeys(Keys.Return);

			}
			catch (Exception)
			{
				throw new Exception($"Element is not clickable to send  keys [{by.Criteria}]");
			}
		}
		public static void ConfirmSearch(this IWebDriver webDriver)
		{
			Actions action = new Actions(webDriver);
			action.SendKeys(Keys.Return).Perform();
		}
        /// <summary>
        /// Hover and Click actions
        /// </summary>
        public static void WaitElementForHoverAndClick(this IWebDriver webDriver, By by, int timeoutSeconds = 5)
        {
			try
			{
				Actions action = new Actions(webDriver);
				IWebElement webElement = by.FindElement(webDriver);
                //IWebElement webElementHover = byHover.FindElement(webDriver);

				action.MoveToElement(webElement).Build().Perform();
			}
			catch (Exception)
			{
				throw new Exception($"Element is not clickable to send  keys [{by.Criteria}]");
			}
		}
		/// <summary>
		/// Find Elmements
		/// </summary>    
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
        public static bool AreElementsDisplayed(IList<IWebElement> webElements)
        {
            try
            {
                if (!webElements.Any())
                {
                    Console.WriteLine("");
                    return false;
                }
                foreach (var item in webElements)
                {
                    if (item.Displayed == true)
                    {
                        Console.WriteLine($"Elements: [{item.GetAttribute("class")}]is displayed");
                    }
                }
                return true;
            }
			catch
			{
				throw new Exception($"No such elements with selector");
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
            catch
            {
				throw new ElementNotVisibleException($"Element is not visible with: [{by.Criteria}]");
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
                Console.WriteLine($"There is not such a element: {by.Criteria}");
                return false;
            }
        }

       
        /// <summary>
        /// Click the element by a IWebElement locator
        /// </summary>
        public static bool ClickTheWebElement(IWebElement webElement)
        {
			try
			{
				webElement.Click();
                Console.WriteLine($"Element[{webElement.Text}]Element is clicked");
                return true;
			}
			catch
			{
				throw new ElementNotVisibleException($"Element [{webElement.Text}] is not clickable nor visible");
			}
		}
		/*public static bool ClickTheWebElement(By by)
		{
			try
			{
				IWebElement webElement = Driver.FindElementsWait(ExpectedConditions.ElementToBeClickable(by));
				Console.WriteLine($"Element[{by.Criteria}]Element is clicked");
				return true;
			}
			catch
			{
				throw new ElementNotVisibleException($"Element [{by.Criteria}] is not clickable nor visible");
			}
		}*/

		/// <summary>
		/// Return the indicator number
		/// </summary>
		public static int GetIndicatorNumberOfProducts(IWebElement webElement)
        {
			try
			{                		
				if (webElement != null)
				{
					Console.WriteLine($"Number is : [{int.Parse(webElement.Text)}]");
					return int.Parse(webElement.Text);
				}
				else
				{					
                    return 0;
				}

			}
			catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return 0; 
            }
        }
		/// <summary>
		/// Return the number of products
		/// </summary>
		public static int GetNumberOfProducts(IList<IWebElement> webElement)
		{
			try
			{
				if (webElement != null)
				{
                    Console.WriteLine($"Number is : [{webElement.Count}]");
                    return  webElement.Count;
				}
				else
				{
                    Console.WriteLine("Cannot get total number");
                    return 0;
				}

			}
			catch (Exception e)
			{
				Console.WriteLine($"Error: {e.Message}");
				return 0;
			}
		}
        /// <summary>
        /// Get rest status of images, return status 200 if image is loaded properly
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="tab"></param>
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
