using AutomatedTest.POM.PageObjects;
using NUnit.Framework;

namespace AutomatedTests.Tests.TestCases
{
	[Category("Promotion Newsletter")]
	[TestFixtureSource(typeof(TestData), nameof(TestData.PromotionNewsletterUrls))]
	[Parallelizable]
	public class PromotionNewsletterTests(string websiteUrl) : BaseTest
	{
		private PromotionNewsletter promotionNewsletter;
		[SetUp]
		public void NavigateToHomePage()
		{
			if (promotionNewsletter == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				promotionNewsletter = new PromotionNewsletter(Browser, websiteUrl);
			}
		}
		[Test]
		public void IsPromotionFormDisplayed() => Assert.That(promotionNewsletter.IsPromotionFormDisplayed(), "Promotion form is not displayed");
		[Test]
		public void IsFirstNameDisplayed() => Assert.That(promotionNewsletter.IsFirstNameDisplayed(), "First name is not displayed");
		[Test]
		public void IsAgeFieldDisplayed() => Assert.That(promotionNewsletter.IsAgeFieldDisplayed(), "Age field is not displayed");
		[Test]
		public void IsMonthFieldDisplayed() => Assert.That(promotionNewsletter.IsMonthFieldDisplayed(), "Month field is not displayed");
		[Test]
		public void IsYearFieldDisplayed() => Assert.That(promotionNewsletter.IsYearFieldDisplayed(), "Year field is not displayed");
		[Test]
		public void IsEmailDisplayed() => Assert.That(promotionNewsletter.IsEmailDisplayed(), "Email field is not displayed");
		[Test]
		public void RecaptchaDisplayed() => Assert.That(promotionNewsletter.RecaptchaDisplayed(), "Recaptcha field is not displayed");
		[Test]
		public void IsSubmitButtonDisplayed() => Assert.That(promotionNewsletter.IsSubmitButtonDisplayed(), "Submit button is not displayed");


	}
}