using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;
using AutomatedTest.PageObjects;

namespace AutomatedTest.POM.PageObjects
{

	public class ContactUs : BaseMainPage
	{
		#region Selectors

		public override By RootSelector => By.ClassName("hero-slide");
		public By ContactUsForm => By.CssSelector("form[class*='custom-form']");
		public By FirstName => By.Id("Name");
		public By LastName => By.Id("Surname");
		public By PhoneNumber => By.Id("PhoneNumber");
		public By Email => By.Id("Email");
		public By SubjectSelectMenu => By.CssSelector("#Subject-button");
		public By TextAreaMessage => By.Id("Message");
		public By ValidationErrorMessage => By.CssSelector("div[class='validation-error']");
		//CheckBox
		IList<IWebElement> CheckBoxes => Driver.FindElements(By.CssSelector("div[class*='form-group--checkbox']"));
		//ReCaptcha and Send Button
		public By ReCaptcha => By.CssSelector("div[class='g-recaptcha']");
		public By SendButton => By.CssSelector("form[class*='custom-form'] button");

		#endregion

		#region Web elements

		public IWebElement ContactUsFormWebElement => Driver.FindElementWait(ContactUsForm);
		public IWebElement FirstNameWebElement => Driver.FindElementWait(FirstName);
		public IWebElement LastNameWebElement => Driver.FindElementWait(LastName);
		public IWebElement PhoneNumberWebElement => Driver.FindElementWait(PhoneNumber);
		public IWebElement EmailWebElement => Driver.FindElementWait(Email);
		public IWebElement SubjectSelectMenuWebElement => Driver.FindElementWait(SubjectSelectMenu);
		public IWebElement TextAreaMessageWebElement => Driver.FindElement(TextAreaMessage);
		public IWebElement ValidationErrorMessageWebElement => Driver.FindElementWait(ValidationErrorMessage);
		public IWebElement ReCaptchaWebElement => Driver.FindElementWait(ReCaptcha);
		public IWebElement SendButtonWebElement => Driver.FindElementWait(SendButton);

		#endregion

		#region Contructor and methods

		public ContactUs(Browser browser, string url = "") : base(browser, url)
		{

		}

		public override bool IsPageLoaded() => RootElement.Text.ToLowerInvariant().Contains("events");
		public bool IsContactUsFormLoaded() => ContactUsFormWebElement.Displayed;
		public bool IsFirstNameDisplayed() => FirstNameWebElement.Displayed;
		public bool IsLastNameDisplayed() => LastNameWebElement.Displayed;
		public bool IsPhoneNumberDisplayed() => PhoneNumberWebElement.Displayed;
		public bool IsEmailDisplayed() => EmailWebElement.Displayed;
		public bool IsSubjectSelectMenuDisplayed() => SubjectSelectMenuWebElement.Displayed;
		public bool IsTextAreaMessageDisplayed() => TextAreaMessageWebElement.Displayed;
		public bool IsValidationErrorMessageDisplayed() => ValidationErrorMessageWebElement.Displayed;
		public bool IsRecaptchaDisplayed() => ReCaptchaWebElement.Displayed;
		public bool IsSendButtonDisplayed() => SendButtonWebElement.Displayed;
		#endregion
	}
}
