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
		IList<IWebElement> ListOfProducts => Driver.FindElementsWait(ProductList);		
		// Quick Buy Modal
		IWebElement QuickBuyButtonWebElement => Driver.FindElementWait(QuickBuyButton, ExpectedConditions.ElementIsVisible(QuickBuyButton));
		#endregion

		#region Constructor and methods
		public ProductLandingPage(Browser browser, string url = "") : base(browser, url)
		{
		}
		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		public bool IsIndicatorDisplayed() => IsDisplayed(Indicator);
		public bool IsTitleDisplayed() => IsDisplayed(Title);
		public bool IsBreadcrumbsDisplayed() => IsDisplayed(Breadcrumbs);
		public bool IsFilterByButtonDisplayed() => IsDisplayed(FilterByButton);
		public bool IsSortButtonDisplayed() => IsDisplayed(SortButton);
		public bool IsExploreAllProductsDisplayed() => IsDisplayed(ExploreAllProducts); // to be clickable
		public bool IsSocialIconDisplayed() => IsDisplayed(SocialLinks); // to be clickable
		public int GetIndicatorNumber() => WebDriverExtensions.GetIndicatorNumberOfProducts(IndicatorWebElement);
		public int GetNumberOfProducts() => WebDriverExtensions.GetNumberOfProducts(ListOfProducts);
		/// <summary>
		/// Quick Buy Modal
		/// </summary>
		/// 
		public bool IsProductInPcpDisplayed() => IsDisplayed(ProductInPcp);
		public bool IsQuickBuyButtonDisplayed() => IsDisplayed(QuickBuyButton);
		public void IsProductInPcpHoveredAndClicked() => WebDriverExtensions.WaitElementForHoverAndClick(Driver, ProductInPcp);
		public bool IsClicked() => WebDriverExtensions.ClickTheWebElement(QuickBuyButtonWebElement);
		public bool IsQuickBuyModalDisplayed() => IsDisplayed(QuickBuyModal);
		public bool IsModalTitleDisplayed() => IsDisplayed(ModalTitle);
		public bool IsModalOldPriceWebElement() => IsDisplayed(ModalOldPrice);
		public bool IsModalNewPriceWebElement() => IsDisplayed(ModalNewPrice);
		public bool IsModalRatingsWebElement() => IsDisplayed(ModalRatings);
		public bool IsModalSizeGuideWebElement() => IsDisplayed(ModalSizeGuide);
		public bool IsModalAddToCartCounterWebElement() => IsDisplayed(ModalAddToCartCounter);
		public bool IsModalAddToCartButtonWebElement() => IsDisplayed(ModalAddToCartButton);
		public bool IsModalViewProductButtonWebElement() => IsDisplayed(ModalViewProductButton);
		#endregion
	}
}
