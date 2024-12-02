using AutomatedTest.POM.PageObjects;
using NUnit.Framework;

namespace AutomatedTests.Tests.TestCases
{
    [Category("Ask the Expert")]
	[TestFixtureSource(typeof(TestData),nameof(TestData.AskTheExpertUrls))]
	[Parallelizable]
	public class AskTheExpertTests(string websiteUrl) : BaseTest
	{
		private AskTheExpertPage askTheExpert;

		[SetUp]
		public void NavigateToHomePage()
		{
			if (askTheExpert == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				askTheExpert = new AskTheExpertPage(Browser, websiteUrl);
			}
		}
		[Test]
		[Category("ErrorAlert - ATE")]
		public void ErrorMessage() => Assert.That(askTheExpert.IsErrorMessageDisplayed(), Is.False, "Erros message is loaded!");

		[Test]
		public void IsAskTheExpertWindowDisplayed() => Assert.That(askTheExpert.IsAskTheExpertWindowDisplayed(), "Ask the expert window is not visible");
		[Test]
		public void IsAskTheExpertInfoDisplayed() 
		{
			Assert.Multiple(() =>
			{
				Assert.That(askTheExpert.IsAteSubHeadingDisplayed(), "Sub heading is not visible");
				Assert.That(askTheExpert.IsExpertHeadlineDisplayed(), "Expert headline is not visible");
			});
		} 		
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

		/*[Test]
		public void IsTitleDisplayed() => Assert.That(askTheExpert.IsTitleDisplayed(), Is.True, "H1 is not displayed");*/
	}
}
