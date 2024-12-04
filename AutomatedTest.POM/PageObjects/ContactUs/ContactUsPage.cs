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
		//CheckBox, ReCaptcha and Send Button
		public By CheckBoxes => By.CssSelector("div[class*='form-group--checkbox']");		
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
				
		public IList<IWebElement> CheckBoxesWebElements => Driver.FindElementsWait(CheckBoxes);
	
		#endregion

		#region Contructor and methods

		public ContactUsPage(Browser browser, string url = "") : base(browser, url)
		{

		}

		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		public bool IsContactUsFormLoaded() => IsDisplayed(ContactUsForm);
		public bool IsNameDisplayed() => IsDisplayed(Name);
		public bool IsLastNameDisplayed() => IsDisplayed(LastName);
		public bool IsPhoneNumberDisplayed() => IsDisplayed(PhoneNumber);
		public bool IsEmailDisplayed() => IsDisplayed(Email);
		public bool IsSubjectSelectMenuDisplayed() => IsDisplayed(SubjectSelectMenu);
		public bool IsTextAreaMessageDisplayed() => IsDisplayed(TextAreaMessage);
		public bool IsValidationErrorMessageDisplayed() => IsDisplayed(ValidationErrorMessage);
		public bool IsRecaptchaDisplayed() => IsDisplayed(ReCaptcha);
		public bool IsSendButtonDisplayed() => IsDisplayed(SendButton);
		
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
		public bool IsTitleSelectFieldDisplayed() => IsDisplayed(TitleSelectField);
		public bool IsCountryDisplayed() => IsDisplayed(Country);
		public bool IsFirstNameDisplayed() => IsDisplayed(FirstName);
		public bool IsAddressDisplayed() => IsDisplayed(Address);
		public bool IsPostalCodeDisplayed() => IsDisplayed(PostalCode);
		public bool IsCityDisplayed() => IsDisplayed(City);
		public bool IsConfirmEmailDisplayed() => IsDisplayed(ConfirmEmail);
		public bool IsControlNumberDisplayed() => IsDisplayed(ControlNumber);
		public bool IsBarCodeDisplayed() => IsDisplayed(BarCode);
		public bool IsPhoneDisplayed() => IsDisplayed(Phone);
		public bool IsAgeRangeSelectDisplayed() => IsDisplayed(AgeRangeSelect);
		public bool IsAffectedProductSelectDisplayed() => IsDisplayed(AffectedProductSelect);
		public bool IsReasonSelectDisplayed() => IsDisplayed(ReasonSelect);
		#endregion
	}
}
