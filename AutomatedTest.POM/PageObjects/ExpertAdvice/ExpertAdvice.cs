using Femcare.POM.PageObjects;
using Femcare.Selenium.Framework.Core;
using Femcare.Selenium.Framework.Extensions;
using OpenQA.Selenium;

namespace Femcare.POM.PageObjects
{
	public class ExpertAdvice : BaseMainPage
	{
		#region Selector
		public By Title => By.TagName("h1");
		public By LatestQuestionSub => By.CssSelector("div[class*='list-articles-list--ask-expert'] h2");
		public By First_TheLatestQuestion => By.CssSelector("article[class='list-article']:nth-child(1) a");
		public By Second_TheLatestQuestion => By.CssSelector("article[class='list-article']:nth-child(2) a");
		public By Third_TheLatestQuestion => By.CssSelector("rticle[class='list-article']:nth-child(3) a");
		//public By AllQuestion => By.CssSelector("article[class='list-article list-article--small']");
		public By LoadMoreButton => By.CssSelector("button[class*='list-articles-list__load-more']");

		#endregion

		#region WebElements
		IWebElement TitleWebElement => Driver.FindElementWait(Title);
		IWebElement LatestQuestionSubWebElement => Driver.FindElementWait(LatestQuestionSub);
		IWebElement First_TheLatestQuestionWebElement => Driver.FindElementWait(First_TheLatestQuestion);
		IWebElement Second_TheLatestQuestionWebElement => Driver.FindElementWait(Second_TheLatestQuestion);
		IWebElement Third_TheLatestQuestionWebElement => Driver.FindElementWait(Third_TheLatestQuestion);
		//IWebElement AllQuestionWebElemenet => Driver.FindElementWait(AllQuestion);
		IWebElement LoadMoreButtonWebElement => Driver.FindElementWait(LoadMoreButton);


		#endregion
		#region Constructor and methods
		public ExpertAdvice(Browser browser, string url = "") : base(browser, url)
		{
		}

		public override bool IsPageLoaded() => RootElement.Text.ToLowerInvariant().Contains("events");
		public bool IsTitleDisplayed() => TitleWebElement.Displayed;
		public bool IsLatestQuestionSubDisplayed() => LatestQuestionSubWebElement.Displayed;
		public bool IsFirst_TheLatestQuestionDisplayed() => First_TheLatestQuestionWebElement.Displayed;
		public bool IsSecond_TheLatestQuestionDisplayed() => Second_TheLatestQuestionWebElement.Displayed;
		public bool IsThird_TheLatestQuestionDisplayed() => Third_TheLatestQuestionWebElement.Displayed;
		public bool IsLoadMoreButtonDisplayed() => LoadMoreButtonWebElement.Displayed;

		#endregion

	}
}
