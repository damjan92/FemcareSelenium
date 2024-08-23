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
		public void Test_28_IsTitleDisplayed()
		{
			Assert.That(expertAdvice.IsTitleDisplayed(), "Title is not visible");
		}
		[Test]
		public void Test_29_IsLatestQuestionSubDisplayed()
		{
			Assert.That(expertAdvice.IsLatestQuestionSubDisplayed(), "Subheading is not visible");
		}
		[Test]
		public void Test_30_IsFirst_TheLatestQuestionDisplayed()
		{
			Assert.That(expertAdvice.IsFirst_TheLatestQuestionDisplayed(), "First The Latest Question Displayed is not visible");
		}
		[Test]
		public void Test_31_IsSecond_TheLatestQuestionDisplayed()
		{
			Assert.That(expertAdvice.IsSecond_TheLatestQuestionDisplayed(), "Second The Latest Question Displayed is not visible");
		}		
		[Test]
		public void Test_33_IsIsLoadMoreButtonDisplayed()
		{
			Assert.That(expertAdvice.IsLoadMoreButtonDisplayed(), "Load more button is not visible");
		}
	}
}
