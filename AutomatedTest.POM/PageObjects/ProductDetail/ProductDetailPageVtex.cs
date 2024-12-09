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
		public By ErrorMessage => By.CssSelector("div[class='alert-danger']");
		public By Breadcrumbs => By.CssSelector("ol[class='breadcrumbs__list']");
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
		//Vtex		
		IList<IWebElement> SizeCardsList => Driver.FindElementsWait(SizeCards);
		IWebElement AddToCartButtonWebElement => Driver.FindElementWait(AddToCartButton, ExpectedConditions.ElementIsVisible(AddToCartButton)); // in use
		// Cart Modal
		IWebElement CartModalViewCartWebElement => Driver.FindElementWait(CartModalViewCart, ExpectedConditions.ElementIsVisible(CartModalViewCart)); // in use
		
		#endregion

		#region Constructor and methods

		public ProductDetailPageVtex(Browser browser, string url = "") : base(browser, url)
		{
		}
		public bool IsErrorMessageDisplayed() => Driver.IsElementContainedBy(ErrorMessage, 3);
		public bool IsBreadcrumbsDisplayed() => IsDisplayed(Breadcrumbs);
		public bool IsTitleOfProductDisplayed() => IsDisplayed(TitleOfProduct);
		public bool IsFlowMeterDisplayed() => IsDisplayed(FlowMeter);
		public bool IsProductDescriptionDisplayed() => IsDisplayed(ProductDescription);
		public bool IsRatingStarsDisplayed() => IsDisplayed(RatingStars);
		public bool IsNumOfRatingDisplayed() => IsDisplayed(NumOfRating);
		public bool IsPriceDisplayed() => IsDisplayed(Price);
		public bool IsProductOptionsDisplayed() => IsDisplayed(ProductOptions);
		public bool AreSizeCardsDisplayed() => WebDriverExtensions.AreElementsDisplayed(SizeCardsList);
		public bool IsColorPickerDisplayed() => IsDisplayed(ColorPicker);
		public bool IsAddToCartCounterDisplayed() => IsDisplayed(AddToCartCounter);
		public bool IsAddToCartButtonDisplayed() => IsDisplayed(AddToCartButton);
		public bool IsSizeGuidTableDisplayed() => IsDisplayed(SizeGuidTable);
		public bool IsProductSafetyDisplayed() => IsDisplayed(ProductSafety);
		// Add to cart modal
		public bool IsAddToCartClicked() => WebDriverExtensions.ClickTheWebElement(AddToCartButtonWebElement);
		public bool IsCartModalTitleDisplayed() => IsDisplayed(CartModalTitle);
		public bool IsCartModalCloseBtnDisplayed() => IsDisplayed(CartModalCloseBtn);
		public bool IsCartModalProductImageDisplayed() => IsDisplayed(CartModalProductImage);
		public bool IsCartModalProductNameDisplayed() => IsDisplayed(CartModalProductName);
		public bool IsCartModalSkuNameDisplayed() => IsDisplayed(CartModalSkuName);
		public bool IsCartModalTotalPriceDisplayed() => IsDisplayed(CartModalTotalPrice);
		public bool IsCartModalViewCartDisplayed() => IsDisplayed(CartModalViewCart);
		public bool IsCartModalCheckoutDisplayed() => IsDisplayed(CartModalCheckout);
		// Cart
		public bool IsViewCartitoClicked() => WebDriverExtensions.ClickTheWebElement(CartModalViewCartWebElement);
		public bool IsCartDisplayed() => IsDisplayed(Cart);
		public bool IsCartTitleDisplayed() => IsDisplayed(CartTitle);
		public bool IsCartIndicatorDisplayed() => IsDisplayed(CartIndicator);
		public bool IsCartCloseDisplayed() => IsDisplayed(CartClose);
		public bool IsCartItemNameDisplayed() => IsDisplayed(CartItemName);
		public bool IsCartItemSkuNameDisplayed() => IsDisplayed(CartItemSkuName);
		public bool IsCartDeleteItemDisplayed() => IsDisplayed(CartDeleteItem);
		public bool IsCartCounterDisplayed() => IsDisplayed(CartCounter);
		public bool IsCartTotalPriceDisplayed() => IsDisplayed(CartTotalPrice);
		public bool IsCartSubtotalDisplayed() => IsDisplayed(CartSubtotal);
		public bool IsCartCheckOutButtonDisplayed() => IsDisplayed(CartCheckOutButton); // clickable
		#endregion
	}
}
