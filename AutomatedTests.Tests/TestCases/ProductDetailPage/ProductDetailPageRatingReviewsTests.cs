using AutomatedTest.POM.PageObjects;
using AutomatedTests.Framework.Core;
using NUnit.Framework;

namespace AutomatedTests.Tests.TestCases
{
	[Category("PDP Rating&Reviews")]
	[TestFixtureSource(typeof(TestData), nameof(TestData.ProductDetailPageRatingsReviews))]
	[Parallelizable]
	public class ProductDetailPageRatingReviewsTests(string websiteUrl) : BaseTest
	{
		private ProductDetailPageReviews productDetailPageReviews;
		[SetUp]
		public void NavigateToHomePage()
		{
			if (productDetailPageReviews == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				productDetailPageReviews = new ProductDetailPageReviews(Browser, websiteUrl);
			}
		}
		[Test]
		public void IsRrReviesContainerDisplayed() => Assert.That(productDetailPageReviews.IsRrReviesContainerDisplayed(), "RR reviews container is not visible");
		[Test]
		public void IsRrReviewsSnapshotDisplayed()
		{
			Assert.Multiple(() =>
			{
				Assert.That(productDetailPageReviews.IsRrReviewsSnapshotDisplayed(), "RR snapshot is not visible");
				Assert.That(productDetailPageReviews.IsRrTitleDisplayed(), "RR Title is not visible");
				Assert.That(productDetailPageReviews.IsRrHistogramRatingsDisplayed(), "RR histogram is not visible");
				Assert.That(productDetailPageReviews.IsRrWriteReviewButtonDisplayed(), "RR write review button is not visible");
				Assert.That(productDetailPageReviews.IsRrReviewFaceoffDisplayed(), "RR Faceoff is not visible");
			});
		}
		[Test]
		public void IsSearchAndSortDisplayed()
		{
			Assert.Multiple(() =>
			{
				Assert.That(productDetailPageReviews.IsRrSearchReviewDisplayed(), "RR search is not visible");
				Assert.That(productDetailPageReviews.IsRrSortReviewDisplayed(), "RR sort is not visible");				
			});
		}
		[Test]
		public void AreRrReviewsListDisplayed() => Assert.That(productDetailPageReviews.AreRrReviewsListDisplayed(), "Reviews are not visible");


	}
}
