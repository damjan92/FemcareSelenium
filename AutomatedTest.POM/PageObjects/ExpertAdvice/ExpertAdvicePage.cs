using AutomatedTest.PageObjects;
using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomatedTest.POM.PageObjects
{
	public class ExpertAdvicePage : BaseMainPage
	{
		#region Selector
		public By ErrorMessage => By.CssSelector("div[class='alert-danger']");
		public By Title => By.TagName("h1");
		public By LatestQuestionSub => By.Id("latestQuestionsHeading");
		public By BrowseLatestQuestion => By.Id("listQuestionsHeading");		
		public By AllQuestion => By.CssSelector("a[class='question__link']");
		public By LoadMoreButton => By.CssSelector("button[class*='questions__load-more']");

		#endregion

		#region WebElements
		IWebElement TitleWebElement => Driver.FindElementWait(Title, ExpectedConditions.ElementIsVisible(Title));
		IWebElement LatestQuestionSubWebElement => Driver.FindElementWait(LatestQuestionSub, ExpectedConditions.ElementIsVisible(LatestQuestionSub));
		IWebElement BrowseLatestQuestionWebElement => Driver.FindElementWait(BrowseLatestQuestion, ExpectedConditions.ElementIsVisible(BrowseLatestQuestion));		
		IList<IWebElement> AllQuestionWebElemenet => Driver.FindElementsWait(AllQuestion);
		IWebElement LoadMoreButtonWebElement => Driver.FindElementWait(LoadMoreButton, ExpectedConditions.ElementToBeClickable(LoadMoreButton));


		#endregion

		#region Constructor and methods
		public ExpertAdvicePage(Browser browser, string url = "") : base(browser, url)
		{
		}

		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		public bool IsTitleDisplayed() => TitleWebElement.Displayed;
		public bool IsLatestQuestionSubDisplayed() => LatestQuestionSubWebElement.Displayed;
		public bool IsBrowseLatestQuestionWebElement() => BrowseLatestQuestionWebElement.Displayed;
		public bool IsLoadMoreButtonDisplayed() => LoadMoreButtonWebElement.Displayed;
		public bool AreAllQuestionDisplayed() => WebDriverExtensions.AreElementsDisplayed(AllQuestionWebElemenet);
		public int NumberOfResult() => AllQuestionWebElemenet.Count;
		public bool ClickOnLoadMoreQuestion() => WebDriverExtensions.ClickTheWebElement(LoadMoreButtonWebElement);

		#endregion

	}
}
