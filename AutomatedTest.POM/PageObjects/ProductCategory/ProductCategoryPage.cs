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

		IWebElement TitleWebElement => Driver.FindElementWait(Title, ExpectedConditions.ElementIsVisible(Title));
		IWebElement BreadcrumbsWebElement => Driver.FindElementWait(Breadcrumbs, ExpectedConditions.ElementIsVisible(Breadcrumbs));
		//Period Pads
		IWebElement PeriodPadsIndicatorWebElement => Driver.FindElementWait(PeriodPadsIndicator, ExpectedConditions.ElementIsVisible(PeriodPadsIndicator));
		IWebElement PeriodPadsRangeSliderWebElement => Driver.FindElementWait(PeriodPadsRangeSlider, ExpectedConditions.ElementIsVisible(PeriodPadsRangeSlider));
		IList<IWebElement> PeriodPadsList => Driver.FindElementsWait(PeriodPadsProducts);
		// Maxi Towels
		IWebElement MaxiTowelsIndicatorWebElement => Driver.FindElementWait(MaxiTowelsIndicator, ExpectedConditions.ElementIsVisible(MaxiTowelsIndicator));
		IWebElement MaxiTowelsRangeSliderWewbElement => Driver.FindElementWait(MaxiTowelsRangeSlider, ExpectedConditions.ElementIsVisible(MaxiTowelsRangeSlider));
		IList<IWebElement> MaxiTowelsList => Driver.FindElementsWait(MaxiTowelProducts);
		//Panty Liners
		IWebElement PantyLinersIndicatorWebElement => Driver.FindElementWait(PantyLinersIndicator, ExpectedConditions.ElementIsVisible(PantyLinersIndicator));
		IWebElement PantyLinersRangeSliderWebElement => Driver.FindElementWait(PantyLinersRangeSlider, ExpectedConditions.ElementIsVisible(PantyLinersRangeSlider));
		IList<IWebElement> PantyLinersList => Driver.FindElementsWait(PantyLinersProducts);
		//Period Pants
		IWebElement PeriodPantsIndicatorWebElement => Driver.FindElementWait(PeriodPantsIndicator, ExpectedConditions.ElementIsVisible(PeriodPantsIndicator));
		IWebElement PeriodPantsRangeSliderWebElement => Driver.FindElementWait(PeriodPantsRangeSlider, ExpectedConditions.ElementIsVisible(PeriodPantsRangeSlider));
		IList<IWebElement> PeriodPantsList => Driver.FindElementsWait(PeriodPantsProducts);
		// Innovations
		IWebElement InovationsInfoPanelWebElement => Driver.FindElementWait(InovationsInfoPanel, ExpectedConditions.ElementIsVisible(InovationsInfoPanel));
		IWebElement InovationsSliderWebElement => Driver.FindElementWait(InovationsSlider, ExpectedConditions.ElementIsVisible(InovationsSlider));
		/// <summary>
		/// Quick Buy
		/// </summary>
		/// 
		IWebElement ProductInPcpWebElement => Driver.FindElementWait(QuickBuyProduct, ExpectedConditions.ElementIsVisible(QuickBuyProduct));
		IWebElement QuickBuyButtonWebElement => Driver.FindElementWait(QuickBuyButton, ExpectedConditions.ElementIsVisible(QuickBuyButton));
		IWebElement QuickBuyModalWebElement => Driver.FindElementWait(QuickBuyModal, ExpectedConditions.ElementIsVisible(QuickBuyModal));
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
		public ProductCategoryPage(Browser browser, string url = "") : base(browser, url)
		{

		}

		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		public bool IsTitleDisplayed() => TitleWebElement.Displayed;
		public bool IsBreadcrumbsDisplayed() => BreadcrumbsWebElement.Displayed;
		public bool IsPeriodPadsIndicatorDisplayed() => PeriodPadsIndicatorWebElement.Displayed;
		public bool IsPeriodPadsRangeSliderDisplayed() => PeriodPadsRangeSliderWebElement.Displayed;
		public bool ArePeriodPadsProductsDisplayed() => WebDriverExtensions.AreElementsDisplayed(PeriodPadsList);
		public bool IsMaxiTowelsIndicatorDisplayed() => MaxiTowelsIndicatorWebElement.Displayed;
		public bool IsMaxiTowelsRangeSliderDisplayed() => MaxiTowelsRangeSliderWewbElement.Displayed;
		public bool AreMaxiTowelProductsDisplayed() => WebDriverExtensions.AreElementsDisplayed(MaxiTowelsList);
		public bool IsPantyLinersIndicatorDisplayed() => PantyLinersIndicatorWebElement.Displayed;
		public bool IsPantyLinersRangeSliderDisplayed() => PantyLinersRangeSliderWebElement.Displayed;
		public bool ArePantyLinersProductsDisplayed() => WebDriverExtensions.AreElementsDisplayed(PantyLinersList);
		public bool IsPeriodPantsIndicatorDisplayed() => PeriodPantsIndicatorWebElement.Displayed;
		public bool IsPeriodPantsRangeSliderDisplayed() => PeriodPantsRangeSliderWebElement.Displayed;
		public bool ArePeriodPantsProductsDisplayed() => WebDriverExtensions.AreElementsDisplayed(PeriodPantsList);
		public bool IsInovationsInfoPanelDisplayed() => InovationsInfoPanelWebElement.Displayed;
		public bool IsInnovationSliderDisplayed() => InovationsSliderWebElement.Displayed;

		/// <summary>
		/// Quick Buy Modal
		/// </summary>
		/// 
		public bool IsProductInPcpDisplayed() => ProductInPcpWebElement.Displayed;
		public bool IsQuickBuyButtonDisplayed() => QuickBuyButtonWebElement.Displayed;
		public void IsProductInPcpHoveredAndClicked() => WebDriverExtensions.WaitElementForHoverAndClick(Driver, QuickBuyProduct);
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
