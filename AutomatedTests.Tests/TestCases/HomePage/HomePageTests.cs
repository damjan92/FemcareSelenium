using AutomatedTests.Tests.TestData;
using Femcare.POM.PageObjects;
using Femcare.Selenium.Framework.Core;
using NUnit.Framework;

namespace Femcare.Selenium.Tests.TestCases
{
    [TestFixtureSource(typeof(TestData), nameof(TestData.WebsiteUrls))]
    [Parallelizable]
    public class HomePageTests(string websiteUrl) : BaseTest
    {
        private HomePage homePage;

        [SetUp]
        public void NavigateToHomePage()
        {
            if (homePage == null || (!Browser.BrowserDriver.Url.EndsWith("")))
            {
                homePage = new HomePage(Browser, websiteUrl);
            }
        }

        [Test]
        public void Test_01_IsNavigationBarLoaded()
        {
            Assert.That(homePage.IsNavigationBarLoaded(), "Navigation bar is not loaded!");
        }
		[Test]
		public void Test_02_ErrorMessage()
		{
			Assert.That(homePage.IsErrorMessageDisplayed(), Is.False, "Navigation bar is loaded!");
		}		
		[Test]
		public void Test_04_IsSearchIconDisplayed()
		{
			Assert.That(homePage.IsSearchIconDisplayed(), "Search is not loaded!");
		}
		[Test]
		public void Test_05_IsEssityFooterLogoDisplayed()
		{
			Assert.That(homePage.IsEssityFooterLogoDisplayed(), "Essity Footer Logo is not loaded!");
		}
	}
}
