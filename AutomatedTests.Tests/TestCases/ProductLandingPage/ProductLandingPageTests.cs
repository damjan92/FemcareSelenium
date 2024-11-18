using AutomatedTest.POM.PageObjects;
using AutomatedTests.Framework.Core;
using NUnit.Framework;

namespace AutomatedTests.Tests.TestCases
{
	[Category("Product Landing Page")]
	[TestFixtureSource(typeof(TestData), nameof(TestData.ProductLandingPageUrls))]
	[Parallelizable]
	public class ProductLandingPageTests(string websiteUrl) : BaseTest
	{
		private ProductLandingPage productLandingPage;

		[SetUp]
		public void NavigateToHomePage()
		{
			if (productLandingPage == null || (!Browser.BrowserDriver.Url.EndsWith("")))
			{
				productLandingPage = new ProductLandingPage(Browser, websiteUrl);
			}
		}
		[Test]
		[Category("ErrorAlert - PLP")]
		public void ErrorMessage() => Assert.That(productLandingPage.IsErrorMessageDisplayed(), Is.False, "Erros message is loaded!");
		[Test]
		public void IsIndicatorDisplayed() => Assert.That(productLandingPage.IsIndicatorDisplayed(), "Indicator is not visible");
		[Test]
		public void IsTitleDisplayed() => Assert.That(productLandingPage.IsTitleDisplayed(), "Title is not dislayed");
		[Test]
		public void IsBreadcrumbsDisplayed() => Assert.That(productLandingPage.IsBreadcrumbsDisplayed(), "Breadcrumbs is not dislayed");
		[Test]
		public void IsFilterByButtonDisplayed() => Assert.That(productLandingPage.IsFilterByButtonDisplayed(), "Filter button is not dislayed");
		[Test]
		public void IsSortButtonDisplayed() => Assert.That(productLandingPage.IsSortButtonDisplayed(), "Filter button is not dislayed");
		[Test]
		public void IsExploreAllProductsDisplayed() => Assert.That(productLandingPage.IsExploreAllProductsDisplayed(), "Explore all products button is not dislayed");		
		[Test]
		public void AreSocialIconsDisplayed() => Assert.That(productLandingPage.IsSocialIconDisplayed(), "Facebook icon is not visible");
		[Test]
		public void IsIndicatorNumberIsCorrect() => 
			Assert.That(productLandingPage.GetIndicatorNumber(), Is.EqualTo(productLandingPage.GetNumberOfProducts()), "The number of displayed products are not the same");
	}
}
