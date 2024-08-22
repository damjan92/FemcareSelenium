using AutomatedTests.Common.Enums;
using AutomatedTest.POM;
using AutomatedTests.Framework.Core;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using AutomatedTest.POM.PageObjects;

namespace AutomatedTests.Tests.TestCases
{
    public abstract class BaseTest
    {
        protected string Environment;
        protected TestSettings Settings;
        protected BrowserSettings BrowserSettings;

        protected Browser Browser;

        [OneTimeSetUp]
        public virtual void Setup()
        { 
            Environment = TestContext.Parameters.Get("Environment") ?? EnvironmentType.Staging.ToString();
            BrowserSettings = new BrowserSettings(BrowserType.Chrome, string.Empty);

            IConfigurationBuilder builder = new ConfigurationBuilder()
                    .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"))
                    .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), $"appsettings.{Environment}.json"));

            var configuration = builder.Build();

            Settings = TestSettings.GetTestSettings(configuration);

            SetUpBrowser();
        }

        private void SetUpBrowser()
        {
            Browser = new Browser(BrowserSettings);
        }     

        [OneTimeTearDown]
        public virtual void ShutDown()
        {
            Browser.Quit();
        }

        protected virtual TPage NavigateToPage<TPage>(TPage page, string websiteUrl) where TPage : BasePage
        {
            if (page is null || !Browser.BrowserDriver.Url.EndsWith(websiteUrl))
            {
                if (Activator.CreateInstance(typeof(TPage), Browser, websiteUrl) is not TPage newPage) throw new NullReferenceException();

                return newPage;
            }

            return page;
        }
    }
}
