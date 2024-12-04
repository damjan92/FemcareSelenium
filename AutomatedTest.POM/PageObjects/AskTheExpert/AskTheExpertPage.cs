using AutomatedTest.PageObjects;
using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomatedTest.POM.PageObjects
{
	public class AskTheExpertPage : BaseMainPage
	{
		#region Selectors
		public By ErrorMessage => By.CssSelector("div[class='alert-danger']");
		public By Title => By.TagName("h1");
		public By AskTheExpertWindow => By.CssSelector("div[class='ask-expert']");
		public By AteSubHeading => By.Id("ask-expert-subtitle");
		public By ExpertHeadline => By.CssSelector("div[class='ask-expert__headline']");
		public By ExpertBody => By.CssSelector("div[class='ask-expert__body']");
		public By ExpertFormToggleButton => By.CssSelector("button[class*='ask-expert__form-toggle']");
		public By ExpertAnswersSubHeading => By.Id("listQuestionsHeading");
		public By ExpertAnswers => By.CssSelector("div[class='list-article__placeholder]");
		public By LoadMoreButton => By.CssSelector("button[class*='questions__load-more']");
		// Ask the Expert form
		public By AskTheExpertForm => By.CssSelector("div[class='ask-expert-form']");
		public By NameField => By.Id("Name");
		public By EmailField => By.Id("Email");
		public By Question => By.Id("Question");
		public By Summary => By.Id("Summary");
		public By CheckBoxesConsent => By.CssSelector("div[class*='form-group--checkbox-legal']");
		public By Recaptcha => By.CssSelector("div[class='form-recaptcha']");
		public By AteSubmitButton => By.CssSelector("div[class=\"ask-expert-form\"] button");

		#endregion

		#region Web Elements
		public IWebElement ExpertFormToggleButtonWebElement => Driver.FindElementWait(ExpertFormToggleButton, ExpectedConditions.ElementIsVisible(ExpertFormToggleButton));		
		public IList<IWebElement> ExpertAnswersWebElement => Driver.FindElementsWait(ExpertAnswers);
		public IWebElement LoadMoreButtonWebElement => Driver.FindElementWait(LoadMoreButton, ExpectedConditions.ElementToBeClickable(LoadMoreButton));
		// Ask the Expert form	
		public IList<IWebElement> CheckBoxesConsentWebElements => Driver.FindElementsWait(CheckBoxesConsent);		
		public IWebElement AteSubmitButtonWebElement => Driver.FindElementWait(AteSubmitButton, ExpectedConditions.ElementToBeClickable(AteSubmitButton));

		#endregion


		#region Constructor and methods
		public AskTheExpertPage(Browser browser, string url = "") : base(browser, url)
		{
		}

		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		public bool IsTitleDisplayed() => IsDisplayed(Title);
		public bool IsAskTheExpertWindowDisplayed() => IsDisplayed(AskTheExpertWindow);
		public bool IsAteSubHeadingDisplayed() => IsDisplayed(AteSubHeading);
		public bool IsExpertHeadlineDisplayed() => IsDisplayed(ExpertHeadline);
		public bool IsExpertBodyDisplayed() => IsDisplayed(ExpertBody);
		public bool IsExpertFormToggleButtonDisplayed() => IsDisplayed(ExpertFormToggleButton);
		public bool IsExpertAnswersSubHeadingDisplayed() => IsDisplayed(ExpertAnswersSubHeading);
		public bool IsLoadMoreButtonDisplayed() => LoadMoreButtonWebElement.Displayed;
		//Ask The Expert Form
		public bool ClickOnButton() => WebDriverExtensions.ClickTheWebElement(ExpertFormToggleButtonWebElement);
		public bool IsNameFieldDisplayed() => IsDisplayed(NameField);
		public bool IsEmailFieldDisplayed() => IsDisplayed(EmailField);
		public bool IsQuestionDisplayed() => IsDisplayed(Question);
		public bool IsSummaryDisplayed() => IsDisplayed(Summary);
		public bool IsRecaptchaDisplayed() => IsDisplayed(Recaptcha);
		public bool IsAteSubmitButtonDisplayed() => AteSubmitButtonWebElement.Displayed;

		#endregion
	}
}
