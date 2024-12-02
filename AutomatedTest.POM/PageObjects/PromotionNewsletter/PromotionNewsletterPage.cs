using AutomatedTest.PageObjects;
using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomatedTest.POM.PageObjects
{
	public class PromotionNewsletterPage : BaseMainPage
	{

		#region Selectors
		public By ErrorMessage => By.CssSelector("div[class='alert-danger']");
		public By PromotionForm => By.CssSelector("form[class*=\"custom-header-form\"]");
		public By FirstName => By.Id("FirstName");
		public By AgeField => By.Id("Age_day");
		public By MonthField => By.Id("Age_month-button");
		public By YearField => By.Id("Age_year");
		public By Email => By.Id("Email");
		public By Recaptcha => By.CssSelector("form[action='/break-taboos/take-action/subscribe-newsletter/'] div[class='g-recaptcha']");
		public By SubmitButton => By.CssSelector("form[action='/break-taboos/take-action/subscribe-newsletter/'] button[type=\"submit\"]");
		// Newsletter Subscription
		public By NewsletterForm => By.Id("newsletter-subscription");
		public By NewsletterName => By.Id("newsletter-name");
		public By NewsletterEmail => By.Id("email");
		public By NewsletterRecaptcha => By.CssSelector("div[class='form-recaptcha']");
		public By NewsletterButton => By.CssSelector("#newsletter-subscription button");

		#endregion

		#region WebElements
		IWebElement PromotionFormWebElement => Driver.FindElementWait(PromotionForm, ExpectedConditions.ElementExists(PromotionForm), 3);
		IWebElement FirstNameWebElement => Driver.FindElementWait(FirstName, ExpectedConditions.ElementToBeClickable(FirstName));
		IWebElement AgeFieldWebElement => Driver.FindElementWait(AgeField, ExpectedConditions.ElementIsVisible(AgeField));
		IWebElement MonthFieldWebElement => Driver.FindElementWait(MonthField, ExpectedConditions.ElementIsVisible(MonthField));
		IWebElement YearFieldWebElement => Driver.FindElementWait(YearField, ExpectedConditions.ElementToBeClickable(YearField));
		IWebElement EmailWebElement => Driver.FindElementWait(Email, ExpectedConditions.ElementToBeClickable(Email));
		IWebElement RecaptchaWebElement => Driver.FindElementWait(Recaptcha, ExpectedConditions.ElementToBeClickable(Recaptcha));
		IWebElement SubmitButtonWebElement => Driver.FindElementWait(SubmitButton, ExpectedConditions.ElementToBeClickable(SubmitButton));
		// Newsletter Subscription
		IWebElement NewsletterFormWebElement => Driver.FindElementWait(NewsletterForm, ExpectedConditions.ElementExists(NewsletterForm));
		IWebElement NewsletterNameWebElement => Driver.FindElementWait(NewsletterName, ExpectedConditions.ElementToBeClickable(NewsletterName));
		IWebElement NewsletterEmailWebElement => Driver.FindElementWait(NewsletterEmail, ExpectedConditions.ElementToBeClickable(NewsletterEmail));
		IWebElement NewsletterRecaptchaWebElement => Driver.FindElementWait(NewsletterRecaptcha, ExpectedConditions.ElementToBeClickable(NewsletterRecaptcha));
		IWebElement NewsletterButtonWebElement => Driver.FindElementWait(NewsletterButton, ExpectedConditions.ElementIsVisible(NewsletterButton));
		#endregion

		#region Constructor and methods
		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		public bool IsPromotionFormDisplayed() => PromotionFormWebElement.Displayed;
		public bool IsFirstNameDisplayed() => FirstNameWebElement.Displayed;
		public bool IsAgeFieldDisplayed() => AgeFieldWebElement.Displayed;
		public bool IsMonthFieldDisplayed() => MonthFieldWebElement.Displayed;
		public bool IsYearFieldDisplayed() => YearFieldWebElement.Displayed;
		public bool IsEmailDisplayed() => EmailWebElement.Displayed;
		public bool RecaptchaDisplayed() => RecaptchaWebElement.Displayed;
		public bool IsSubmitButtonDisplayed() => SubmitButtonWebElement.Displayed;
		// Newsletter Subscription
		public bool IsNewsletterFormDisplayed() => NewsletterFormWebElement.Displayed;
		public bool IsNewsletterNameDisplayed() => NewsletterNameWebElement.Displayed;
		public bool IsNewsletterEmailDisplayed() => NewsletterEmailWebElement.Displayed;
		public bool IsNewsletterRecaptchaDisplayed() => NewsletterRecaptchaWebElement.Displayed;
		public bool IsNewsletterButtonDisplayed() => NewsletterButtonWebElement.Displayed;

		public PromotionNewsletterPage(Browser browser, string url = "") : base(browser, url)
		{
		}
		#endregion

	}
}