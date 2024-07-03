using AutomatedTest.POM.PageObjects;
using AutomatedTests.Framework.Core;
using NUnit.Framework;

namespace AutomatedTests.Tests.TestCases
{
	[TestFixtureSource(typeof(TestData), nameof(TestData.ProductDetailPageUrls))]
	[Parallelizable]
	public class ProductDetailPageTests(string websiteUrl) : BaseTest
	{
		private ProductDetailPage productDetailPage;

		[SetUp]
		public void NavigateToHomePage()
		{
			if (productDetailPage == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				productDetailPage = new ProductDetailPage(Browser, websiteUrl);
			}
		}
		[Test]
		public void IsBreadcrumbsDisplayed() => Assert.That(productDetailPage.IsBreadcrumbsDisplayed(), "Breadcrumbs is not visible");
		[Test]
		public void IsTitleOfProductDisplayed() => Assert.That(productDetailPage.IsTitleOfProductDisplayed(), "Ttile is not visible");
		[Test]
		public void IsFlowMeterDisplayed() => Assert.That(productDetailPage.IsFlowMeterDisplayed(), "Flow meter is not visible");
		[Test]
		public void IsProductDescriptionDisplayed() => Assert.That(productDetailPage.IsProductDescriptionDisplayed(), "Product description is not visible");
		[Test]
		public void IsReasonToLoveDisplayed() => Assert.That(productDetailPage.IsReasonToLoveDisplayed(), "Reason to leave section is not visible");
		[Test]
		public void IsProductNewsletterDisplayed() => Assert.That(productDetailPage.IsProductNewsletterDisplayed(), "Product newsletter is not visible");
		[Test]
		public void IsButtonProductNewsletterDisplayed() => Assert.That(productDetailPage.IsButtonProductNewsletterDisplayed(), "Button product newsletter is not visible");
		[Test]
		public void IsProductImageSwipperDisplayed() => Assert.That(productDetailPage.IsProductImageSwipperDisplayed(), "Product image swiper is not visible");
		[Test]
		public void IsProductRetailersDisplayed() => Assert.That(productDetailPage.IsProductRetailersDisplayed(), "Product reatiler is not visible");
		[Test]
		public void IsFacebookIconDisplayed() => Assert.That(productDetailPage.IsFacebookIconDisplayed(), "Facebook icon is not visible");
		[Test]
		public void IsCardsPanelDisplayed() => Assert.That(productDetailPage.IsCardsPanelDisplayed(), "Twitter icon is not visible");
	}
	
}
