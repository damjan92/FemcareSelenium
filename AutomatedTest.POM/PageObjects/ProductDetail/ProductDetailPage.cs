using AutomatedTest.PageObjects;

using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomatedTest.POM.PageObjects
{
	public class ProductDetailPage : BaseMainPage
	{
		#region Selectors
		public By ErrorMessage => By.CssSelector("div[class='alert-danger']");
		public By Breadcrumbs => By.CssSelector("ol[class='breadcrumbs__list']");
		public By TitleOfProduct => By.TagName("h1");
		public By BvRatings => By.CssSelector("div[class=\"bv_main_container\"]");
		public By FlowMeter => By.CssSelector("div[class=\"product-metric product-metric--flow\"]");
		public By ProductDescription => By.CssSelector("div[class=\"product-main__description\"]");
		public By ReasonToLove => By.CssSelector("div[class*=\"accordion__header\"]");
		public By ProductNewsletter => By.CssSelector("div[class=\"product-newsletter\"]");
		public By ButtonProductNewsletter => By.CssSelector("div[class=\"product-newsletter__link\"]");
		public By MainProductImage => By.CssSelector("product-main__image product-main__image--standard");
		public By ProductImageSwipper => By.CssSelector("div[class*=\"product-main__thumbnails-wrapper\"]");
		public By ProductRetailers => By.CssSelector("div[class=\"product-retailers\"]");
		//Social icons
		public By SocialLinks=> By.CssSelector("ul[class='social__list']");
		//Cards panel
		public By CardsPanel => By.CssSelector("div[class=\"cards-panel\"]");
		//BaazarVoice
		public By BaazarVoiceContainer => By.CssSelector("div[class='show-reviews-container']");
		
		#endregion

		#region Web Elements	
		//
		#endregion

		#region Constructor and methods

		public ProductDetailPage(Browser browser, string url = "") : base(browser, url)
		{
		}

		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		public bool IsBreadcrumbsDisplayed() => IsDisplayed(Breadcrumbs);
		public bool IsTitleOfProductDisplayed() => IsDisplayed(TitleOfProduct);
		public bool IsBvRatingsDisplayed() => IsDisplayed(BvRatings);
		public bool IsFlowMeterDisplayed() => IsDisplayed(FlowMeter);
		public bool IsProductDescriptionDisplayed() => IsDisplayed(ProductDescription);
		public bool IsReasonToLoveDisplayed() => IsDisplayed(ReasonToLove);		
		public bool IsProductImageSwipperDisplayed() => IsDisplayed(ProductImageSwipper);
		public bool IsProductRetailersDisplayed() => IsDisplayed(ProductRetailers);
		public bool IsSocialIconDisplayed() => IsDisplayed(SocialLinks);
		public bool IsCardsPanelDisplayed() => IsDisplayed(CardsPanel);
		public bool IsBaazarVoiceContainerDisplayed() => IsDisplayed(BaazarVoiceContainer);

		#endregion
	}
}
