using AutomatedTest.POM.PageObjects;
using AutomatedTests.Framework.Core;
using NUnit.Framework;

namespace AutomatedTests.Tests.TestCases
{
	[Category("Period Tracker")]
	[TestFixtureSource(typeof(TestData), nameof(TestData.PeriodTrackerUrls))]
	[Parallelizable]
	public class PeriodTrackerTests(string websiteUrl) : BaseTest
	{
		private PeriodTrackerPage periodTracker;

		[SetUp]
		public void NavigateToHomePage()
		{
			if (periodTracker == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				periodTracker = new PeriodTrackerPage(Browser, websiteUrl);
			}
		}
		[Test]
		[Category("ErrorAlert - Period Tracker")]
		public void ErrorMessage() => Assert.That(periodTracker.IsErrorMessageDisplayed(), Is.False, "Erros message is loaded!");

		[Test]
		public void Test_13_IsTitleDisplayed() => Assert.That(periodTracker.IsTitleDisplayed(), "Title is not displayed");
		[Test]
		public void Test_14_IsPeriodTrackerContainerDisplayed() => Assert.That(periodTracker.IsPeriodTrackerContainerDisplayed(), "Period Tracker Container is not displayed");
		[Test]
		public void ArePeriodTrackerFieldsDisplayed()
		{
			Assert.Multiple(() =>
			{
				Assert.That(periodTracker.IsInputFieldsDisplayed(), "Input Field is not displayed");
				Assert.That(periodTracker.IsDateSelectorDisplayed(), "Date selector is not displayed");
				Assert.That(periodTracker.IsDurationSelectorDisplayed(), "Duration selector is not displayed");
				Assert.That(periodTracker.IsCycleSelectorDisplayed(), "Cycle selector is not displayed");
			});
		}		
		[Test]
		public void Test_20_IsTrackMyPeriodButtonDisplayed() => Assert.That(periodTracker.IsTrackMyPeriodButtonDisplayed(), "Period Button is not displayed");
		[Test]
		public void IsCalendarVisibleAfterSubmit()
		{
			Assert.Multiple(() =>
			{
				//periodTracker.IsTrackMyPeriodBtnClicked();
				Assert.That(periodTracker.IsTrackMyPeriodBtnClicked(), "Track my Period Button is not found/clicked");				
				Assert.That(periodTracker.IsSubHeadingDisplayed(), "Subheading is not displayed");
				Assert.That(periodTracker.IsPeriodTrackerResultContainerDisplayed(), "Result container is not displayed");
				Assert.That(periodTracker.IsPreviousNavButtonDisplayed(), "Previos button is not displayed");
				Assert.That(periodTracker.IsNextNavButtonDisplayed(), "Next button is not displayed");
				Assert.That(periodTracker.IsResultCalendarDisplayed(), "Calendar is not displayed");
				Assert.That(periodTracker.IsPeriodTrackerLegendDisplayed(), "Legend is not displayed");
			});
		}		
	}
}