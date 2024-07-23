using AutomatedTest.POM.PageObjects;
using AutomatedTests.Framework.Core;
using NUnit.Framework;

namespace AutomatedTests.Tests.TestCases
{
	[TestFixtureSource(typeof(TestData), nameof(TestData.PeriodTrackerUrls))]
	[Parallelizable]
	public class PeriodTrackerTests(string websiteUrl) : BaseTest
	{
		private PeriodTracker periodTracker;

		[SetUp]
		public void NavigateToHomePage()
		{
			if (periodTracker == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				periodTracker = new PeriodTracker(Browser, websiteUrl);
			}
		}

		[Test]
		public void Test_13_IsTitleDisplayed() => Assert.That(periodTracker.IsTitleDisplayed(), "Title is not displayed");
		[Test]
		public void Test_14_IsPeriodTrackerContainerDisplayed() => Assert.That(periodTracker.IsPeriodTrackerContainerDisplayed(), "Period Tracker Container is not displayed");
		[Test]
		public void Test_15_IsInputFieldsDisplayed() => Assert.That(periodTracker.IsInputFieldsDisplayed(), "Input Field is not displayed");
		[Test]
		public void Test_16_IsDateSelectorDisplayed() => Assert.That(periodTracker.IsDateSelectorDisplayed(), "Date selector is not displayed");
		[Test]
		public void Test_17_IsDateSelectorDisplayed() => Assert.That(periodTracker.IsDateSelectorDisplayed(), "Date selector is not displayed");
		[Test]
		public void Test_18_IsDurationSelectorDisplayed() => Assert.That(periodTracker.IsDurationSelectorDisplayed(), "Duration selector is not displayed");
		[Test]
		public void Test_19_IsCycleSelectorDisplayed() => Assert.That(periodTracker.IsCycleSelectorDisplayed(), "Cycle selector is not displayed");
		[Test]
		public void Test_20_IsTrackMyPeriodButtonDisplayed() => Assert.That(periodTracker.IsTrackMyPeriodButtonDisplayed(), "Period Button is not displayed");

		/*Need Action for Click on Period Tracker button
		 * [Test]
		public void Test_21_IsSubHeadingDisplayed()
		{
			Assert.That(periodTracker.IsSubHeadingDisplayed(), "Subheading is not displayed");
		}
		[Test]
		public void Test_22_IsPeriodTrackerResultContainerDisplayed()
		{
			Assert.That(periodTracker.IsPeriodTrackerResultContainerDisplayed(), "Result container is not displayed");
		}
		[Test]
		public void Test_23_IsPreviousNavButtonDisplayed()
		{
			Assert.That(periodTracker.IsPreviousNavButtonDisplayed(), "Previos button is not displayed");
		}
		[Test]
		public void Test_24_IsNextNavButtonDisplayed()
		{
			Assert.That(periodTracker.IsNextNavButtonDisplayed(), "Next button is not displayed");
		}
		[Test]
		public void Test_25_IsResultCalendarDisplayed()
		{
			Assert.That(periodTracker.IsResultCalendarDisplayed(), "Calendar is not displayed");
		}
		[Test]
		public void Test_26_IsPeriodTrackerLegendDisplayed()
		{
			Assert.That(periodTracker.IsPeriodTrackerLegendDisplayed(), "Legend is not displayed");
		}*/


	}
}