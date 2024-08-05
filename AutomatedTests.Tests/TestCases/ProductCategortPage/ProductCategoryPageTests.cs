using AutomatedTest.POM.PageObjects;
using AutomatedTests.Framework.Core;
using NUnit.Framework;

namespace AutomatedTests.Tests.TestCases
{
	[Category("Product Category Page")]
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
		public void AreHeaderDisplayed()
		{
			Assert.Multiple(() =>
			{
				Assert.That(productCategoryPage.IsTitleDisplayed(), "Title is not visible");
				Assert.That(productCategoryPage.IsBreadcrumbsDisplayed(), "Breadcrumbs are not visible");
			});
		}		
		[Test]
		public void IsPeriodPadsDisplayed()
		{
			Assert.That(productCategoryPage.IsPeriodPadsIndicatorDisplayed(), "Period pads indicator is to visible");
			Assert.That(productCategoryPage.IsPeriodPadsRangeSliderDisplayed(), "Period pads range slider is to visible");
			Assert.That(productCategoryPage.ArePeriodPadsProductsDisplayed(), "Period pads are not is to visible");
		}
		[Test]
		public void IsMaxiTowelsDisplayed()
		{
			Assert.That(productCategoryPage.IsMaxiTowelsIndicatorDisplayed(), "Maxi Towel indicator is to visible");
			Assert.That(productCategoryPage.IsMaxiTowelsRangeSliderDisplayed(), "Maxi Towel range slider is to visible");
			Assert.That(productCategoryPage.AreMaxiTowelProductsDisplayed(), "Maxi towels are not is to visible");
		}		
		[Test]
		public void IsPantyLinersDisplayed()
		{
			Assert.That(productCategoryPage.IsPantyLinersIndicatorDisplayed(), "Panty liners indicator is to visible");
			Assert.That(productCategoryPage.IsPantyLinersRangeSliderDisplayed(), "Panty liners range slider is to visible");
			Assert.That(productCategoryPage.ArePantyLinersProductsDisplayed(), "Panty liners are not is to visible");
		}		
		[Test]
		public void IsPeriodPantsDisplayed()
		{
			Assert.That(productCategoryPage.IsPeriodPantsIndicatorDisplayed(), "Period pads indicator is to visible");
			Assert.That(productCategoryPage.IsPeriodPantsRangeSliderDisplayed(), "Period pads range slider is to visible");
			Assert.That(productCategoryPage.ArePeriodPantsProductsDisplayed(), "Period pants are not is to visible");
		}		
	}
}
