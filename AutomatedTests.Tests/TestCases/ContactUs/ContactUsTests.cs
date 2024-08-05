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
		private ContactUs contactUs;

		[SetUp]
		public void NavigateToHomePage()
		{
			if (contactUs == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				contactUs = new ContactUs(Browser, websiteUrl);
			}
		}

		[Test]
		public void IsContactUsFormLoaded() => Assert.That(contactUs.IsContactUsFormLoaded(), " Contact Us Form is not loaded!");
		[Test]
		public void IsNameDisplayed() => Assert.That(contactUs.IsNameDisplayed(), "First name field bar is loaded!");
		[Test]
		public void IsEmailDisplayedDisplayed() => Assert.That(contactUs.IsEmailDisplayed(), "Email field is not loaded!");
		[Test]
		public void IsTextAreaMessageDisplayed() => Assert.That(contactUs.IsTextAreaMessageDisplayed(), "Text area is not loaded!");
		[Test]
		public void IsRecaptchaDisplayed() => Assert.That(contactUs.IsRecaptchaDisplayed(), "Recaptcha is not loaded!");
		[Test]
		public void IsSendButtonDisplayed() => Assert.That(contactUs.IsSendButtonDisplayed(), "Send button is not loaded!");
		[Test]
		public void AreCheckBoxesDisplayed() => Assert.That(contactUs.AreCheckBoxesDisplayed(), "Check boxes are not visible");

		//[Test]
		// public void Test_09_IsSubjectSelectMenuDisplayed() => Assert.That(contactUs.IsSubjectSelectMenuDisplayed(), "SubjectSelectMenu is not loaded!");
	}
}
