using AutomatedTest.PageObjects;
using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;

namespace AutomatedTest.POM.PageObjects
{
	public class ProductCategoryPage : BaseMainPage
	{

		#region Selectors
		public By Title => By.TagName("h1");
		public By Breadcrumbs => By.CssSelector("div[class='breadcrumbs']");
		//Period Pads
		public By PeriodPadsIndicator => By.CssSelector("div[class='range-slider range-slider--bg-white clearfix']:nth-child(1) span[class='range-slider-info-panel__count']");
		public By PeriodPadsRangeSlider => By.CssSelector("div[class='range-slider range-slider--bg-white clearfix']:nth-child(1)");
		public By PeriodPadsProducts => By.CssSelector("div[class='range-slider range-slider--bg-white clearfix']:nth-child(1) div[class*='swiper-slide']");
		// Maxi Towels
		public By MaxiTowelsIndicator => By.CssSelector("div[class='range-slider range-slider--bg-white clearfix']:nth-child(2) span[class='range-slider-info-panel__count']");
		public By MaxiTowelsRangeSlider => By.CssSelector("div[class='range-slider range-slider--bg-white clearfix']:nth-child(2)");
		public By MaxiTowelProducts => By.CssSelector("div[class='range-slider range-slider--bg-white clearfix']:nth-child(2) div[class*='swiper-slide");
		//Panty Liners
		public By PantyLinersIndicator => By.CssSelector("div[class='range-slider range-slider--bg-white clearfix']:nth-child(3) span[class='range-slider-info-panel__count']");
		public By PantyLinersRangeSlider => By.CssSelector("div[class='range-slider range-slider--bg-white clearfix']:nth-child(3)");
		public By PantyLinersProducts => By.CssSelector("div[class='range-slider range-slider--bg-white clearfix']:nth-child(3) div[class*='swiper-slide");
		//Period Pants
		public By PeriodPantsIndicator => By.CssSelector("div[class='range-slider range-slider--bg-white clearfix']:nth-child(4) span[class='range-slider-info-panel__count']");
		public By PeriodPantsRangeSlider => By.CssSelector("div[class='range-slider range-slider--bg-white clearfix']:nth-child(4)");
		public By PeriodPantsProducts => By.CssSelector("div[class='range-slider range-slider--bg-white clearfix']:nth-child(4) div[class*='swiper-slide");
		#endregion

		#region Webelemets

		IWebElement TitleWebElement => Driver.FindElementWait(Title);
		IWebElement BreadcrumbsWebElement => Driver.FindElementWait(Breadcrumbs);
		//Period Pads
		IWebElement PeriodPadsIndicatorWebElement => Driver.FindElementWait(PeriodPadsIndicator);
		IWebElement PeriodPadsRangeSliderWebElement => Driver.FindElementWait(PeriodPadsRangeSlider);
		// Maxi Towels
		IWebElement MaxiTowelsIndicatorWebElement => Driver.FindElementWait(MaxiTowelsIndicator);
		IWebElement MaxiTowelsRangeSliderWewbElement => Driver.FindElement(MaxiTowelsRangeSlider);
		//Panty Liners
		IWebElement PantyLinersIndicatorWebElement => Driver.FindElementWait(PantyLinersIndicator);
		IWebElement PantyLinersRangeSliderWebElement => Driver.FindElementWait(PantyLinersRangeSlider);
		//Period Pants
		IWebElement PeriodPantsIndicatorWebElement => Driver.FindElementWait(PeriodPantsIndicator);
		IWebElement PeriodPantsRangeSliderWebElement => Driver.FindElementWait(PeriodPantsRangeSlider);

		#endregion

		#region Constructor and methods
		public ProductCategoryPage(Browser browser, string url = "") : base(browser, url)
		{

		}

		public override bool IsPageLoaded() => RootElement.Text.ToLowerInvariant().Contains("events");
		public bool IsTitleDisplayed() => TitleWebElement.Displayed;
		public bool IsBreadcrumbsDisplayed() => BreadcrumbsWebElement.Displayed;
		public bool IsPeriodPadsIndicatorDisplayed() => PeriodPadsIndicatorWebElement.Displayed;
		public bool IsPeriodPadsRangeSliderDisplayed() => PeriodPadsRangeSliderWebElement.Displayed;
		public bool IsMaxiTowelsIndicatorDisplayed() => MaxiTowelsIndicatorWebElement.Displayed;
		public bool IsMaxiTowelsRangeSliderDisplayed() => MaxiTowelsRangeSliderWewbElement.Displayed;
		public bool IsPantyLinersIndicatorDisplayed() => PantyLinersIndicatorWebElement.Displayed;
		public bool IsPantyLinersRangeSliderDisplayed() => PantyLinersRangeSliderWebElement.Displayed;
		public bool IsPeriodPantsIndicatorDisplayed() => PeriodPantsIndicatorWebElement.Displayed;
		public bool IsPeriodPantsRangeSliderDisplayed() => PeriodPantsRangeSliderWebElement.Displayed;

		#endregion
	}
}
