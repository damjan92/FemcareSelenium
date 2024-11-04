using AutomatedTest.POM.PageObjects;
using NUnit.Framework;
using AutomatedTests.Framework.Core;


namespace AutomatedTests.Tests.TestCases
{
	[Category("PDP Baazar Voice")]
	[TestFixtureSource(typeof(TestData), nameof(TestData.ProductDetailPageBaazarVoice))]
	[Parallelizable]
	public class ProductDetailPageBaazarVoiceTests(string websiteUrl) : BaseTest
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
		public void IsBvReviewsContainerDisplayed() => Assert.That(productDetailPageReviews.IsBvReviewsContainerDisplayed(), "Review contatiner is not visible");
		[Test]
		public void ErrorMessage() => Assert.That(productDetailPageReviews.IsErrorMessageDisplayed(), Is.False, "Erros message is loaded!");
		//[Test]
		//public void IsBvReviewsOverviewDisplayed()
		//{
		//	Assert.Multiple(() =>
		//	{
		//		Assert.That(productDetailPageReviews.IsBvReviewsOverviewDisplayed(), "Reviews overview is not visible");
		//		Assert.That(productDetailPageReviews.IsBvRatingsSnapshotDisplayed(), "Reviews snapshot is not visible");
		//		Assert.That(productDetailPageReviews.IsBvOveralRatingDisplayed(), "Overal rating is not visible");
		//		Assert.That(productDetailPageReviews.IsBvReviewTheProductDisplayed(), "Review the product is not visible");
		//		Assert.That(productDetailPageReviews.IsBvAverageRatingsDisplayed(), "Average product is not visible");
		//		Assert.That(productDetailPageReviews.IsBvSortRatingsDisplayed(), "Sort rating is not visible");
		//	});
		//}
		//[Test]
		//public void AreBvCustomersReviewsListDisplayed() => Assert.That(productDetailPageReviews.AreBvCustomersReviewsListDisplayed(), "Customer reviews are not visible");		
		//[Test]
		//public void IsBvLoadMoreButtonDisplayed() => Assert.That(productDetailPageReviews.IsBvLoadMoreButtonDisplayed(), "Load more button is not visible");
	}
}
