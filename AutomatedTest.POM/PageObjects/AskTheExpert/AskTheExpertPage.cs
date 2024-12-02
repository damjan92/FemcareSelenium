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
		public IWebElement TitleWebElement => Driver.FindElementWait(Title, ExpectedConditions.ElementIsVisible(Title));
		public IWebElement AskTheExpertWindowWebElement => Driver.FindElementWait(AskTheExpertWindow, ExpectedConditions.ElementIsVisible(AskTheExpertWindow));
		public IWebElement AteSubHeadingWebElement => Driver.FindElementWait(AteSubHeading, ExpectedConditions.ElementIsVisible(AteSubHeading));
		public IWebElement ExpertHeadlineWebElement => Driver.FindElementWait(ExpertHeadline, ExpectedConditions.ElementIsVisible(ExpertHeadline));
		public IWebElement ExpertBodyWebElemenet => Driver.FindElementWait(ExpertBody, ExpectedConditions.ElementIsVisible(ExpertBody));
		public IWebElement ExpertFormToggleButtonWebElement => Driver.FindElementWait(ExpertFormToggleButton, ExpectedConditions.ElementIsVisible(ExpertFormToggleButton));
		public IWebElement ExpertAnswersSubHeadingWebElement => Driver.FindElementWait(ExpertAnswersSubHeading, ExpectedConditions.ElementIsVisible(ExpertAnswersSubHeading));
		public IList<IWebElement> ExpertAnswersWebElement => Driver.FindElementsWait(ExpertAnswers);
		public IWebElement LoadMoreButtonWebElement => Driver.FindElementWait(LoadMoreButton, ExpectedConditions.ElementToBeClickable(LoadMoreButton));
		// Ask the Expert form
		public IWebElement AskTheExpertFormWebElement => Driver.FindElementWait(AskTheExpertForm, ExpectedConditions.ElementIsVisible(AskTheExpertForm));
		public IWebElement NameFieldWebElement => Driver.FindElementWait(NameField, ExpectedConditions.ElementIsVisible(NameField));
		public IWebElement EmailFieldWebElement => Driver.FindElementWait(EmailField, ExpectedConditions.ElementIsVisible(EmailField));
		public IWebElement QuestionWebElement => Driver.FindElementWait(Question, ExpectedConditions.ElementIsVisible(Question));
		public IWebElement SummaryWebElement => Driver.FindElementWait(Summary, ExpectedConditions.ElementIsVisible(Summary));
		public IList<IWebElement> CheckBoxesConsentWebElements => Driver.FindElementsWait(CheckBoxesConsent);
		public IWebElement RecaptchaWebElement => Driver.FindElementWait(Recaptcha, ExpectedConditions.ElementIsVisible(Recaptcha));
		public IWebElement AteSubmitButtonWebElement => Driver.FindElementWait(AteSubmitButton, ExpectedConditions.ElementToBeClickable(AteSubmitButton));

		#endregion


		#region Constructor and methods
		public AskTheExpertPage(Browser browser, string url = "") : base(browser, url)
		{
		}

		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		public bool IsTitleDisplayed() => TitleWebElement.Displayed;
		public bool IsAskTheExpertWindowDisplayed() => AskTheExpertWindowWebElement.Displayed;
		public bool IsAteSubHeadingDisplayed() => AteSubHeadingWebElement.Displayed;
		public bool IsExpertHeadlineDisplayed() => ExpertHeadlineWebElement.Displayed;
		public bool IsExpertBodyDisplayed() => ExpertBodyWebElemenet.Displayed;
		public bool IsExpertFormToggleButtonDisplayed() => ExpertFormToggleButtonWebElement.Displayed;
		public bool IsExpertAnswersSubHeadingDisplayed() => ExpertAnswersSubHeadingWebElement.Displayed;
		//public bool IsExpertAnswersDisplayed() => ExpertAnswersWebElement.Displayed;
		public bool IsLoadMoreButtonDisplayed() => LoadMoreButtonWebElement.Displayed;
		//Ask The Expert Form
		public bool ClickOnButton() => WebDriverExtensions.ClickTheWebElement(ExpertFormToggleButtonWebElement);
		public bool IsNameFieldDisplayed() => NameFieldWebElement.Displayed;
		public bool IsEmailFieldDisplayed() => EmailFieldWebElement.Displayed;
		public bool IsQuestionDisplayed() => QuestionWebElement.Displayed;
		public bool IsSummaryDisplayed() => SummaryWebElement.Displayed;
		public bool IsRecaptchaDisplayed() => RecaptchaWebElement.Displayed;
		public bool IsAteSubmitButtonDisplayed() => AteSubmitButtonWebElement.Displayed;

		#endregion
	}
}
