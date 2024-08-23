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
		public By Title => By.TagName("h1");
		public By LatestQuestionSub => By.CssSelector("div[class*='list-articles-list--ask-expert'] h2");
		public By First_TheLatestQuestion => By.CssSelector("article[class='list-article']:nth-child(1) a");
		public By Second_TheLatestQuestion => By.CssSelector("article[class='list-article']:nth-child(2) a");
		public By Third_TheLatestQuestion => By.CssSelector("rticle[class='list-article']:nth-child(3) a");
		public By AllQuestion => By.CssSelector("article[class='list-article list-article--small']");
		public By LoadMoreButton => By.CssSelector("button[class*='list-articles-list__load-more']");

		#endregion

		#region WebElements
		IWebElement TitleWebElement => Driver.FindElementWait(Title, ExpectedConditions.ElementIsVisible(Title));
		IWebElement LatestQuestionSubWebElement => Driver.FindElementWait(LatestQuestionSub, ExpectedConditions.ElementIsVisible(LatestQuestionSub));
		IWebElement First_TheLatestQuestionWebElement => Driver.FindElementWait(First_TheLatestQuestion, ExpectedConditions.ElementIsVisible(First_TheLatestQuestion));
		IWebElement Second_TheLatestQuestionWebElement => Driver.FindElementWait(Second_TheLatestQuestion, ExpectedConditions.ElementIsVisible(Second_TheLatestQuestion));
		IWebElement Third_TheLatestQuestionWebElement => Driver.FindElementWait(Third_TheLatestQuestion, ExpectedConditions.ElementIsVisible(Third_TheLatestQuestion));
		IList<IWebElement> AllQuestionWebElemenet => Driver.FindElementsWait(AllQuestion);
		IWebElement LoadMoreButtonWebElement => Driver.FindElementWait(LoadMoreButton, ExpectedConditions.ElementToBeClickable(LoadMoreButton));


		#endregion

		#region Constructor and methods
		public ExpertAdvicePage(Browser browser, string url = "") : base(browser, url)
		{
		}

		public override bool IsPageLoaded() => RootElement.Text.ToLowerInvariant().Contains("events");
		public bool IsTitleDisplayed() => TitleWebElement.Displayed;
		public bool IsLatestQuestionSubDisplayed() => LatestQuestionSubWebElement.Displayed;
		public bool IsFirst_TheLatestQuestionDisplayed() => First_TheLatestQuestionWebElement.Displayed;
		public bool IsSecond_TheLatestQuestionDisplayed() => Second_TheLatestQuestionWebElement.Displayed;
		public bool IsThird_TheLatestQuestionDisplayed() => Third_TheLatestQuestionWebElement.Displayed;
		public bool IsLoadMoreButtonDisplayed() => LoadMoreButtonWebElement.Displayed;
		public bool AreAllQuestionDisplayed() => WebDriverExtensions.AreElementsDisplayed(AllQuestionWebElemenet);

		#endregion

	}
}
