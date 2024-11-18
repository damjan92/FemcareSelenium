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
		public By ErrorMessage => By.CssSelector("div[class='alert-danger']");
		public By Indicator => By.CssSelector("div[class='product-filter__occurrences'] span");
		public By Title => By.TagName("h1");
		public By Breadcrumbs => By.CssSelector("ol[class='breadcrumbs__list']");
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
		public By SocialLinks => By.CssSelector("ul[class='social__list']");
		/// <summary>
		/// Quick Buy Modal
		/// </summary>
		public By ProductInPcp => By.CssSelector("div[class='product-list__item']:nth-child(1)");
		public By QuickBuyButton => By.CssSelector("div[class='product-list__item']:nth-child(1) div[class*='cta-panel__quick-buy-button']");
		public By QuickBuyModal => By.CssSelector("div[class='cta-panel__quick-buy-modal--wrapper']");
		public By ModalTitle => By.CssSelector("h1[class='product-main__title']");
		public By ModalOldPrice => By.CssSelector("div[class*='product-main-purchase__amount--old']");
		public By ModalNewPrice => By.CssSelector("div[class*='product-main-purchase__amount--new']");
		public By ModalRatings => By.CssSelector("div[class='product-main__rating']");
		public By ModalSizeGuide => By.CssSelector("div[class*='form-group--chips']");
		public By ModalAddToCartCounter => By.CssSelector("div[class='product-cart-add__counter']");
		public By ModalAddToCartButton => By.CssSelector("button[class*='product-cart-add__button']");
		public By ModalViewProductButton => By.CssSelector("div[class='cta-panel__quick-buy-modal--view-details']");

		#endregion

		#region WebElements
		IWebElement IndicatorWebElement => Driver.FindElementWait(Indicator, ExpectedConditions.ElementIsVisible(Indicator), 3);
		IWebElement TitleWebElement => Driver.FindElementWait(Title, ExpectedConditions.ElementIsVisible(Title));
		IWebElement BreadcrumbsWebElement => Driver.FindElementWait(Breadcrumbs, ExpectedConditions.ElementIsVisible(Breadcrumbs));
		IWebElement FilterByButtonWebElement => Driver.FindElementWait(FilterByButton, ExpectedConditions.ElementIsVisible(FilterByButton));
		IWebElement SortButtonWebElement => Driver.FindElementWait(SortButton, ExpectedConditions.ElementIsVisible(SortButton));
		IWebElement ExploreAllProductsWebElement => Driver.FindElementWait(ExploreAllProducts, ExpectedConditions.ElementToBeClickable(ExploreAllProducts));
		IWebElement SocialLinkWebElement => Driver.FindElementWait(SocialLinks, ExpectedConditions.ElementToBeClickable(SocialLinks));
		IList<IWebElement> ListOfProducts => Driver.FindElementsWait(ProductList);
		/// <summary>
		/// Quick Buy Modal
		/// </summary>
		/// 
		IWebElement ProductInPcpWebElement => Driver.FindElementWait(ProductInPcp, ExpectedConditions.ElementIsVisible(ProductInPcp));
		IWebElement QuickBuyButtonWebElement => Driver.FindElementWait(QuickBuyButton, ExpectedConditions.ElementIsVisible(QuickBuyButton));
		IWebElement QuickBuyModalWebElement => Driver.FindElementWait(QuickBuyModal,ExpectedConditions.ElementIsVisible(QuickBuyModal));
		IWebElement ModalTitleWebElement => Driver.FindElementWait(ModalTitle, ExpectedConditions.ElementIsVisible(ModalTitle));
		IWebElement ModalOldPriceWebElement => Driver.FindElementWait(ModalOldPrice, ExpectedConditions.ElementIsVisible(ModalOldPrice));
		IWebElement ModalNewPriceWebElement => Driver.FindElementWait(ModalNewPrice, ExpectedConditions.ElementIsVisible(ModalNewPrice));
		IWebElement ModalRatingsWebElement => Driver.FindElementWait(ModalRatings, ExpectedConditions.ElementIsVisible(ModalRatings));
		IWebElement ModalSizeGuideWebElement => Driver.FindElementWait(ModalSizeGuide, ExpectedConditions.ElementIsVisible(ModalSizeGuide));
		IWebElement ModalAddToCartCounterWebElement => Driver.FindElementWait(ModalAddToCartCounter, ExpectedConditions.ElementIsVisible(ModalAddToCartCounter), 3);
		IWebElement ModalAddToCartButtonWebElement => Driver.FindElementWait(ModalAddToCartButton, ExpectedConditions.ElementIsVisible(ModalAddToCartButton));
		IWebElement ModalViewProductButtonWebElement => Driver.FindElementWait(ModalViewProductButton, ExpectedConditions.ElementIsVisible(ModalViewProductButton));
		#endregion

		#region Constructor and methods
		public ProductLandingPage(Browser browser, string url = "") : base(browser, url)
		{
		}
		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		public bool IsIndicatorDisplayed() => IndicatorWebElement.Displayed;
		public bool IsTitleDisplayed() => TitleWebElement.Displayed;
		public bool IsBreadcrumbsDisplayed() => BreadcrumbsWebElement.Displayed;
		public bool IsFilterByButtonDisplayed() => FilterByButtonWebElement.Displayed;
		public bool IsSortButtonDisplayed() => SortButtonWebElement.Displayed;
		public bool IsExploreAllProductsDisplayed() => ExploreAllProductsWebElement.Displayed;
		public bool IsSocialIconDisplayed() => SocialLinkWebElement.Displayed;
		public int GetIndicatorNumber() => WebDriverExtensions.GetIndicatorNumberOfProducts(IndicatorWebElement);
		public int GetNumberOfProducts() => WebDriverExtensions.GetNumberOfProducts(ListOfProducts);
		/// <summary>
		/// Quick Buy Modal
		/// </summary>
		/// 
		public bool IsProductInPcpDisplayed() => ProductInPcpWebElement.Displayed;
		public bool IsQuickBuyButtonDisplayed() => QuickBuyButtonWebElement.Displayed;
		public void IsProductInPcpHoveredAndClicked() => WebDriverExtensions.WaitElementForHoverAndClick(Driver, ProductInPcp);
		public bool IsClicked() => WebDriverExtensions.ClickTheWebElement(QuickBuyButtonWebElement);
		public bool IsQuickBuyModalDisplayed() => QuickBuyModalWebElement.Displayed;
		public bool IsModalTitleDisplayed() => ModalTitleWebElement.Displayed;
		public bool IsModalOldPriceWebElement() => ModalOldPriceWebElement.Displayed;
		public bool IsModalNewPriceWebElement() => ModalNewPriceWebElement.Displayed;
		public bool IsModalRatingsWebElement() => ModalRatingsWebElement.Displayed;
		public bool IsModalSizeGuideWebElement() => ModalSizeGuideWebElement.Displayed;
		public bool IsModalAddToCartCounterWebElement() => ModalAddToCartCounterWebElement.Displayed;
		public bool IsModalAddToCartButtonWebElement() => ModalAddToCartButtonWebElement.Displayed;
		public bool IsModalViewProductButtonWebElement() => ModalViewProductButtonWebElement.Displayed;
		#endregion
	}
}
