using AutomatedTest.PageObjects;
using AutomatedTests.Framework.Core;
using OpenQA.Selenium;
using AutomatedTests.Framework.Extensions;
using SeleniumExtras.WaitHelpers;

namespace AutomatedTest.POM.PageObjects
{
	public class ProductLandingPage : BaseMainPage
	{

		#region Selectors
		public By Indicator => By.CssSelector("div[class='product-filter__occurrences'] span");
		public By Title => By.TagName("h1");
		public By Breadcrumbs => By.CssSelector("div[class='breadcrumbs']");
		// Products list related
		public By FilterByButton => By.CssSelector("a[class='btn btn-secondary btn-narrow init-filter']");
		public By SortButton => By.CssSelector("div[class*='product-list__item'");
		public By ExploreAllProducts => By.CssSelector("a[class='product-list-back__button']");
		// Product list - Group of elements
		public By ProductList => By.CssSelector("div[class*='product-list__item'");
		public By ProductListRangeSlider => By.CssSelector("div[class*='swiper-slide cta-panel-slide']");
		//Product Detail - Gruop of elements
		public By BazaarVoiceRatings_Group => By.CssSelector("div[class='bv_stars_component_container']");
		public By RatingsAndReviews_Group => By.CssSelector("div[class='pr-rating-stars']");
		public By ProductFlow_Group => By.CssSelector("div[class='product-metric product-metric--flow']");
		public By ProductImages_Group =>By.TagName("picture");

		//Social icons
		public By FacebookIcon => By.CssSelector("i[class='icon-share-facebook']");
		public By TwitterIcon => By.CssSelector("i[class='icon-share-twitter']");


		#endregion

		#region WebElements
		IWebElement IndicatorWebElement => Driver.FindElementWait(Indicator, ExpectedConditions.ElementIsVisible(Indicator), 3);
		IWebElement TitleWebElement => Driver.FindElementWait(Title);
		IWebElement BreadcrumbsWebElement => Driver.FindElementWait(Breadcrumbs);
		IWebElement FilterByButtonWebElement => Driver.FindElementWait(FilterByButton);
		IWebElement SortButtonWebElement => Driver.FindElementWait(SortButton);
		IWebElement ExploreAllProductsWebElement => Driver.FindElementWait(ExploreAllProducts);
		IWebElement FacebookIconWebElement => Driver.FindElementWait(FacebookIcon);
		IWebElement TwitterIconWebElement => Driver.FindElementWait(TwitterIcon);
		IList<IWebElement> ListOfProducts => Driver.FindElementsWait(ProductList);

		#endregion

		#region Constructor and methods
		public ProductLandingPage(Browser browser, string url = "") : base(browser, url)
		{
		}
		
		public bool IsIndicatorDisplayed() => IndicatorWebElement.Displayed;
		public bool IsTitleDisplayed() => TitleWebElement.Displayed;
		public bool IsBreadcrumbsDisplayed() => BreadcrumbsWebElement.Displayed;
		public bool IsFilterByButtonDisplayed() => FilterByButtonWebElement.Displayed;
		public bool IsSortButtonDisplayed() => SortButtonWebElement.Displayed;
		public bool IsExploreAllProductsDisplayed() => ExploreAllProductsWebElement.Displayed;
		public bool IsFacebookIconDisplayed() => FacebookIconWebElement.Displayed;
		public bool IsTwitterIconDisplayed() => TwitterIconWebElement.Displayed;
		public int GetIndicatorNumber() => WebDriverExtensions.GetIndicatorNumberOfProducts(IndicatorWebElement);
		public int GetNumberOfProducts() => WebDriverExtensions.GetNumberOfProducts(ListOfProducts);
		#endregion
	}
}
