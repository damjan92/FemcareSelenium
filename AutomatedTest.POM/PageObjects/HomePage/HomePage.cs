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
		public IList<IWebElement> FooterMenuLinksWebElements => Driver.FindElementsWait(FooterMenuLinks);

		#endregion

		#region Contructor and methods

		public HomePage(Browser browser, string url = "") : base(browser, url)
        {
        }

		public bool IsNavigationBarLoaded() => IsDisplayed(NavigationBar);
		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		public bool IsBodyformNavIconDisplayed() => IsDisplayed(BodyformNavIcon);
		public bool IsSearchIconDisplayed() => IsDisplayed(SearchIcon);
		public bool IsEssityFooterLogoDisplayed() => IsDisplayed(EssityFooterLogo);
		public bool IsFooterSocialLinksDisplayed() => IsDisplayed(FooterMenuLinks);

		public bool AreFooterMenuLinksDisplayed() => WebDriverExtensions.AreElementsDisplayed(FooterMenuLinksWebElements);

		#endregion
	}
}
