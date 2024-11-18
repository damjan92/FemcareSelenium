using AutomatedTest.POM.PageObjects;
using NUnit.Framework;

namespace AutomatedTests.Tests.TestCases
{
	[Category("Promotion Newsletter")]
	[TestFixtureSource(typeof(TestData), nameof(TestData.NewsletterSubscriptionUrls))]
	[Parallelizable]
	public class NewsletterSubscriptionTests(string websiteUrl) : BaseTest
	{
		private PromotionNewsletterPage promotionNewsletter;
		[SetUp]
		public void NavigateToHomePage()
		{
			if (promotionNewsletter == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				promotionNewsletter = new PromotionNewsletterPage(Browser, websiteUrl);
			}
		}
		[Test]
		[Category("ErrorAlert - Newsletter Subscription")]
		public void ErrorMessage() => Assert.That(promotionNewsletter.IsErrorMessageDisplayed(), Is.False, "Erros message is loaded!");
		[Test]
		public void IsNewsletterFormDisplayed() => Assert.That(promotionNewsletter.IsNewsletterFormDisplayed(), "Newsletter form is not visible");
		[Test]
		public void IsNewsletterNameDisplayed() => Assert.That(promotionNewsletter.IsNewsletterNameDisplayed(), "Name field is not visible");
		[Test]
		public void IsNewsletterEmailDisplayed() => Assert.That(promotionNewsletter.IsNewsletterEmailDisplayed(), "Email field is not visible");
		[Test]
		public void IsNewsletterRecaptchaDisplayed() => Assert.That(promotionNewsletter.IsNewsletterRecaptchaDisplayed(), "Recaptcha button is not visible");
		[Test]
		public void IsNewsletterButtonDisplayed() => Assert.That(promotionNewsletter.IsNewsletterButtonDisplayed(), "Submit button is not visible");
	}
}