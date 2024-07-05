using AutomatedTest.POM.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTests.Tests.TestCases
{
	[TestFixtureSource(typeof(TestData),nameof(TestData.AskTheExpertUrls))]
	[Parallelizable]
	public class AskTheExpertTests(string websiteUrl) : BaseTest
	{
		private AskTheExpert askTheExpert;

		[SetUp]
		public void NavigateToHomePage()
		{
			if (askTheExpert == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				askTheExpert = new AskTheExpert(Browser, websiteUrl);
			}
		}
		[Test]
		public void IsTitleDisplayed() => Assert.That(askTheExpert.IsTitleDisplayed(), Is.True, "H1 is not displayed");
		[Test]
		public void IsAskTheExpertWindowDisplayed() => Assert.That(askTheExpert.IsAskTheExpertWindowDisplayed(), "Ask the expert window is not visible");
		[Test]
		public void IsAteSubHeadingDisplayed() => Assert.That(askTheExpert.IsAteSubHeadingDisplayed(), "Sub heading is not visible");
		[Test]
		public void IsExpertHeadlineDisplayed() => Assert.That(askTheExpert.IsExpertHeadlineDisplayed(), "Expert headline is not visible");
		[Test]
		public void IsExpertBodyDisplayed() => Assert.That(askTheExpert.IsExpertBodyDisplayed(), "Expert body element is not visible");
		[Test]
		public void IsExpertFormToggleButtonDisplayed() => Assert.That(askTheExpert.IsExpertFormToggleButtonDisplayed(), "Expert button is not displayed");
		[Test]
		public void IsExpertAnswersSubHeadingDisplayed() => Assert.That(askTheExpert.IsExpertAnswersSubHeadingDisplayed(), "Expert answer is not visible");
		[Test]
		public void IsLoadMoreButtonDisplayed() => Assert.That(askTheExpert.IsLoadMoreButtonDisplayed(), "Load button is not visible");
		[Test]
		public void IsAskTheExpertFormVisible()
		{
			askTheExpert.ClickOnButton();
			Assert.Multiple(() =>
			{
				Assert.That(askTheExpert.IsNameFieldDisplayed(), "Name field is not displayed");
				Assert.That(askTheExpert.IsEmailFieldDisplayed(), "Email field is not displayed");
				Assert.That(askTheExpert.IsQuestionDisplayed(), "Question field is not displayed");
				Assert.That(askTheExpert.IsSummaryDisplayed(), "Name field is not displayed");
				Assert.That(askTheExpert.IsRecaptchaDisplayed(), "Recaptcha field is not displayed");
				Assert.That(askTheExpert.IsAteSubmitButtonDisplayed(), "Submit button field is not displayed");
			});
		}
	}
}
