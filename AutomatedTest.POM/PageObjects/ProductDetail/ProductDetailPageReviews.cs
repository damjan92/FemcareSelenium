using AutomatedTest.PageObjects;
using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomatedTest.POM.PageObjects
{
	public class ProductDetailPageReviews : BaseMainPage
	{
		#region Selectors
		// Bazaar Voice
		public By ErrorMessage => By.CssSelector("div[class='alert-danger']");
		public By BvReviewsContainer => By.CssSelector("div[class$='show-reviews-container']");
		public By BvReviewsOverview => By.CssSelector("div[class*='bv-rnr__sc-10ra6n1-1'] ");
		public By BvRatingsSnapshot => By.CssSelector("div[class*='bv-rnr__sc-10ra6n1-1'] div[class$='bv_rating_content1']");
		public By BvOveralRating => By.CssSelector("div[class*='bv-rnr__sc-10ra6n1-1'] div[class$='bv_rating_content2']");
		public By BvReviewTheProduct => By.CssSelector("div[class*='bv-rnr__sc-10ra6n1-1'] div[class$='bv_rating_content3']");
		public By BvAverageRatings => By.CssSelector("div[class*='fcxtdy']");
		public By BvSortRatings => By.CssSelector("div[class*='dKjomV']");
		public By BvCustomersReviews => By.CssSelector("div[class*='jtRfje']");
		public By BvLoadMoreButton => By.CssSelector(".bv-rnr__sc-16j1lpy-3.bv-rnr__sc-17t5kn5-1.SoYnF.iuGpzE");
		// Ratings and Reviews
		public By RrReviesContainer => By.CssSelector("div[class='power-reviews']");
		public By RrReviewsSnapshot => By.Id("pr-review-snapshot");
		public By RrTitle => By.CssSelector("h1[class$='pr-headline']");
		public By RrHistogramRatings => By.CssSelector("ul[class*='pr-histogram-list']");
		public By RrWriteReviewButton => By.CssSelector("div[class='power-reviews'] div[class='pr-snippet-read-and-write'] a");
		public By RrReviewFaceoff => By.CssSelector("section[class='pr-review-snapshot-faceoff']");
		public By RrSearchReview => By.CssSelector("div[class='pr-rd-search-reviews-input']");
		public By RrSortReview => By.CssSelector("div[class='pr-rd-sort-group']");
		public By RrReviews => By.CssSelector("div[class='pr-review']");
		#endregion

		#region WebElements

		// Baazar Voice
		IList<IWebElement> BvCustomersReviewsList => Driver.FindElementsWait(BvCustomersReviews);
		// Ratings and reviews	
		IList<IWebElement> RrReviewsList => Driver.FindElementsWait(RrReviews);
		#endregion

		#region Constructor and methods

		public ProductDetailPageReviews(Browser browser, string url = "") : base(browser, url)
		{
		}
		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		// Baazar Voice
		public bool IsBvReviewsContainerDisplayed() => IsDisplayed(BvReviewsContainer);
		public bool IsBvReviewsOverviewDisplayed() => IsDisplayed(BvReviewsOverview);
		public bool IsBvRatingsSnapshotDisplayed() => IsDisplayed(BvRatingsSnapshot);
		public bool IsBvOveralRatingDisplayed() => IsDisplayed(BvOveralRating);
		public bool IsBvReviewTheProductDisplayed() => IsDisplayed(BvReviewTheProduct);
		public bool IsBvAverageRatingsDisplayed() => IsDisplayed(BvAverageRatings);
		public bool IsBvSortRatingsDisplayed() => IsDisplayed(BvSortRatings);
		public bool AreBvCustomersReviewsListDisplayed() => WebDriverExtensions.AreElementsDisplayed(BvCustomersReviewsList);
		public bool IsBvLoadMoreButtonDisplayed() => IsDisplayed(BvLoadMoreButton);
		// Ratings and reviews
		public bool IsRrReviesContainerDisplayed() => IsDisplayed(RrReviesContainer);
		public bool IsRrReviewsSnapshotDisplayed() => IsDisplayed(RrReviewsSnapshot);
		public bool IsRrTitleDisplayed() => IsDisplayed(RrTitle);
		public bool IsRrHistogramRatingsDisplayed() => IsDisplayed(RrHistogramRatings);
		public bool IsRrWriteReviewButtonDisplayed() => IsDisplayed(RrWriteReviewButton);
		public bool IsRrReviewFaceoffDisplayed() => IsDisplayed(RrReviewFaceoff);
		public bool IsRrSearchReviewDisplayed() => IsDisplayed(RrSearchReview);
		public bool IsRrSortReviewDisplayed() => IsDisplayed(RrSortReview);
		public bool AreRrReviewsListDisplayed() => WebDriverExtensions.AreElementsDisplayed(RrReviewsList);
		#endregion
	}
}
