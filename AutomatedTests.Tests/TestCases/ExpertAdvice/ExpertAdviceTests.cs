using AutomatedTest.POM.PageObjects;
using AutomatedTests.Framework.Core;
using NUnit.Framework;

namespace AutomatedTests.Tests.TestCases
{
	[Category("Expert Advice")]
	[TestFixtureSource(typeof(TestData), nameof(TestData.ExpertAdviceUrls))]
	[Parallelizable]
	public class ExpertAdviceTests(string websiteUrl) : BaseTest
	{
		private ExpertAdvicePage expertAdvice;

		[SetUp]
		public void NavigateToHomePage() 
		{
			if (expertAdvice == null || (!Browser.BrowserDriver.Url.EndsWith(""))) 
			{
				expertAdvice = new ExpertAdvicePage(Browser, websiteUrl);
			}
		}
		[Test]
		[Category("ErrorAlert - Expert Advice")]
		public void ErrorMessage() => Assert.That(expertAdvice.IsErrorMessageDisplayed(), Is.False, "Erros message is loaded!");
		[Test]
		public void IsTitleDisplayed() => Assert.That(expertAdvice.IsTitleDisplayed(), "Title is not visible");
		[Test]
		public void IsLatestQuestionSubDisplayed() => Assert.That(expertAdvice.IsLatestQuestionSubDisplayed(), "The Latest Question Displayed is not visible");
		[Test]
		public void IsBrowseLatestQuestionWebElement() => Assert.That(expertAdvice.IsBrowseLatestQuestionWebElement(), "Browse Latest Question Displayed is not visible");
		[Test]
		public void IsLoadMoreButtonDisplayed() => Assert.That(expertAdvice.IsLoadMoreButtonDisplayed(), "Load more button is not visible");
		[Test]
		public void AreAllQuestionDisplayed() => Assert.That(expertAdvice.AreAllQuestionDisplayed(), "Questions are not visible");
		[Test]
		public void CheckLoadingQuestions()
		{
			expertAdvice.ClickOnLoadMoreQuestion();
			Thread.Sleep(1000);
			Assert.That(expertAdvice.NumberOfResult(), Is.GreaterThan(13));
		}
	}
}
