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

		public IWebElement ContactUsFormWebElement => Driver.FindElementWait(ContactUsForm);
		public IWebElement NameWebElement => Driver.FindElementWait(Name);
		public IWebElement LastNameWebElement => Driver.FindElementWait(LastName);
		public IWebElement PhoneNumberWebElement => Driver.FindElementWait(PhoneNumber);
		public IWebElement EmailWebElement => Driver.FindElementWait(Email);
		public IWebElement SubjectSelectMenuWebElement => Driver.FindElementWait(SubjectSelectMenu);
		public IWebElement TextAreaMessageWebElement => Driver.FindElement(TextAreaMessage);
		public IWebElement ValidationErrorMessageWebElement => Driver.FindElementWait(ValidationErrorMessage);
		public IWebElement ReCaptchaWebElement => Driver.FindElementWait(ReCaptcha);
		public IWebElement SendButtonWebElement => Driver.FindElementWait(SendButton);
		public IList<IWebElement> CheckBoxesWebElements => Driver.FindElementsWait(CheckBoxes);

		/// <summary>
		/// Coheris Form Web Elements
		/// </summary>
		public IWebElement TitleSelectFieldWebElement => Driver.FindElementWait(TitleSelectField);
		public IWebElement CountryWebElement => Driver.FindElementWait(Country);
		public IWebElement FirstNameWebElement => Driver.FindElementWait(FirstName);
		public IWebElement AddressWebElement => Driver.FindElementWait(Address);
		public IWebElement PostalCodeWebElement => Driver.FindElementWait(PostalCode);
		public IWebElement CityWebElement => Driver.FindElementWait(City);
		public IWebElement ConfirmEmailWebElement => Driver.FindElementWait(ConfirmEmail);
		public IWebElement ControlNumberWebElement => Driver.FindElementWait(ControlNumber);
		public IWebElement BarCodeWebElement => Driver.FindElementWait(BarCode);
		public IWebElement PhoneWebElement => Driver.FindElementWait(Phone);
		public IWebElement AgeRangeSelectWebElement => Driver.FindElementWait(AgeRangeSelect);
		public IWebElement AffectedProductSelectWebElement => Driver.FindElementWait(AffectedProductSelect);
		public IWebElement ReasonSelectWebElement => Driver.FindElementWait(ReasonSelect);

		#endregion

		#region Contructor and methods

		public ContactUs(Browser browser, string url = "") : base(browser, url)
		{

		}

		public override bool IsPageLoaded() => RootElement.Text.ToLowerInvariant().Contains("events");
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
                Console.WriteLine("checkbox is visible");
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
