using AutomatedTest.POM.PageObjects;
using AutomatedTests.Framework.Core;
using NUnit.Framework;

namespace AutomatedTests.Tests.TestCases
{
	[Category("Contact us")]
	[TestFixtureSource(typeof(TestData), nameof(TestData.ContactUsUrls))]
	[Parallelizable]
	public class ContactUsTests(string websiteUrl) : BaseTest
	{
		private ContactUsPage contactUs;

		[SetUp]
		public void NavigateToHomePage()
		{
			if (contactUs == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				contactUs = new ContactUsPage(Browser, websiteUrl);
			}
		}
		[Test]
		[Category("ErrorAlert - Contact Us")]
		public void ErrorMessage() => Assert.That(contactUs.IsErrorMessageDisplayed(), Is.False, "Erros message is loaded!");
		[Test]
		public void IsContactUsFormLoaded() => Assert.That(contactUs.IsContactUsFormLoaded(), " Contact Us Form is not loaded!");
		[Test]
		public void AreFieldOFormsDisplayed()
		{
			Assert.Multiple(() =>
			{
				Assert.That(contactUs.IsNameDisplayed(), "First name field bar is loaded!");
				Assert.That(contactUs.IsEmailDisplayed(), "Email field is not loaded!");
				Assert.That(contactUs.IsTextAreaMessageDisplayed(), "Text area is not loaded!");
				Assert.That(contactUs.IsRecaptchaDisplayed(), "Recaptcha is not loaded!");
				Assert.That(contactUs.IsSendButtonDisplayed(), "Send button is not loaded!");
				Assert.That(contactUs.AreCheckBoxesDisplayed(), "Check boxes are not visible");
			});
		}		
	}
}
