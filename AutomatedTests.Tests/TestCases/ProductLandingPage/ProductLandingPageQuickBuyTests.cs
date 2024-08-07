using AutomatedTest.POM.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTests.Tests.TestCases
{
	[Category("Product Landing Page Quick Buy")]
	[TestFixtureSource(typeof(TestData), nameof(TestData.ProductLandingPageQuickBuy))]
	[Parallelizable]
	public class ProductLandingPageQuickBuyTests(string websiteUrl) : BaseTest
	{
		private ProductLandingPage productLandingPageQuickBuy;

		[SetUp]
		public void NavigateToHomePage()
		{
			if (productLandingPageQuickBuy == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				productLandingPageQuickBuy = new ProductLandingPage(Browser, websiteUrl);
			}
		}
		[Test]
		public void IsProductInPcpDisplayed() => Assert.That(productLandingPageQuickBuy.IsProductInPcpDisplayed(), "Product is not visible");
		[Test]
		public void IsModalDisplayed()
		{
			Assert.Multiple(() =>
			{
				productLandingPageQuickBuy.IsProductInPcpHoveredAndClicked();
				productLandingPageQuickBuy.IsClicked();
				Thread.Sleep(1000);
				Assert.That(productLandingPageQuickBuy.IsQuickBuyModalDisplayed(), "Modal is not displayed");
				Assert.That(productLandingPageQuickBuy.IsModalTitleDisplayed(), "Modal Title is not displayed");
				Assert.That(productLandingPageQuickBuy.IsModalOldPriceWebElement(), "Modal Old price is not displayed");
				Assert.That(productLandingPageQuickBuy.IsModalNewPriceWebElement(), "Modal New price is not displayed");
				Assert.That(productLandingPageQuickBuy.IsModalRatingsWebElement(), "Modal ratings is not displayed");
				Assert.That(productLandingPageQuickBuy.IsModalSizeGuideWebElement(), "Modal size guide is not displayed");
				Assert.That(productLandingPageQuickBuy.IsModalAddToCartCounterWebElement(), "Modal Add to cart counter is not displayed");
				Assert.That(productLandingPageQuickBuy.IsModalAddToCartButtonWebElement(), "Modal Add to cart button is not displayed");
				Assert.That(productLandingPageQuickBuy.IsModalViewProductButtonWebElement(), "Modal view product button is not displayed");
			});
		}
	}
}
