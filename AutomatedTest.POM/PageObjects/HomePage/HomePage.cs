using AutomatedTest.PageObjects;
using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomatedTest.POM.PageObjects
{

    public class HomePage : BaseMainPage
    {
        #region Selectors

        public override By RootSelector => By.ClassName("hero-slide");       
		public By ErrorMessage => By.CssSelector("div[class='alert-danger']");
		public By NavigationBar => By.ClassName("navigation-bar");
		public By BodyformNavIcon => By.CssSelector("#Ebene_1MainNavigation");
		public By SearchIcon => By.CssSelector("div[class*=\"navigation-bar__icon--search\"]");
		
		public By EssityFooterLogo => By.CssSelector("div[class='global-footer__essity-logo']");
		public By FooterLinks => By.CssSelector("ul[class='global-footer__links']");

		#endregion

		#region Web elements

		public IWebElement BodyformNavIconWebElement => Driver.FindElementWait(BodyformNavIcon, ExpectedConditions.ElementToBeClickable(BodyformNavIcon));		
		public IWebElement NavigationBarWebElement => Driver.FindElementWait(NavigationBar, ExpectedConditions.ElementIsVisible(NavigationBar));
		public IWebElement SearchIconWebElement => Driver.FindElementWait(SearchIcon, ExpectedConditions.ElementIsVisible(SearchIcon), 5);
		public IWebElement EssityFooterLogoWebElement => Driver.FindElementWait(EssityFooterLogo);
		public IList<IWebElement> FooterLinksWebElements => Driver.FindElementsWait(FooterLinks);

		#endregion

		#region Contructor and methods

		public HomePage(Browser browser, string url = "") : base(browser, url)
        {

        }

        public override bool IsPageLoaded() => RootElement.Text.ToLowerInvariant().Contains("events");
        public bool IsNavigationBarLoaded() => NavigationBarWebElement.Displayed;
		public bool IsErrorMessageDisplayed() => Driver.WaitForElementIsVisible(ErrorMessage, 5);
		public bool IsBodyformNavIconDisplayed() => BodyformNavIconWebElement.Displayed;
		public bool IsSearchIconDisplayed() => SearchIconWebElement.Displayed;
		public bool IsEssityFooterLogoDisplayed() => EssityFooterLogoWebElement.Displayed;
		public bool AreFooterLinksDisplayed() => WebDriverExtensions.AreElementsDisplayed(FooterLinksWebElements);

		#endregion
	}
}
