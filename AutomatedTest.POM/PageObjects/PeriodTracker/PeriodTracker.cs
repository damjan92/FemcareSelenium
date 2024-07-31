using AutomatedTest.PageObjects;
using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomatedTest.POM.PageObjects
{

	public class PeriodTracker : BaseMainPage
	{
		#region Selectors
		//Tracker
		public override By RootSelector => By.ClassName("hero-slide");
		public By Title => By.TagName("h1");
		public By PeriodTrackerContainer => By.CssSelector("div[class='period-tracker__content']");
		public By InputFields => By.CssSelector("div[class='period-tracker__inputs']");
		public By DateSelector => By.ClassName("date-selected");
		public By DurationSelector => By.Id("duration");		
		public By CycleSelector => By.Id("cycle");
		public By TrackMyPeriodButton => By.Id("trackMyPeriod");
		//Calendar
		public By SubHeading => By.TagName("h2");
		public By PeriodTrackerResultContainer => By.CssSelector("div[class='period-tracker-results active']");
		public By PreviousNavButton => By.Id("previous");
		public By NextNavButton => By.Id("next");
		public By ResultCalendar => By.Id("period-result-calender");
		public By PeriodTrackerLegend => By.CssSelector("div[class='period-tracker-legend']");
		//Range slider
		public By RelatedProducts => By.CssSelector("div[class*='range-slider__slider']");


		#endregion

		#region Web elements
		IWebElement TitleWebElement => Driver.FindElementWait(Title, ExpectedConditions.ElementIsVisible(Title));
		IWebElement PeriodTrackerContainerWebElement => Driver.FindElementWait(PeriodTrackerContainer, ExpectedConditions.ElementIsVisible(PeriodTrackerContainer));
		IWebElement InputFieldsWebElement => Driver.FindElementWait(InputFields, ExpectedConditions.ElementIsVisible(InputFields));
		IWebElement DateSelectorWebElement => Driver.FindElementWait(DateSelector, ExpectedConditions.ElementIsVisible(DateSelector));
		IWebElement DurationSelectorWebElement => Driver.FindElementWait(DurationSelector, ExpectedConditions.ElementIsVisible(DurationSelector));
		IWebElement CycleSelectorWebElement => Driver.FindElementWait(CycleSelector, ExpectedConditions.ElementIsVisible(CycleSelector));
		IWebElement TrackMyPeriodButtonWebElement => Driver.FindElementWait(TrackMyPeriodButton, ExpectedConditions.ElementToBeClickable(TrackMyPeriodButton));
		IWebElement SubHeadingWebElement => Driver.FindElementWait(SubHeading, ExpectedConditions.ElementIsVisible(SubHeading));
		IWebElement PeriodTrackerResultContainerWebElement => Driver.FindElementWait(PeriodTrackerResultContainer, ExpectedConditions.ElementIsVisible(PeriodTrackerResultContainer));
		IWebElement PreviousNavButtonWebElement => Driver.FindElementWait(PreviousNavButton, ExpectedConditions.ElementIsVisible(PreviousNavButton));
		IWebElement NextNavButtonWebElement => Driver.FindElementWait(NextNavButton, ExpectedConditions.ElementIsVisible(NextNavButton));
		IWebElement ResultCalendarWebElement => Driver.FindElementWait(ResultCalendar, ExpectedConditions.ElementIsVisible(ResultCalendar));
		IWebElement PeriodTrackerLegendWebElement => Driver.FindElementWait(PeriodTrackerLegend, ExpectedConditions.ElementIsVisible(PeriodTrackerLegend));
		IWebElement RelatedProductsWebElement => Driver.FindElementWait(RelatedProducts, ExpectedConditions.ElementIsVisible(RelatedProducts));

		#endregion

		#region Contructor and methods

		public PeriodTracker(Browser browser, string url = "") : base(browser, url)
		{

		}

		public override bool IsPageLoaded() => RootElement.Text.ToLowerInvariant().Contains("events");
		public bool IsTitleDisplayed() => TitleWebElement.Displayed;
		public bool IsPeriodTrackerContainerDisplayed() => PeriodTrackerContainerWebElement.Displayed;
		public bool IsInputFieldsDisplayed() => InputFieldsWebElement.Displayed;
		public bool IsDateSelectorDisplayed() => DateSelectorWebElement.Displayed;
		public bool IsDurationSelectorDisplayed() => DurationSelectorWebElement.Displayed;
		public bool IsCycleSelectorDisplayed() => CycleSelectorWebElement.Displayed;
		public bool IsTrackMyPeriodButtonDisplayed() => TrackMyPeriodButtonWebElement.Displayed;
		//On Click
		public bool IsTrackMyPeriodBtnClicked() => WebDriverExtensions.ClickTheWebElement(TrackMyPeriodButtonWebElement);
		public bool IsSubHeadingDisplayed() => SubHeadingWebElement.Displayed;
		public bool IsPeriodTrackerResultContainerDisplayed() => PeriodTrackerResultContainerWebElement.Displayed;
		public bool IsPreviousNavButtonDisplayed() => PreviousNavButtonWebElement.Displayed;
		public bool IsNextNavButtonDisplayed() => NextNavButtonWebElement.Displayed;
		public bool IsResultCalendarDisplayed() => ResultCalendarWebElement.Displayed;
		public bool IsPeriodTrackerLegendDisplayed() => PeriodTrackerLegendWebElement.Displayed;
		public bool IsRelatedProductsDisplayed() => RelatedProductsWebElement.Displayed;

		#endregion
	}
}
