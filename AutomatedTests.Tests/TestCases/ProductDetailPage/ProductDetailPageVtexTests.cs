using AutomatedTest.POM.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTests.Tests.TestCases
{
	[Category("Product Detail Page Vtex")]
	[TestFixtureSource(typeof(TestData), nameof(TestData.ProductDetailPageVtex))]
	[Parallelizable]
	public class ProductDetailPageVtexTests(string websiteUrl) : BaseTest
	{
		private ProductDetailPageVtex productDetailPageVtex ;

		[SetUp]
		public void NavigateToHomePage()
		{
			if (productDetailPageVtex == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				productDetailPageVtex = new ProductDetailPageVtex(Browser, websiteUrl);
			}
		}
		[Test]
		[Category("ErrorAlert - PDP Vtex")]
		public void ErrorMessage() => Assert.That(productDetailPageVtex.IsErrorMessageDisplayed(), Is.False, "Erros message is loaded!");
		[Test]
		public void AreProductHeaderInfoDisplayed()
		{
			Assert.Multiple(() =>
			{
				Assert.That(productDetailPageVtex.IsBreadcrumbsDisplayed(), "Breadcrumbs is not visible");
				Assert.That(productDetailPageVtex.IsTitleOfProductDisplayed(), "Ttile is not visible");
				Assert.That(productDetailPageVtex.IsFlowMeterDisplayed(), "Flow meter is not visible");
			});
		}				
		[Test]
		public void AreProductInfoDisplayed()
		{
			Assert.Multiple(() =>
			{
				Assert.That(productDetailPageVtex.IsFlowMeterDisplayed(), "Flow meter is not visible");
				Assert.That(productDetailPageVtex.IsRatingStarsDisplayed(), "Rating stars are not visible");
				Assert.That(productDetailPageVtex.IsNumOfRatingDisplayed(), "Number of ratings are not visible");
				Assert.That(productDetailPageVtex.IsPriceDisplayed(), "Price is not visible");
			});
		}
		[Test]
		public void IsProductDescriptionDisplayed() => Assert.That(productDetailPageVtex.IsProductDescriptionDisplayed(), "Product description is not visible");
		[Test]
		public void AreProductOptionsDisplayed()
		{
			Assert.Multiple(() =>
			{
				Assert.That(productDetailPageVtex.IsProductOptionsDisplayed(), "Product option are not visible");
				Assert.That(productDetailPageVtex.AreSizeCardsDisplayed(), "Size option are not visible");
				Assert.That(productDetailPageVtex.IsColorPickerDisplayed(), "Color picker are not visible");
			});
		}
		[Test]
		public void AreAddToCartButtonIsVisible() => Assert.That(productDetailPageVtex.IsAddToCartButtonDisplayed(), "Add to cart button is not visible");
		[Test]
		public void AreAddToCartCounterIsVisible() => Assert.That(productDetailPageVtex.IsAddToCartCounterDisplayed(), "Add to cart counter is not visible");
		[Test]
		public void IsSizeGuidTableDisplayed() => Assert.That(productDetailPageVtex.IsSizeGuidTableDisplayed(), "SizeGuidTable is not visible");
		[Test]
		public void IsProductSafetyDisplayed() => Assert.That(productDetailPageVtex.IsProductSafetyDisplayed(), "Product safety is not visible");
		// Add to cart modal
		[Test]
		public void AreCartModalDisplayed()
		{
			Assert.Multiple(() =>
			{
				Assert.That(productDetailPageVtex.IsAddToCartClicked(), "Add to cart is not clicked");
				Assert.That(productDetailPageVtex.IsCartModalTitleDisplayed(), "CartModal Title is not clicked");
				Assert.That(productDetailPageVtex.IsCartModalCloseBtnDisplayed(), "CartModal Close button is not clicked");
				Assert.That(productDetailPageVtex.IsCartModalProductImageDisplayed(), "CartModal Image  is not clicked");
				Assert.That(productDetailPageVtex.IsCartModalProductNameDisplayed(), "CartModal Product name is not clicked");
				Assert.That(productDetailPageVtex.IsCartModalSkuNameDisplayed(), "CartModal Product Sku name is not clicked");
				Assert.That(productDetailPageVtex.IsCartModalTotalPriceDisplayed(), "CartModal Total price is not clicked");
				Assert.That(productDetailPageVtex.IsCartModalViewCartDisplayed(), "CartModal view cart is not clicked");
				Assert.That(productDetailPageVtex.IsCartModalCheckoutDisplayed(), "CartModal checkout is not clicked");
			});
		}
		[Test]
		public void AreCartDisplayed()
		{
			Assert.Multiple(() =>
			{
				productDetailPageVtex.IsAddToCartClicked();
				productDetailPageVtex.IsViewCartitoClicked();
				Assert.That(productDetailPageVtex.IsCartDisplayed(), "Cart is not displayed");
				Assert.That(productDetailPageVtex.IsCartTitleDisplayed(), "Cart Title is not displayed");
				Assert.That(productDetailPageVtex.IsCartIndicatorDisplayed(), "Cart indicator is not displayed");
				Assert.That(productDetailPageVtex.IsCartCloseDisplayed(), "Cart close is not displayed");
				Assert.That(productDetailPageVtex.IsCartItemNameDisplayed(), "Cart item name is not displayed");
				Assert.That(productDetailPageVtex.IsCartItemSkuNameDisplayed(), "Cart item SkuName is not displayed");
				Assert.That(productDetailPageVtex.IsCartDeleteItemDisplayed(), "Cart delete item is not displayed");
				Assert.That(productDetailPageVtex.IsCartCounterDisplayed(), "Cart counter is not displayed");
				Assert.That(productDetailPageVtex.IsCartTotalPriceDisplayed(), "Cart total price is not displayed");
				Assert.That(productDetailPageVtex.IsCartSubtotalDisplayed(), "Cart subtotal is not displayed");
				Assert.That(productDetailPageVtex.IsCartCheckOutButtonDisplayed(), "Cart checkout button is not displayed");
			});
		}
	}
}
