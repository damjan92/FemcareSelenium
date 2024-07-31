using AutomatedTest.PageObjects;
using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomatedTest.POM.PageObjects
{
	public class Search : BaseMainPage
	{
		#region Selectors
		public By SearchIcon => By.CssSelector("div[class*='navigation-bar__icon--search']");
		//public By SearchIcon => By.CssSelector("i[class='icon-search']");
		public By SearchBar => By.Id("searchModalInput");
		// On click action
		public By ResetSearchWord => By.CssSelector("button[class*='search-modal__close']");
		public By SearchedWordBar => By.CssSelector("div[class='search-bar__field']");
		public By SumOfFoundResults => By.CssSelector("div[class='search-results__heading']");
		public By SearchResults => By.CssSelector("div[class*='cta-panel__article']");
		public By LoadMoreButton => By.CssSelector("button[class*=\"search-results__load-more\"]");

		#endregion

		#region WebElements
		IWebElement SearchIconWebElement => Driver.FindElementWait(SearchIcon, ExpectedConditions.ElementExists(SearchIcon), 7);
		IWebElement SearchBarWebElement => Driver.FindElementWait(SearchBar, ExpectedConditions.ElementIsVisible(SearchBar), 3);
		// On click action
		IWebElement ResetSearchWordWebElement => Driver.FindElementWait(ResetSearchWord, ExpectedConditions.ElementToBeClickable(ResetSearchWord), 3);
		IWebElement SearchedWordBarWebElement => Driver.FindElementWait(SearchedWordBar, ExpectedConditions.ElementToBeClickable(SearchedWordBar), 3);
		IWebElement SumOfFoundResultsWebElement => Driver.FindElementWait(SumOfFoundResults, ExpectedConditions.ElementIsVisible(SumOfFoundResults), 3);
		IList<IWebElement> SearchResultsList => Driver.FindElementsWait(SearchResults, 5);
		IWebElement LoadMoreButtonWebElement => Driver.FindElementWait(LoadMoreButton, ExpectedConditions.ElementToBeClickable(LoadMoreButton), 3);


		#endregion

		#region Constructods and methods
		public Search(Browser browser, string url = "") : base(browser, url)
		{
		}
		public bool IsSearchIconDisplayed() => SearchIconWebElement.Displayed;
		public bool IsSearchBarDisplayed() => SearchBarWebElement.Displayed;
		public bool ClickOnSearchIcon() => WebDriverExtensions.ClickTheWebElement(SearchIconWebElement);
		public void EnterKeys(string data) => WebDriverExtensions.WaitForElementToSendKeys(Driver, SearchBar, data, 5);
		public bool IsResetSearchWordDisplayed() => ResetSearchWordWebElement.Displayed;
		public bool IsSumOfFoundResultsDisplayed() => SumOfFoundResultsWebElement.Displayed;
		public bool AreSearchResultsDisplayed() => WebDriverExtensions.AreElementsDisplayed(SearchResultsList);
		public int GetNumberOfResult() => SearchResultsList.Count;
		public bool IsLoadMoreButtonDisplayed() => LoadMoreButtonWebElement.Displayed;
		public string GetText() => SearchBarWebElement.Text;


		#endregion
	}
}