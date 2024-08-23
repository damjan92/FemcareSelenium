using AutomatedTest.PageObjects;
using AutomatedTests.Framework.Core;
using AutomatedTests.Framework.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomatedTest.POM.PageObjects
{
	public class ProductDetailPageVtex : BaseMainPage
	{
		#region Selectors		
		public By Breadcrumbs => By.CssSelector("div[class='breadcrumbs']");
		public By TitleOfProduct => By.TagName("h1");
		public By FlowMeter => By.CssSelector("div[class=\"product-metric product-metric--flow\"]");
		public By ProductDescription => By.CssSelector("div[class=\"product-main__description\"]");
		public By RatingStars => By.CssSelector("div[class='product-main__info'] div[class*='pr-snippet-stars-png']");
		public By NumOfRating => By.CssSelector("div[class='product-main__info'] div[class*='pr-snippet-read-and-write']");
		public By Price => By.CssSelector("div[class='product-main-purchase__price']");
		public By ProductOptions => By.CssSelector("div[class='product-main-options__title']");
		public By SizeCards => By.CssSelector("div[class*='form-group--chips'] label");
		public By ColorPicker => By.CssSelector("div[class*='form-group--color-picker'] input");
		public By AddToCartCounter => By.CssSelector("div[class='product-cart-add__counter']");
		public By AddToCartButton => By.CssSelector("button[class*='product-cart-add__button']");
		public By SizeGuidTable => By.CssSelector("div[class*='product-measurement__container']");
		public By ProductSafety => By.CssSelector("div[class='product-safety']");
		// CartModal
		public By CartModalTitle => By.CssSelector("div[class='cart-notification__title']");
		public By CartModalCloseBtn => By.CssSelector("div[class='cart-notification__close']");
		public By CartModalProductImage => By.CssSelector(" img[class='cart-notification__image']");
		public By CartModalProductName => By.CssSelector("div[class='cart-notification__name']");
		public By CartModalSkuName => By.CssSelector("div[class='cart-notification__skuName']");
		public By CartModalTotalPrice => By.CssSelector("div[class='cart-notification__total']");
		public By CartModalViewCart => By.CssSelector("div[class='cart-notification-view__button']");
		public By CartModalCheckout => By.CssSelector("div[class='cart-notification-checkout']");
		// Cart
		public By Cart => By.CssSelector("div[class='cart__dialog']");
		public By CartTitle => By.CssSelector("div[class='cart__dialog'] div[class='cart__title']");
		public By CartIndicator => By.CssSelector("div[class='cart-indicator']");
		public By CartClose => By.CssSelector("div[class='cart__close']");
		public By CartItemName => By.CssSelector("div[class='cart-item__name'] div[class='cart-item__name']");
		public By CartItemSkuName => By.CssSelector("div[class='cart-item__skuName']");
		public By CartDeleteItem => By.CssSelector("div[class='cart-item__delete']");
		public By CartCounter => By.CssSelector("div[class='cart-item__counter']");
		public By CartTotalPrice => By.CssSelector("div[class='cart-item__total']");
		public By CartSubtotal => By.CssSelector("div[class='cart-subtotal']");
		public By CartCheckOutButton => By.CssSelector("div[class$='cart-checkout'] a");

		#endregion

		#region Web Elements
		IWebElement BreadcrumbsWebElement => Driver.FindElementWait(Breadcrumbs, ExpectedConditions.ElementIsVisible(Breadcrumbs));
		IWebElement TitleOfProductWebElement => Driver.FindElementWait(TitleOfProduct, ExpectedConditions.ElementIsVisible(TitleOfProduct));
		IWebElement FlowMeterWebElement => Driver.FindElementWait(FlowMeter, ExpectedConditions.ElementIsVisible(FlowMeter));
		IWebElement ProductDescriptionWebElement => Driver.FindElementWait(ProductDescription, ExpectedConditions.ElementIsVisible(ProductDescription));
		//Vtex
		IWebElement RatingStarsWebElement => Driver.FindElementWait(RatingStars, ExpectedConditions.ElementIsVisible(RatingStars));
		IWebElement NumOfRatingWebElement => Driver.FindElementWait(NumOfRating, ExpectedConditions.ElementToBeClickable(NumOfRating));
		IWebElement PriceWebElement => Driver.FindElementWait(Price, ExpectedConditions.ElementIsVisible(Price));
		IWebElement ProductOptionsWebElement => Driver.FindElementWait(ProductOptions, ExpectedConditions.ElementIsVisible(ProductOptions));
		IList<IWebElement> SizeCardsList => Driver.FindElementsWait(SizeCards);
		IWebElement ColorPickerWebElement => Driver.FindElementWait(ColorPicker, ExpectedConditions.ElementIsVisible(ColorPicker));
		IWebElement AddToCartCounterWebElement => Driver.FindElementWait(AddToCartCounter, ExpectedConditions.ElementIsVisible(AddToCartCounter));
		IWebElement AddToCartButtonWebElement => Driver.FindElementWait(AddToCartButton, ExpectedConditions.ElementIsVisible(AddToCartButton));
		IWebElement SizeGuidTableWebElement => Driver.FindElementWait(SizeGuidTable, ExpectedConditions.ElementIsVisible(SizeGuidTable));
		IWebElement ProductSafetyWebElement => Driver.FindElementWait(ProductSafety, ExpectedConditions.ElementIsVisible(ProductSafety));
		// Cart Modal
		IWebElement CartModalTitleWebElement => Driver.FindElementWait(CartModalTitle, ExpectedConditions.ElementIsVisible(CartModalTitle));
		IWebElement CartModalCloseBtnWebElement => Driver.FindElementWait(CartModalCloseBtn, ExpectedConditions.ElementToBeClickable(CartModalCloseBtn));
		IWebElement CartModalProductImageWebElement => Driver.FindElementWait(CartModalProductImage, ExpectedConditions.ElementIsVisible(CartModalProductImage));
		IWebElement CartModalProductNameWebElement => Driver.FindElementWait(CartModalProductName, ExpectedConditions.ElementIsVisible(CartModalProductName));
		IWebElement CartModalSkuNameWebElement => Driver.FindElementWait(CartModalSkuName, ExpectedConditions.ElementIsVisible(CartModalSkuName));
		IWebElement CartModalTotalPriceWebElement => Driver.FindElementWait(CartModalTotalPrice, ExpectedConditions.ElementIsVisible(CartModalTotalPrice));
		IWebElement CartModalViewCartWebElement => Driver.FindElementWait(CartModalViewCart, ExpectedConditions.ElementIsVisible(CartModalViewCart));
		IWebElement CartModalCheckoutWebElement => Driver.FindElementWait(CartModalCheckout, ExpectedConditions.ElementIsVisible(CartModalCheckout));
		// Cart
		IWebElement CartWebElement => Driver.FindElementWait(Cart, ExpectedConditions.ElementIsVisible(Cart));
		IWebElement CartTitleWebElement => Driver.FindElementWait(CartTitle, ExpectedConditions.ElementIsVisible(CartTitle));
		IWebElement CartIndicatorWebElement => Driver.FindElementWait(CartIndicator, ExpectedConditions.ElementIsVisible(CartIndicator));
		IWebElement CartCloseWebElement => Driver.FindElementWait(CartClose, ExpectedConditions.ElementIsVisible(CartClose));
		IWebElement CartItemNameWebElement => Driver.FindElementWait(CartItemName, ExpectedConditions.ElementIsVisible(CartItemName));
		IWebElement CartItemSkuNameWebElement => Driver.FindElementWait(CartItemSkuName, ExpectedConditions.ElementIsVisible(CartItemSkuName));
		IWebElement CartDeleteItemWebElement => Driver.FindElementWait(CartDeleteItem, ExpectedConditions.ElementIsVisible(CartDeleteItem));
		IWebElement CartCounterWebElement => Driver.FindElementWait(CartCounter, ExpectedConditions.ElementIsVisible(CartCounter));
		IWebElement CartTotalPriceWebElement => Driver.FindElementWait(CartTotalPrice, ExpectedConditions.ElementIsVisible(CartTotalPrice));
		IWebElement CartSubtotalWebElement => Driver.FindElementWait(CartSubtotal, ExpectedConditions.ElementIsVisible(CartSubtotal));
		IWebElement CartCheckOutButtonWebElement => Driver.FindElementWait(CartCheckOutButton, ExpectedConditions.ElementToBeClickable(CartCheckOutButton));

		#endregion

		#region Constructor and methods

		public ProductDetailPageVtex(Browser browser, string url = "") : base(browser, url)
		{
		}
		public bool IsBreadcrumbsDisplayed() => BreadcrumbsWebElement.Displayed;
		public bool IsTitleOfProductDisplayed() => TitleOfProductWebElement.Displayed;
		public bool IsFlowMeterDisplayed() => FlowMeterWebElement.Displayed;
		public bool IsProductDescriptionDisplayed() => ProductDescriptionWebElement.Displayed;
		public bool IsRatingStarsDisplayed() => RatingStarsWebElement.Displayed;
		public bool IsNumOfRatingDisplayed() => NumOfRatingWebElement.Displayed;
		public bool IsPriceDisplayed() => PriceWebElement.Displayed;
		public bool IsProductOptionsDisplayed() => ProductOptionsWebElement.Displayed;
		public bool AreSizeCardsDisplayed() => WebDriverExtensions.AreElementsDisplayed(SizeCardsList);
		public bool IsColorPickerDisplayed() => ColorPickerWebElement.Displayed;
		public bool IsAddToCartCounterDisplayed() => AddToCartCounterWebElement.Displayed;
		public bool IsAddToCartButtonDisplayed() => AddToCartButtonWebElement.Displayed;
		public bool IsSizeGuidTableDisplayed() => SizeGuidTableWebElement.Displayed;
		public bool IsProductSafetyDisplayed() => ProductSafetyWebElement.Displayed;
		// Add to cart modal
		public bool IsAddToCartClicked() => WebDriverExtensions.ClickTheWebElement(AddToCartButtonWebElement);
		public bool IsCartModalTitleDisplayed() => CartModalTitleWebElement.Displayed;
		public bool IsCartModalCloseBtnDisplayed() => CartModalCloseBtnWebElement.Displayed;
		public bool IsCartModalProductImageDisplayed() => CartModalProductImageWebElement.Displayed;
		public bool IsCartModalProductNameDisplayed() => CartModalProductNameWebElement.Displayed;
		public bool IsCartModalSkuNameDisplayed() => CartModalSkuNameWebElement.Displayed;
		public bool IsCartModalTotalPriceDisplayed() => CartModalTotalPriceWebElement.Displayed;
		public bool IsCartModalViewCartDisplayed() => CartModalViewCartWebElement.Displayed;
		public bool IsCartModalCheckoutDisplayed() => CartModalCheckoutWebElement.Displayed;
		// Cart
		public bool IsViewCartitoClicked() => WebDriverExtensions.ClickTheWebElement(CartModalViewCartWebElement);
		public bool IsCartDisplayed() => CartWebElement.Displayed;
		public bool IsCartTitleDisplayed() => CartTitleWebElement.Displayed;
		public bool IsCartIndicatorDisplayed() => CartIndicatorWebElement.Displayed;
		public bool IsCartCloseDisplayed() => CartCloseWebElement.Displayed;
		public bool IsCartItemNameDisplayed() => CartItemNameWebElement.Displayed;
		public bool IsCartItemSkuNameDisplayed() => CartItemSkuNameWebElement.Displayed;
		public bool IsCartDeleteItemDisplayed() => CartDeleteItemWebElement.Displayed;
		public bool IsCartCounterDisplayed() => CartCounterWebElement.Displayed;
		public bool IsCartTotalPriceDisplayed() => CartTotalPriceWebElement.Displayed;
		public bool IsCartSubtotalDisplayed() => CartSubtotalWebElement.Displayed;
		public bool IsCartCheckOutButtonDisplayed() => CartCheckOutButtonWebElement.Displayed;
		#endregion
	}
}
