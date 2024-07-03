using AutomatedTest.POM.PageObjects;
using AutomatedTests.Framework.Core;
using NUnit.Framework;

namespace AutomatedTests.Tests.TestCases
{
	[TestFixtureSource(typeof(TestData), nameof(TestData.ProductCategoryPageUrls))]
	[Parallelizable]
	public class ProductCategoryPageTests(string websiteUrl) : BaseTest
	{
		private ProductCategoryPage productCategoryPage;

		[SetUp]
		public void NavigateToHomePage()
		{
			if (productCategoryPage == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				productCategoryPage = new ProductCategoryPage(Browser, websiteUrl);
			}
		}
		[Test]
		public void IsTitleDisplayed() 
		{
			Assert.That(productCategoryPage.IsTitleDisplayed(), "Title is not visible");
		}
		[Test]
		public void IsBreadcrumbsDisplayed()
		{
			Assert.That(productCategoryPage.IsBreadcrumbsDisplayed(), "Breadcrumbs are not visible");
		}
		[Test]
		public void IsPeriodPadsIndicatorDisplayed()
		{
			Assert.That(productCategoryPage.IsPeriodPadsIndicatorDisplayed(), "Period pads indicator is to visible");
		}
		[Test]
		public void IsPeriodPadsRangeSliderDisplayed()
		{
			Assert.That(productCategoryPage.IsPeriodPadsRangeSliderDisplayed(), "Period pads range slider is to visible");
		}
		[Test]
		public void IsMaxiTowelsIndicatorDisplayed()
		{
			Assert.That(productCategoryPage.IsMaxiTowelsIndicatorDisplayed(), "Maxi Towel indicator is to visible");
		}
		[Test]
		public void IsMaxiTowelsRangeSliderDisplayed()
		{
			Assert.That(productCategoryPage.IsMaxiTowelsRangeSliderDisplayed(), "Maxi Towel range slider is to visible");
		}
		[Test]
		public void IsPantyLinersIndicatorDisplayed()
		{
			Assert.That(productCategoryPage.IsPantyLinersIndicatorDisplayed(), "Panty liners indicator is to visible");
		}
		[Test]
		public void IsPantyLinersRangeSliderDisplayed()
		{
			Assert.That(productCategoryPage.IsPantyLinersRangeSliderDisplayed(), "Panty liners range slider is to visible");
		}
		[Test]
		public void IsPeriodPantsIndicatorDisplayed()
		{
			Assert.That(productCategoryPage.IsPeriodPantsIndicatorDisplayed(), "Period pads indicator is to visible");
		}
		[Test]
		public void IsPeriodPantsRangeSliderDisplayed()
		{
			Assert.That(productCategoryPage.IsPeriodPantsRangeSliderDisplayed(), "Period pads range slider is to visible");
		}
		public void DevelopBranch()
		{
			Assert.That(productCategoryPage.IsTitleDisplayed(), "Title is not visible");
		}
		public void RenameFunc()
		{
			Assert.That(productCategoryPage.IsTitleDisplayed(), "Title is not visible");
		}
	}
}
