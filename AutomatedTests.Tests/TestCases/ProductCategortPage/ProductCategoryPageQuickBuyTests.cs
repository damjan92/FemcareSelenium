using AutomatedTest.POM.PageObjects;
using NUnit.Framework;

namespace AutomatedTests.Tests.TestCases
{
	[Category("Product Category Page Quick Buy")]
	[TestFixtureSource(typeof(TestData), nameof(TestData.ProductCategoryPageQuickBuy))]
	[Parallelizable]
	public class ProductCategoryPageQuickBuyTests(string websiteUrl) : BaseTest
	{
		private ProductCategoryPage productCategoryPageQuickBuy;

		[SetUp]
		public void NavigateToHomePage()
		{
			if (productCategoryPageQuickBuy == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				productCategoryPageQuickBuy = new ProductCategoryPage(Browser, websiteUrl);
			}
		}
		[Test]
		[Category("ErrorAlert - PCP Quick Buy")]
		public void ErrorMessage() => Assert.That(productCategoryPageQuickBuy.IsErrorMessageDisplayed(), Is.False, "Erros message is loaded!");
		[Test]
		public void IsProductInPcpDisplayed() => Assert.That(productCategoryPageQuickBuy.IsProductInPcpDisplayed(), "Product is not visible");
		[Test]
		public void IsModalDisplayed()
		{
			Assert.Multiple(() =>
			{
				productCategoryPageQuickBuy.IsProductInPcpHoveredAndClicked();
				productCategoryPageQuickBuy.IsClicked();
				Thread.Sleep(1000);
				Assert.That(productCategoryPageQuickBuy.IsQuickBuyModalDisplayed(), "Modal is not displayed");
				Assert.That(productCategoryPageQuickBuy.IsModalTitleDisplayed(), "Modal Title is not displayed");
				//Assert.That(productCategoryPageQuickBuy.IsModalOldPriceWebElement(), "Modal Old price is not displayed");
				Assert.That(productCategoryPageQuickBuy.IsModalNewPriceWebElement(), "Modal New price is not displayed");
				Assert.That(productCategoryPageQuickBuy.IsModalRatingsWebElement(), "Modal ratings is not displayed");
				Assert.That(productCategoryPageQuickBuy.IsModalSizeGuideWebElement(), "Modal size guide is not displayed");
				Assert.That(productCategoryPageQuickBuy.IsModalAddToCartCounterWebElement(), "Modal Add to cart counter is not displayed");
				Assert.That(productCategoryPageQuickBuy.IsModalAddToCartButtonWebElement(), "Modal Add to cart button is not displayed");
				Assert.That(productCategoryPageQuickBuy.IsModalViewProductButtonWebElement(), "Modal view product button is not displayed");
			});
		}
	}
}
