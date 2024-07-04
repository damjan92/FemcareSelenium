using AutomatedTest.PageObjects;
using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;

namespace AutomatedTest.POM.PageObjects
{

    public class HomePage : BaseMainPage
    {
        #region Selectors

        public override By RootSelector => By.ClassName("hero-slide");       
		public By ErrorMessage => By.CssSelector("div[class='alert-danger']");
		public By NavigationBar => By.ClassName("navigation-bar");
		public By BodyformNavIcon => By.CssSelector("#Ebene_1MainNavigation");
		public By SearchIcon => By.CssSelector("i[class='icon-search']");
		public By EssityFooterLogo => By.CssSelector("div[class='global-footer__essity-logo']");
		public By FooterLinks => By.CssSelector("ul[class='global-footer__links']");

		#endregion

		#region Web elements

		public IWebElement BodyformNavIconWebElement => Driver.FindElementWait(BodyformNavIcon);
        public IWebElement ErrorMessageWebElement => Driver.FindElementWait(ErrorMessage);
		public IWebElement NavigationBarWebElement => Driver.FindElementWait(NavigationBar);
		public IWebElement SearchIconWebElement => Driver.FindElementWait(SearchIcon);
		public IWebElement EssityFooterLogoWebElement => Driver.FindElementWait(EssityFooterLogo);
		public IList<IWebElement> FooterLinksWebElements => Driver.FindElementsWait(FooterLinks);

		#endregion

		#region Contructor and methods

		public HomePage(Browser browser, string url = "") : base(browser, url)
        {

        }

        public override bool IsPageLoaded() => RootElement.Text.ToLowerInvariant().Contains("events");
        public bool IsNavigationBarLoaded() => NavigationBarWebElement.Displayed;
		public bool IsErrorMessageDisplayed() => WebDriverExtensions.CheckForErrors(ErrorMessage, Driver);
		public bool IsBodyformNavIconDisplayed() => BodyformNavIconWebElement.Displayed;
		public bool IsSearchIconDisplayed() => SearchIconWebElement.Displayed;
		public bool IsEssityFooterLogoDisplayed() => EssityFooterLogoWebElement.Displayed;
		//public bool AreFooterLinksDisplayed() => FooterLinksWebElements.Displayed;

		#endregion
	}
}
