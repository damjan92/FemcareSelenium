using AutomatedTest.POM.PageObjects;
using NUnit.Framework;

namespace AutomatedTests.Tests.TestCases
{
    [Category("Contact us")]
	[TestFixtureSource(typeof(TestData), nameof(TestData.CoherisContactUsUrls))]
	[Parallelizable]
	public class CohersContactUsTests(string websiteUrl) : BaseTest
	{
		private ContactUsPage contactUs;

		[SetUp]
		public void NavigateToHomePage()
		{
            contactUs = NavigateToPage(contactUs, websiteUrl);			
		}
		[Test]
		[Category("ErrorAlert - ContactUs Coheris")]
		public void ErrorMessage() => Assert.That(contactUs.IsErrorMessageDisplayed(), Is.False, "Erros message is loaded!");
		[Test]
		public void IsContactUsCoherisFormDisplayed()
		{
			Assert.Multiple(() =>
			{
				Assert.That(contactUs.IsTitleSelectFieldDisplayed(), "Title select is not visible");
				Assert.That(contactUs.IsCountryDisplayed(), "Country select field is not visible");
				Assert.That(contactUs.IsNameDisplayed(), "Name is not visible");
				Assert.That(contactUs.IsFirstNameDisplayed(), " First Name is not visible");
				Assert.That(contactUs.IsAddressDisplayed(), "Adress field is not visible");
				Assert.That(contactUs.IsPostalCodeDisplayed(), "Postal code field is not visible");
				Assert.That(contactUs.IsCityDisplayed(), "Citi field is not visible");
				Assert.That(contactUs.IsEmailDisplayed(), "Email filed is not visible");
				Assert.That(contactUs.IsConfirmEmailDisplayed(), "confirmation email field is not visible");
				Assert.That(contactUs.IsControlNumberDisplayed(), "Control number is not visible");
				Assert.That(contactUs.IsBarCodeDisplayed(), "Bar code is not visible");
				Assert.That(contactUs.IsPhoneDisplayed(), "Phone field is not visible");
				Assert.That(contactUs.IsAgeRangeSelectDisplayed(), "Age range is not visible");
				Assert.That(contactUs.IsAffectedProductSelectDisplayed(), "Affected Product field is not visible");
				Assert.That(contactUs.IsReasonSelectDisplayed(), "Reason select field is not visible");
				Assert.That(contactUs.IsTextAreaMessageDisplayed(), "Text area is not loaded!");
				Assert.That(contactUs.IsRecaptchaDisplayed(), "Recaptcha is not loaded!");
				Assert.That(contactUs.IsSendButtonDisplayed(), "Send button is not loaded!");
				Assert.That(contactUs.AreCheckBoxesDisplayed(), "Check boxes are not visible");
			});
		}		
	}
}
