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
		IWebElement BvReviewsContainerWebElement => Driver.FindElementWait(BvReviewsContainer, ExpectedConditions.ElementIsVisible(BvReviewsContainer));
		IWebElement BvReviewsOverviewWebElement => Driver.FindElementWait(BvReviewsOverview, ExpectedConditions.ElementIsVisible(BvReviewsOverview));
		IWebElement BvRatingsSnapshotWebElement => Driver.FindElementWait(BvRatingsSnapshot, ExpectedConditions.ElementIsVisible(BvRatingsSnapshot));
		IWebElement BvOveralRatingWebElement => Driver.FindElementWait(BvOveralRating, ExpectedConditions.ElementIsVisible(BvOveralRating));
		IWebElement BvReviewTheProductWebElement => Driver.FindElementWait(BvReviewTheProduct, ExpectedConditions.ElementIsVisible(BvReviewTheProduct));
		IWebElement BvAverageRatingsWebElement => Driver.FindElementWait(BvAverageRatings, ExpectedConditions.ElementIsVisible(BvAverageRatings));
		IWebElement BvSortRatingsWebElement => Driver.FindElementWait(BvSortRatings, ExpectedConditions.ElementIsVisible(BvSortRatings));
		IList<IWebElement> BvCustomersReviewsList => Driver.FindElementsWait(BvCustomersReviews);
		IWebElement BvLoadMoreButtonWebElement => Driver.FindElementWait(BvLoadMoreButton, ExpectedConditions.ElementIsVisible(BvLoadMoreButton));
		// Ratings and reviews
		IWebElement RrReviesContainerWebElement => Driver.FindElementWait(RrReviesContainer, ExpectedConditions.ElementIsVisible(RrReviesContainer));
		IWebElement RrReviewsSnapshotWebElement => Driver.FindElementWait(RrReviewsSnapshot, ExpectedConditions.ElementIsVisible(RrReviewsSnapshot));
		IWebElement RrTitleWebElement => Driver.FindElementWait(RrTitle, ExpectedConditions.ElementIsVisible(RrTitle));
		IWebElement RrHistogramRatingsWebElement => Driver.FindElementWait(RrHistogramRatings, ExpectedConditions.ElementIsVisible(RrHistogramRatings));
		IWebElement RrWriteReviewButtonWebElement => Driver.FindElementWait(RrWriteReviewButton, ExpectedConditions.ElementIsVisible(RrWriteReviewButton));
		IWebElement RrReviewFaceoffWebElement => Driver.FindElementWait(RrReviewFaceoff, ExpectedConditions.ElementIsVisible(RrReviewFaceoff));
		IWebElement RrSearchReviewWebElement => Driver.FindElementWait(RrSearchReview, ExpectedConditions.ElementIsVisible(RrSearchReview));
		IWebElement RrSortReviewWebElement => Driver.FindElementWait(RrSortReview, ExpectedConditions.ElementIsVisible(RrSortReview));
		IList<IWebElement> RrReviewsList => Driver.FindElementsWait(RrReviews);
		#endregion

		#region Constructor and methods

		public ProductDetailPageReviews(Browser browser, string url = "") : base(browser, url)
		{
		}
		// Baazar Voice
		public bool IsBvReviewsContainerDisplayed() => BvReviewsContainerWebElement.Displayed;
		public bool IsBvReviewsOverviewDisplayed() => BvReviewsOverviewWebElement.Displayed;
		public bool IsBvRatingsSnapshotDisplayed() => BvRatingsSnapshotWebElement.Displayed;
		public bool IsBvOveralRatingDisplayed() => BvOveralRatingWebElement.Displayed;
		public bool IsBvReviewTheProductDisplayed() => BvReviewTheProductWebElement.Displayed;
		public bool IsBvAverageRatingsDisplayed() => BvAverageRatingsWebElement.Displayed;
		public bool IsBvSortRatingsDisplayed() => BvSortRatingsWebElement.Displayed;
		public bool AreBvCustomersReviewsListDisplayed() => WebDriverExtensions.AreElementsDisplayed(BvCustomersReviewsList);
		public bool IsBvLoadMoreButtonDisplayed() => BvLoadMoreButtonWebElement.Displayed;
		// Ratings and reviews
		public bool IsRrReviesContainerDisplayed() => RrReviesContainerWebElement.Displayed;
		public bool IsRrReviewsSnapshotDisplayed() => RrReviewsSnapshotWebElement.Displayed;
		public bool IsRrTitleDisplayed() => RrTitleWebElement.Displayed;
		public bool IsRrHistogramRatingsDisplayed() => RrHistogramRatingsWebElement.Displayed;
		public bool IsRrWriteReviewButtonDisplayed() => RrWriteReviewButtonWebElement.Displayed;
		public bool IsRrReviewFaceoffDisplayed() => RrReviewFaceoffWebElement.Displayed;
		public bool IsRrSearchReviewDisplayed() => RrSearchReviewWebElement.Displayed;
		public bool IsRrSortReviewDisplayed() => RrSortReviewWebElement.Displayed;
		public bool AreRrReviewsListDisplayed() => WebDriverExtensions.AreElementsDisplayed(RrReviewsList);
		#endregion
	}
}
