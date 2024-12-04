using AutomatedTest.PageObjects;
using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomatedTest.POM.PageObjects
{
	public class ProductCategoryPage : BaseMainPage
	{

		#region Selectors
		public By ErrorMessage => By.CssSelector("div[class='alert-danger']");
		public By Title => By.TagName("h1");
		public By Breadcrumbs => By.CssSelector("ol[class='breadcrumbs__list']");
		//Period Pads
		public By PeriodPadsIndicator => By.CssSelector("div[class*='range-slider ']:nth-child(1) span[class='range-slider-info-panel__count']");
		public By PeriodPadsRangeSlider => By.CssSelector("div[class*='range-slider ']:nth-child(1)");
		public By PeriodPadsProducts => By.CssSelector("div[class*='range-slider ']:nth-child(1) div[class*='swiper-slide']");
		// Maxi Towels
		public By MaxiTowelsIndicator => By.CssSelector("div[class*='range-slider ']:nth-child(2) span[class='range-slider-info-panel__count']");
		public By MaxiTowelsRangeSlider => By.CssSelector("div[class*='range-slider ']:nth-child(2)");
		public By MaxiTowelProducts => By.CssSelector("div[class*='range-slider ']:nth-child(2) div[class*='swiper-slide");
		//Panty Liners
		public By PantyLinersIndicator => By.CssSelector("div[class*='range-slider ']:nth-child(3) span[class='range-slider-info-panel__count']");
		public By PantyLinersRangeSlider => By.CssSelector("div[class*='range-slider ']:nth-child(3)");
		public By PantyLinersProducts => By.CssSelector("div[class*='range-slider ']:nth-child(3) div[class*='swiper-slide");
		//Period Pants
		public By PeriodPantsIndicator => By.CssSelector("div[class*='range-slider ']:nth-child(4) span[class='range-slider-info-panel__count']");
		public By PeriodPantsRangeSlider => By.CssSelector("div[class*='range-slider ']:nth-child(4)");
		public By PeriodPantsProducts => By.CssSelector("div[class*='range-slider ']:nth-child(4) div[class*='swiper-slide");
		// Inovations
		public By InovationsInfoPanel => By.CssSelector("div[class='innovations-info-panel']");
		public By InovationsSlider => By.CssSelector("div[class*='innovations-slider']");

		/// <summary>
		/// Quick buy
		/// </summary>
		/// 
		public By QuickBuyProduct => By.CssSelector
			("div[class='range-slider range-slider--bg-white clearfix']:nth-child(1) div[class*='swiper-slide-active'] div[class='cta-panel__image']");
		public By QuickBuyButton => By.CssSelector("div[class='btn btn-primary cta-panel__quick-buy-button']");
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

		#region Webelemets
		
		//Period Pads		
		IList<IWebElement> PeriodPadsList => Driver.FindElementsWait(PeriodPadsProducts);
		// Maxi Towels		
		IList<IWebElement> MaxiTowelsList => Driver.FindElementsWait(MaxiTowelProducts);
		//Panty Liners		
		IList<IWebElement> PantyLinersList => Driver.FindElementsWait(PantyLinersProducts);
		//Period Pants		
		IList<IWebElement> PeriodPantsList => Driver.FindElementsWait(PeriodPantsProducts);				
		// Quick Buy
		IWebElement QuickBuyButtonWebElement => Driver.FindElementWait(QuickBuyButton, ExpectedConditions.ElementIsVisible(QuickBuyButton));		
		#endregion

		#region Constructor and methods
		public ProductCategoryPage(Browser browser, string url = "") : base(browser, url)
		{

		}

		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		public bool IsTitleDisplayed() => IsDisplayed(Title);
		public bool IsBreadcrumbsDisplayed() => IsDisplayed(Breadcrumbs);
		public bool IsPeriodPadsIndicatorDisplayed() => IsDisplayed(PeriodPadsIndicator);
		public bool IsPeriodPadsRangeSliderDisplayed() => IsDisplayed(PeriodPadsRangeSlider);
		public bool ArePeriodPadsProductsDisplayed() => WebDriverExtensions.AreElementsDisplayed(PeriodPadsList);
		public bool IsMaxiTowelsIndicatorDisplayed() => IsDisplayed(MaxiTowelsIndicator);
		public bool IsMaxiTowelsRangeSliderDisplayed() => IsDisplayed(MaxiTowelsRangeSlider);
		public bool AreMaxiTowelProductsDisplayed() => WebDriverExtensions.AreElementsDisplayed(MaxiTowelsList);
		public bool IsPantyLinersIndicatorDisplayed() => IsDisplayed(PantyLinersIndicator);
		public bool IsPantyLinersRangeSliderDisplayed() => IsDisplayed(PantyLinersRangeSlider);
		public bool ArePantyLinersProductsDisplayed() => WebDriverExtensions.AreElementsDisplayed(PantyLinersList);
		public bool IsPeriodPantsIndicatorDisplayed() => IsDisplayed(PeriodPantsIndicator);
		public bool IsPeriodPantsRangeSliderDisplayed() => IsDisplayed(PeriodPantsRangeSlider);
		public bool ArePeriodPantsProductsDisplayed() => WebDriverExtensions.AreElementsDisplayed(PeriodPantsList);
		public bool IsInovationsInfoPanelDisplayed() => IsDisplayed(InovationsInfoPanel);
		public bool IsInnovationSliderDisplayed() => IsDisplayed(InovationsSlider);

		/// <summary>
		/// Quick Buy Modal
		/// </summary>
		/// 
		public bool IsProductInPcpDisplayed() => IsDisplayed(QuickBuyProduct);
		public bool IsQuickBuyButtonDisplayed() => IsDisplayed(QuickBuyButton);
		public void IsProductInPcpHoveredAndClicked() => WebDriverExtensions.WaitElementForHoverAndClick(Driver, QuickBuyProduct);
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
