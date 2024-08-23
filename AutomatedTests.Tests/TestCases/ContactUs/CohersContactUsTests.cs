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
		public void IsTitleSelectFieldDisplayed() => Assert.That(contactUs.IsTitleSelectFieldDisplayed(), "Title select is not visible");
		[Test]
		public void IsCountryDisplayed() => Assert.That(contactUs.IsCountryDisplayed(), "Country select field is not visible");
		[Test]
		public void IsNameDisplayed() => Assert.That(contactUs.IsNameDisplayed(), "Name is not visible");
		[Test]
		public void IsFirstNameDisplayed() => Assert.That(contactUs.IsFirstNameDisplayed(), " First Name is not visible");
		[Test]
		public void IsAddressDisplayed() => Assert.That(contactUs.IsAddressDisplayed(), "Adress field is not visible");
		[Test]
		public void IsPostalCodeDisplayed() => Assert.That(contactUs.IsPostalCodeDisplayed(), "Postal code field is not visible");
		[Test]
		public void IsCityDisplayed() => Assert.That(contactUs.IsCityDisplayed(), "Citi field is not visible");
		[Test]
		public void IsEmailDisplayed() => Assert.That(contactUs.IsEmailDisplayed(), "Email filed is not visible");
		[Test]
		public void IsConfirmEmailDisplayed() => Assert.That(contactUs.IsConfirmEmailDisplayed(), "confirmation email field is not visible");
		[Test]
		public void IsControlNumberDisplayed() => Assert.That(contactUs.IsControlNumberDisplayed(), "Control number is not visible");
		[Test]
		public void IsBarCodeDisplayed() => Assert.That(contactUs.IsBarCodeDisplayed(), "Bar code is not visible");
		[Test]
		public void IsPhoneDisplayed() => Assert.That(contactUs.IsPhoneDisplayed(), "Phone field is not visible");
		[Test]
		public void IsAgeRangeSelectDisplayed() => Assert.That(contactUs.IsAgeRangeSelectDisplayed(), "Age range is not visible");
		[Test]
		public void IsAffectedProductSelectDisplayed() => Assert.That(contactUs.IsAffectedProductSelectDisplayed(), "Affected Product field is not visible");
		[Test]
		public void IsReasonSelectDisplayed() => Assert.That(contactUs.IsReasonSelectDisplayed(), "Reason select field is not visible");
		[Test]
		public void IsTextAreaMessageDisplayed() => Assert.That(contactUs.IsTextAreaMessageDisplayed(), "Text area is not loaded!");
		[Test]
		public void IsRecaptchaDisplayed() => Assert.That(contactUs.IsRecaptchaDisplayed(), "Recaptcha is not loaded!");
		[Test]
		public void IsSendButtonDisplayed() => Assert.That(contactUs.IsSendButtonDisplayed(), "Send button is not loaded!");
		[Test]
		public void AreCheckBoxesDisplayed() => Assert.That(contactUs.AreCheckBoxesDisplayed(), "Check boxes are not visible");
	}
}
