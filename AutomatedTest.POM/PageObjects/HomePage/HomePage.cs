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
		
		public By EssityFooterLogo => By.CssSelector("div[class='footer__essity-logo']");
		public By FooterMenuLinks => By.CssSelector("ul[class='footer__menu-list']");
		public By FooterSocialLinks => By.CssSelector("div[class*='social--follow']");

		#endregion

		#region Web elements

		public IWebElement BodyformNavIconWebElement => Driver.FindElementWait(BodyformNavIcon, ExpectedConditions.ElementToBeClickable(BodyformNavIcon));		
		public IWebElement NavigationBarWebElement => Driver.FindElementWait(NavigationBar, ExpectedConditions.ElementIsVisible(NavigationBar));
		public IWebElement SearchIconWebElement => Driver.FindElementWait(SearchIcon, ExpectedConditions.ElementIsVisible(SearchIcon), 3);
		public IWebElement EssityFooterLogoWebElement => Driver.FindElementWait(EssityFooterLogo, ExpectedConditions.ElementIsVisible(EssityFooterLogo));
		public IWebElement FooterSocialLinksWebElement => Driver.FindElementWait(FooterSocialLinks, ExpectedConditions.ElementIsVisible(FooterSocialLinks));
		public IList<IWebElement> FooterMenuLinksWebElements => Driver.FindElementsWait(FooterMenuLinks);

		#endregion

		#region Contructor and methods

		public HomePage(Browser browser, string url = "") : base(browser, url)
        {
        }

        public override bool IsPageLoaded() => RootElement.Text.ToLowerInvariant().Contains("events");
        public bool IsNavigationBarLoaded() => NavigationBarWebElement.Displayed;
		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		public bool IsBodyformNavIconDisplayed() => BodyformNavIconWebElement.Displayed;
		public bool IsSearchIconDisplayed() => SearchIconWebElement.Displayed;
		public bool IsEssityFooterLogoDisplayed() => EssityFooterLogoWebElement.Displayed;
		public bool IsFooterSocialLinksDisplayed() => FooterSocialLinksWebElement.Displayed;

		public bool AreFooterMenuLinksDisplayed() => WebDriverExtensions.AreElementsDisplayed(FooterMenuLinksWebElements);

		#endregion
	}
}
