using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;
using AutomatedTest.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace AutomatedTest.POM.PageObjects
{

	public class ContactUsPage : BaseMainPage
	{
		#region Selectors

		public override By RootSelector => By.ClassName("hero-slide");
		public By ErrorMessage => By.CssSelector("div[class='alert-danger']");
		public By ContactUsForm => By.CssSelector("form[class*='custom-form']");
		public By Name => By.Id("Name");
		public By LastName => By.Id("Surname");
		public By PhoneNumber => By.Id("PhoneNumber");
		public By Email => By.Id("Email");
		public By SubjectSelectMenu => By.CssSelector("#Subject-button");
		public By TextAreaMessage => By.Id("Message");
		public By ValidationErrorMessage => By.CssSelector("div[class='validation-error']");
		//CheckBox
		public By CheckBoxes => By.CssSelector("div[class*='form-group--checkbox']");
		//ReCaptcha and Send Button
		public By ReCaptcha => By.CssSelector("div[class='g-recaptcha']");
		public By SendButton => By.CssSelector("form[class*='custom-form'] button");

		/// <summary>
		/// Coheris Form Selectors 
		/// </summary>
		public By TitleSelectField => By.Id("Title-button");
		public By Country => By.Id("Country-button");
		public By FirstName => By.Id("FirstName");
		public By Address => By.Id("Address");
		public By PostalCode => By.Id("PostalCode");
		public By City => By.Id("City");
		public By ConfirmEmail => By.Id("ConfirmEmail");
		public By ControlNumber => By.Id("ControlNumber");
		public By BarCode => By.Id("BarCode");
		public By Phone => By.Id("Phone");
		public By AgeRangeSelect => By.Id("AgeRange-button");
		public By AffectedProductSelect => By.Id("AffectedProduct-button");
		public By ReasonSelect => By.Id("Reason-button");

		#endregion

		#region Web elements

		public IWebElement ContactUsFormWebElement => Driver.FindElementWait(ContactUsForm, ExpectedConditions.ElementIsVisible(ContactUsForm));
		public IWebElement NameWebElement => Driver.FindElementWait(Name, ExpectedConditions.ElementIsVisible(Name));
		public IWebElement LastNameWebElement => Driver.FindElementWait(LastName, ExpectedConditions.ElementIsVisible(LastName));
		public IWebElement PhoneNumberWebElement => Driver.FindElementWait(PhoneNumber, ExpectedConditions.ElementIsVisible(PhoneNumber));
		public IWebElement EmailWebElement => Driver.FindElementWait(Email, ExpectedConditions.ElementIsVisible(Email));
		public IWebElement SubjectSelectMenuWebElement => Driver.FindElementWait(SubjectSelectMenu, ExpectedConditions.ElementIsVisible(SubjectSelectMenu));
		public IWebElement TextAreaMessageWebElement => Driver.FindElementWait(TextAreaMessage, ExpectedConditions.ElementIsVisible(TextAreaMessage));
		public IWebElement ValidationErrorMessageWebElement => Driver.FindElementWait(ValidationErrorMessage, ExpectedConditions.ElementIsVisible(ValidationErrorMessage));
		public IWebElement ReCaptchaWebElement => Driver.FindElementWait(ReCaptcha, ExpectedConditions.ElementIsVisible(ReCaptcha));
		public IWebElement SendButtonWebElement => Driver.FindElementWait(SendButton, ExpectedConditions.ElementIsVisible(SendButton));
		public IList<IWebElement> CheckBoxesWebElements => Driver.FindElementsWait(CheckBoxes);

		/// <summary>
		/// Coheris Form Web Elements
		/// </summary>
		public IWebElement TitleSelectFieldWebElement => Driver.FindElementWait(TitleSelectField, ExpectedConditions.ElementIsVisible(TitleSelectField));
		public IWebElement CountryWebElement => Driver.FindElementWait(Country, ExpectedConditions.ElementIsVisible(Country));
		public IWebElement FirstNameWebElement => Driver.FindElementWait(FirstName, ExpectedConditions.ElementIsVisible(FirstName));
		public IWebElement AddressWebElement => Driver.FindElementWait(Address, ExpectedConditions.ElementIsVisible(Address));
		public IWebElement PostalCodeWebElement => Driver.FindElementWait(PostalCode, ExpectedConditions.ElementIsVisible(PostalCode));
		public IWebElement CityWebElement => Driver.FindElementWait(City, ExpectedConditions.ElementIsVisible(City));
		public IWebElement ConfirmEmailWebElement => Driver.FindElementWait(ConfirmEmail, ExpectedConditions.ElementIsVisible(ConfirmEmail));
		public IWebElement ControlNumberWebElement => Driver.FindElementWait(ControlNumber, ExpectedConditions.ElementIsVisible(ControlNumber));
		public IWebElement BarCodeWebElement => Driver.FindElementWait(BarCode, ExpectedConditions.ElementIsVisible(BarCode));
		public IWebElement PhoneWebElement => Driver.FindElementWait(Phone, ExpectedConditions.ElementIsVisible(Phone));
		public IWebElement AgeRangeSelectWebElement => Driver.FindElementWait(AgeRangeSelect, ExpectedConditions.ElementIsVisible(AgeRangeSelect));
		public IWebElement AffectedProductSelectWebElement => Driver.FindElementWait(AffectedProductSelect, ExpectedConditions.ElementIsVisible(AffectedProductSelect));
		public IWebElement ReasonSelectWebElement => Driver.FindElementWait(ReasonSelect, ExpectedConditions.ElementIsVisible(ReasonSelect));

		#endregion

		#region Contructor and methods

		public ContactUsPage(Browser browser, string url = "") : base(browser, url)
		{

		}

		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		public bool IsContactUsFormLoaded() => ContactUsFormWebElement.Displayed;
		public bool IsNameDisplayed() => NameWebElement.Displayed;
		public bool IsLastNameDisplayed() => LastNameWebElement.Displayed;
		public bool IsPhoneNumberDisplayed() => PhoneNumberWebElement.Displayed;
		public bool IsEmailDisplayed() => EmailWebElement.Displayed;
		public bool IsSubjectSelectMenuDisplayed() => SubjectSelectMenuWebElement.Displayed;
		public bool IsTextAreaMessageDisplayed() => TextAreaMessageWebElement.Displayed;
		public bool IsValidationErrorMessageDisplayed() => ValidationErrorMessageWebElement.Displayed;
		public bool IsRecaptchaDisplayed() => ReCaptchaWebElement.Displayed;
		public bool IsSendButtonDisplayed() => SendButtonWebElement.Displayed;
		
		public bool AreCheckBoxesDisplayed()
		{
			foreach (var checkbox in CheckBoxesWebElements)
			{
                return checkbox.Displayed;
			}

			return false;
		}

		/// <summary>
		/// Coheris Form Web Elements
		/// </summary>
		public bool IsTitleSelectFieldDisplayed() => TitleSelectFieldWebElement.Displayed;
		public bool IsCountryDisplayed() => CountryWebElement.Displayed;
		public bool IsFirstNameDisplayed() => FirstNameWebElement.Displayed;
		public bool IsAddressDisplayed() => AddressWebElement.Displayed;
		public bool IsPostalCodeDisplayed() => PostalCodeWebElement.Displayed;
		public bool IsCityDisplayed() => CityWebElement.Displayed;
		public bool IsConfirmEmailDisplayed() => ConfirmEmailWebElement.Displayed;
		public bool IsControlNumberDisplayed() => ControlNumberWebElement.Displayed;
		public bool IsBarCodeDisplayed() => BarCodeWebElement.Displayed;
		public bool IsPhoneDisplayed() => PhoneWebElement.Displayed;
		public bool IsAgeRangeSelectDisplayed() => AgeRangeSelectWebElement.Displayed;
		public bool IsAffectedProductSelectDisplayed() => AffectedProductSelectWebElement.Displayed;
		public bool IsReasonSelectDisplayed() => ReasonSelectWebElement.Displayed;
		#endregion
	}
}
