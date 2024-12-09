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
		public By NewsletterBirthday => By.Id("Birthday_day");
		public By NewsletterMonth => By.Id("Birthday_month");
		public By NewsletterYear => By.Id("Birthday_year");
		public By NewsletterRecaptcha => By.CssSelector("div[class='form-recaptcha']");
		public By NewsletterButton => By.CssSelector("#newsletter-subscription button");

		#endregion

		#region WebElements
		//
		#endregion

		#region Constructor and methods
		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		public bool IsPromotionFormDisplayed() => IsDisplayed(PromotionForm);
		public bool IsFirstNameDisplayed() => IsDisplayedAndClickable(FirstName);
		public bool IsAgeFieldDisplayed() => IsDisplayedAndClickable(AgeField);
		public bool IsMonthFieldDisplayed() => IsDisplayedAndClickable(MonthField);
		public bool IsYearFieldDisplayed() => IsDisplayedAndClickable(YearField);
		public bool IsEmailDisplayed() => IsDisplayedAndClickable(Email);
		public bool RecaptchaDisplayed() => IsDisplayedAndClickable(Recaptcha);	
		public bool IsSubmitButtonDisplayed() => IsDisplayed(SubmitButton);
		// Newsletter Subscription
		public bool IsNewsletterNameDisplayed() => IsDisplayedAndClickable(NewsletterName);
		public bool IsNewsletterDayDisplayed() => IsDisplayedAndClickable(NewsletterBirthday);
		public bool IsNewsletterMonthDisplayed() => IsDisplayedAndClickable(NewsletterMonth);
		public bool IsNewsletterYearDisplayed() => IsDisplayedAndClickable(NewsletterYear);
		public bool IsNewsletterFormDisplayed() => IsDisplayedAndClickable(NewsletterForm);
		public bool IsNewsletterEmailDisplayed() => IsDisplayedAndClickable(NewsletterEmail);
		public bool IsNewsletterRecaptchaDisplayed() => IsDisplayed(NewsletterRecaptcha);
		public bool IsNewsletterButtonDisplayed() => IsDisplayed(NewsletterButton);

		public PromotionNewsletterPage(Browser browser, string url = "") : base(browser, url)
		{
		}
		#endregion

	}
}