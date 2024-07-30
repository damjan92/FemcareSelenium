using AutomatedTest.POM.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.DevTools.V123.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTests.Tests.TestCases
{
	[TestFixtureSource(typeof(TestData), nameof(TestData.NewsletterSubscriptionUrls))]
	[Parallelizable]
	public class NewsletterSubscriptionTests(string websiteUrl) : BaseTest
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