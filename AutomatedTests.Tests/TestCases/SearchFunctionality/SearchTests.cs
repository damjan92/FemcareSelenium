using AutomatedTest.POM.PageObjects;
using NUnit.Framework;
using AutomatedTests.Framework.Core;

namespace AutomatedTests.Tests.TestCases
{
	[TestFixtureSource(typeof(TestData), nameof(TestData.SearchUrls))]
	[Parallelizable]
	public class SearchTests(string websiteUrl) : BaseTest
	{
		private Search search;
		[SetUp]
		public void NavigateToHomePage()
		{
			if (search == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				search = new Search(Browser, websiteUrl);
			}
		}
		
		[Test]
		public void AreElementsInSearchBarDisplayed()
		{
			Assert.Multiple(() =>
			{
				Assert.That(search.IsSearchIconDisplayed(), "Search icon is not displayed");
				Assert.That(search.ClickOnSearchIcon(), "Search icon is not displayed/clicked");
				Assert.That(search.IsSearchBarDisplayed(), "Search bar is not displayed");
				Assert.That(search.IsResetSearchWordDisplayed(), "Reset/close search icon is not displayed");
			});
		}
		[Test]
		public void IsTextSentToSearchField()
		{
			Assert.Multiple(() =>
			{
				Assert.That(search.ClickOnSearchIcon(), "Search icon is not displayed/clicked");
				Assert.That(search.IsSearchBarDisplayed(), "Search bar is not displayed");
				Assert.That(search.IsResetSearchWordDisplayed(), "Reset/close search icon is not displayed");
				search.EnterKeys("Essity");
				Assert.That(search.IsSumOfFoundResultsDisplayed(), "Sum of found result is not displayed");
				Assert.That(search.AreSearchResultsDisplayed(), "Search result is not displayed");
				Assert.That(search.IsLoadMoreButtonDisplayed(), "Load more button is not displayed");
			});
		}


	}
}