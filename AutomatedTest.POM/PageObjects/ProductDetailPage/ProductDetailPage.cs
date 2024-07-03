using AutomatedTest.PageObjects;
using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;

namespace AutomatedTest.POM.PageObjects
{
	public class ProductDetailPage : BaseMainPage
	{
		#region Selectors
		public By Breadcrumbs => By.CssSelector("div[class='breadcrumbs']");
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
		public By FacebookIcon => By.CssSelector("i[class=\"icon-share-facebook\"]");
		public By TwitterIcon => By.CssSelector("i[class=\"icon-share-twitter\"]");

		//Cards panel
		public By CardsPanel => By.CssSelector("div[class=\"cards-panel\"]");
		//IList<IWebElement> Cards => Driver.FindElements(By.CssSelector("div[class=\"card\"]"));

		//BaazarVoice
		public By BaazarVoiceContainer => By.CssSelector("div[class='show-reviews-container']");

		#endregion

		#region Web Elements
		IWebElement BreadcrumbsWebElement => Driver.FindElementWait(Breadcrumbs);
		IWebElement TitleOfProductWebElement => Driver.FindElementWait(TitleOfProduct);
		IWebElement BvRatingsWebElement => Driver.FindElementWait(BvRatings);
		IWebElement FlowMeterWebElement => Driver.FindElementWait(FlowMeter);
		IWebElement ProductDescriptionWebElement => Driver.FindElementWait(ProductDescription);
		IWebElement ReasonToLoveWebElement => Driver.FindElementWait(ReasonToLove);
		IWebElement ProductNewsletterWebElement => Driver.FindElementWait(ProductNewsletter);
		IWebElement ButtonProductNewsletterWebElement => Driver.FindElementWait(ButtonProductNewsletter);
		IWebElement ProductImageSwipperWebElement => Driver.FindElementWait(ProductImageSwipper);
		IWebElement ProductRetailersWebElemenet => Driver.FindElementWait(ProductRetailers);
		//Social icons
		IWebElement FacebookIconWebElement => Driver.FindElementWait(FacebookIcon);
		IWebElement TwitterIconWebElement => Driver.FindElementWait(TwitterIcon);
		//Cards panel
		IWebElement CardsPanelWebElement => Driver.FindElementWait(CardsPanel);
		//BaazarVoice
		IWebElement BaazarVoiceContainerWebElement => Driver.FindElementWait(BaazarVoiceContainer);

		#endregion

		#region Construktor and methods

		public ProductDetailPage(Browser browser, string url = "") : base(browser)
		{
		}

		public bool IsBreadcrumbsDisplayed() => BreadcrumbsWebElement.Displayed;
		public bool IsTitleOfProductDisplayed() => TitleOfProductWebElement.Displayed;
		public bool IsBvRatingsDisplayed() => BvRatingsWebElement.Displayed;
		public bool IsFlowMeterDisplayed() => FlowMeterWebElement.Displayed;
		public bool IsProductDescriptionDisplayed() => ProductDescriptionWebElement.Displayed;
		public bool IsReasonToLoveDisplayed() => ReasonToLoveWebElement.Displayed;
		public bool IsProductNewsletterDisplayed() => ProductNewsletterWebElement.Displayed;
		public bool IsButtonProductNewsletterDisplayed() => ButtonProductNewsletterWebElement.Displayed;
		public bool IsProductImageSwipperDisplayed() => ProductImageSwipperWebElement.Displayed;
		public bool IsProductRetailersDisplayed() => ProductRetailersWebElemenet.Displayed;
		public bool IsFacebookIconDisplayed() => FacebookIconWebElement.Displayed;
		public bool IsTwitterIconDisplayed() => TwitterIconWebElement.Displayed;
		public bool IsCardsPanelDisplayed() => CardsPanelWebElement.Displayed;
		public bool IsBaazarVoiceContainerDisplayed() => BaazarVoiceContainerWebElement.Displayed;
		#endregion
	}
}
