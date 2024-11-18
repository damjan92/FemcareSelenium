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
		IWebElement BreadcrumbsWebElement => Driver.FindElementWait(Breadcrumbs, ExpectedConditions.ElementIsVisible(Breadcrumbs));
		IWebElement TitleOfProductWebElement => Driver.FindElementWait(TitleOfProduct, ExpectedConditions.ElementIsVisible(TitleOfProduct));
		IWebElement BvRatingsWebElement => Driver.FindElementWait(BvRatings, ExpectedConditions.ElementIsVisible(BvRatings));
		IWebElement FlowMeterWebElement => Driver.FindElementWait(FlowMeter, ExpectedConditions.ElementIsVisible(FlowMeter));
		IWebElement ProductDescriptionWebElement => Driver.FindElementWait(ProductDescription, ExpectedConditions.ElementIsVisible(ProductDescription));
		IWebElement ReasonToLoveWebElement => Driver.FindElementWait(ReasonToLove, ExpectedConditions.ElementIsVisible(ReasonToLove));
		IWebElement ProductNewsletterWebElement => Driver.FindElementWait(ProductNewsletter, ExpectedConditions.ElementIsVisible(ProductNewsletter));
		IWebElement ButtonProductNewsletterWebElement => Driver.FindElementWait(ButtonProductNewsletter, ExpectedConditions.ElementIsVisible(ButtonProductNewsletter));
		IWebElement ProductImageSwipperWebElement => Driver.FindElementWait(ProductImageSwipper, ExpectedConditions.ElementIsVisible(ProductImageSwipper));
		IWebElement ProductRetailersWebElemenet => Driver.FindElementWait(ProductRetailers, ExpectedConditions.ElementIsVisible(ProductRetailers));
		//Social icons
		IWebElement SocialLinkWebElement => Driver.FindElementWait(SocialLinks, ExpectedConditions.ElementToBeClickable(SocialLinks));
		IWebElement CardsPanelWebElement => Driver.FindElementWait(CardsPanel, ExpectedConditions.ElementIsVisible(CardsPanel));
		//BaazarVoice
		IWebElement BaazarVoiceContainerWebElement => Driver.FindElementWait(BaazarVoiceContainer, ExpectedConditions.ElementIsVisible(BaazarVoiceContainer));		

		#endregion

		#region Constructor and methods

		public ProductDetailPage(Browser browser, string url = "") : base(browser, url)
		{
		}

		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
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
		public bool IsSocialIconDisplayed() => SocialLinkWebElement.Displayed;
		public bool IsCardsPanelDisplayed() => CardsPanelWebElement.Displayed;
		public bool IsBaazarVoiceContainerDisplayed() => BaazarVoiceContainerWebElement.Displayed;

		#endregion
	}
}
