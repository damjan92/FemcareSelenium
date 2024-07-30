using AutomatedTest.PageObjects;
using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomatedTest.POM.PageObjects
{
	public class PromotionNewsletter : BaseMainPage
	{

		#region Selectors
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
		public By NewsletterRecaptcha => By.CssSelector("#newsletter-subscription div[class*=\"g-recaptcha\"]");
		public By NewsletterButton => By.CssSelector("#newsletter-subscription button");

		#endregion

		#region WebElements
		IWebElement PromotionFormWebElement => Driver.FindElementWait(PromotionForm, ExpectedConditions.ElementExists(PromotionForm), 3);
		IWebElement FirstNameWebElement => Driver.FindElementWait(FirstName, ExpectedConditions.ElementToBeClickable(FirstName), 3);
		IWebElement AgeFieldWebElement => Driver.FindElementWait(AgeField, ExpectedConditions.ElementIsVisible(AgeField), 5);
		IWebElement MonthFieldWebElement => Driver.FindElementWait(MonthField, ExpectedConditions.ElementIsVisible(MonthField), 5);
		IWebElement YearFieldWebElement => Driver.FindElementWait(YearField, ExpectedConditions.ElementToBeClickable(YearField), 5);
		IWebElement EmailWebElement => Driver.FindElementWait(Email, ExpectedConditions.ElementToBeClickable(Email), 3);
		IWebElement RecaptchaWebElement => Driver.FindElementWait(Recaptcha, ExpectedConditions.ElementToBeClickable(Recaptcha), 3);
		IWebElement SubmitButtonWebElement => Driver.FindElementWait(SubmitButton, ExpectedConditions.ElementToBeClickable(SubmitButton), 3);
		// Newsletter Subscription
		IWebElement NewsletterFormWebElement => Driver.FindElementWait(NewsletterForm, ExpectedConditions.ElementExists(NewsletterForm), 5);
		IWebElement NewsletterNameWebElement => Driver.FindElementWait(NewsletterName, ExpectedConditions.ElementToBeClickable(NewsletterName), 5);
		IWebElement NewsletterEmailWebElement => Driver.FindElementWait(NewsletterEmail, ExpectedConditions.ElementToBeClickable(NewsletterEmail), 5);
		IWebElement NewsletterRecaptchaWebElement => Driver.FindElementWait(NewsletterRecaptcha, ExpectedConditions.ElementToBeClickable(NewsletterRecaptcha), 5);
		IWebElement NewsletterButtonWebElement => Driver.FindElementWait(NewsletterButton, ExpectedConditions.ElementIsVisible(NewsletterButton), 5);
		#endregion

		#region Constructor and methods
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

		public PromotionNewsletter(Browser browser, string url = "") : base(browser, url)
		{
		}
		#endregion

	}
}