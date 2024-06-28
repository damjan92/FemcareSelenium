using AutomatedTests.Tests.TestData;
using Femcare.POM.PageObjects;
using Femcare.Selenium.Framework.Core;
using Femcare.Selenium.Tests.TestCases;
using NUnit.Framework;

namespace Femcare.Selenium.Tests.TestCases
{
	[TestFixtureSource(typeof(TestData), nameof(TestData.ExpertAdviceUrls))]
	[Parallelizable]
	public class ExpertAdviceTests(string websiteUrl) : BaseTest
	{
		private ExpertAdvice expertAdvice;

		[SetUp]
		public void NavigateToHomePage() 
		{
			if (expertAdvice == null || (!Browser.BrowserDriver.Url.EndsWith(""))) 
			{
				expertAdvice = new ExpertAdvice(Browser, websiteUrl);
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
		public void Test_32_IsThird_TheLatestQuestionDisplayed()
		{
			Assert.That(expertAdvice.IsThird_TheLatestQuestionDisplayed(), "Third The Latest Question Displayed is not visible");
		}
		[Test]
		public void Test_33_IsIsLoadMoreButtonDisplayed()
		{
			Assert.That(expertAdvice.IsLoadMoreButtonDisplayed(), "Load more button is not visible");
		}
	}
}
