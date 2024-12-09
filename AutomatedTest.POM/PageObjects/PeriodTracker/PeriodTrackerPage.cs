using AutomatedTest.PageObjects;
using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomatedTest.POM.PageObjects
{

	public class PeriodTrackerPage : BaseMainPage
	{
		#region Selectors
		//Tracker
		public By ErrorMessage => By.CssSelector("div[class='alert-danger']");
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
		public By ResultCalendar => By.CssSelector("div[class='result-wrapper']");
		public By PeriodTrackerLegend => By.CssSelector("div[class='period-tracker-legend']");
		//Range slider
		public By RelatedProducts => By.CssSelector("div[class*='range-slider__slider']");


		#endregion

		#region Web elements
		//
		#endregion

		#region Contructor and methods

		public PeriodTrackerPage(Browser browser, string url = "") : base(browser, url)
		{

		}

		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		public bool IsTitleDisplayed() => IsDisplayed(Title);
		public bool IsPeriodTrackerContainerDisplayed() => IsDisplayed(PeriodTrackerContainer);
		public bool IsInputFieldsDisplayed() => IsDisplayedAndClickable(InputFields);
		public bool IsDateSelectorDisplayed() => IsDisplayedAndClickable(DateSelector);
		public bool IsDurationSelectorDisplayed() => IsDisplayedAndClickable(DurationSelector);
		public bool IsCycleSelectorDisplayed() => IsDisplayedAndClickable(CycleSelector);
		public bool IsTrackMyPeriodButtonDisplayed() => IsDisplayedAndClickable(TrackMyPeriodButton);
		//On Click
		public bool IsTrackMyPeriodBtnClicked() => IsClicked(TrackMyPeriodButton);
		public bool IsSubHeadingDisplayed() => IsDisplayed(SubHeading);
		public bool IsPeriodTrackerResultContainerDisplayed() => IsDisplayed(PeriodTrackerResultContainer);
		public bool IsPreviousNavButtonDisplayed() => IsDisplayedAndClickable(PreviousNavButton);
		public bool IsNextNavButtonDisplayed() => IsDisplayedAndClickable(NextNavButton);
		public bool IsResultCalendarDisplayed() => IsDisplayed(ResultCalendar);
		public bool IsPeriodTrackerLegendDisplayed() => IsDisplayed(PeriodTrackerLegend);

		#endregion
	}
}
