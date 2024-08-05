using AutomatedTest.POM.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTests.Tests.TestCases
{
	[Category("Product Detail Page")]
	[TestFixtureSource(typeof(TestData), nameof(TestData.ProductDetailPageVtex))]
	[Parallelizable]
	public class ProductDetailPageVtexTests(string websiteUrl) : BaseTest
	{
		private ProductDetailPage ProductDetailPageVtex ;

		[SetUp]
		public void NavigateToHomePage()
		{
			if (ProductDetailPageVtex == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				ProductDetailPageVtex = new ProductDetailPage(Browser, websiteUrl);
			}
		}
		[Test]
		public void AreProductHeaderInfoDisplayed()
		{
			Assert.Multiple(() =>
			{
				Assert.That(ProductDetailPageVtex.IsBreadcrumbsDisplayed(), "Breadcrumbs is not visible");
				Assert.That(ProductDetailPageVtex.IsTitleOfProductDisplayed(), "Ttile is not visible");
			});
		}				
		[Test]
		public void AreProductInfoDisplayed()
		{
			Assert.Multiple(() =>
			{
				Assert.That(ProductDetailPageVtex.IsFlowMeterDisplayed(), "Flow meter is not visible");
				Assert.That(ProductDetailPageVtex.IsRatingStarsDisplayed(), "Rating stars are not visible");
				Assert.That(ProductDetailPageVtex.IsNumOfRatingDisplayed(), "Number of ratings are not visible");
				Assert.That(ProductDetailPageVtex.IsPriceDisplayed(), "Price is not visible");
			});
		}
		[Test]
		public void IsProductDescriptionDisplayed() => Assert.That(ProductDetailPageVtex.IsProductDescriptionDisplayed(), "Product description is not visible");
		[Test]
		public void AreProductOptionsDisplayed()
		{
			Assert.Multiple(() =>
			{
				Assert.That(ProductDetailPageVtex.IsProductOptionsDisplayed(), "Product option are not visible");
				Assert.That(ProductDetailPageVtex.AreSizeCardsDisplayed(), "Size option are not visible");
				Assert.That(ProductDetailPageVtex.IsColorPickerDisplayed(), "Color picker are not visible");
			});
		}
		[Test]
		public void AreAddToCartButtonIsVisible() => Assert.That(ProductDetailPageVtex.IsAddToCartButtonDisplayed(), "Add to cart button is not visible");
		[Test]
		public void AreAddToCartCounterIsVisible() => Assert.That(ProductDetailPageVtex.IsAddToCartCounterDisplayed(), "Add to cart counter is not visible");
		[Test]
		public void IsSizeGuidTableDisplayed() => Assert.That(ProductDetailPageVtex.IsSizeGuidTableDisplayed(), "SizeGuidTable is not visible");
		[Test]
		public void IsProductSafetyDisplayed() => Assert.That(ProductDetailPageVtex.IsProductSafetyDisplayed(), "Product safety is not visible");
		// Add to cart modal
		[Test]
		public void AreCartModalDisplayed()
		{
			Assert.Multiple(() =>
			{
				Assert.That(ProductDetailPageVtex.IsAddToCartClicked(), "Add to cart is not clicked");
				Assert.That(ProductDetailPageVtex.IsCartModalTitleDisplayed(), "CartModal Title is not clicked");
				Assert.That(ProductDetailPageVtex.IsCartModalCloseBtnDisplayed(), "CartModal Close button is not clicked");
				Assert.That(ProductDetailPageVtex.IsCartModalProductImageDisplayed(), "CartModal Image  is not clicked");
				Assert.That(ProductDetailPageVtex.IsCartModalProductNameDisplayed(), "CartModal Product name is not clicked");
				Assert.That(ProductDetailPageVtex.IsCartModalSkuNameDisplayed(), "CartModal Product Sku name is not clicked");
				Assert.That(ProductDetailPageVtex.IsCartModalTotalPriceDisplayed(), "CartModal Total price is not clicked");
				Assert.That(ProductDetailPageVtex.IsCartModalViewCartDisplayed(), "CartModal view cart is not clicked");
				Assert.That(ProductDetailPageVtex.IsCartModalCheckoutDisplayed(), "CartModal checkout is not clicked");
			});
		}
	}
}
