using Femcare.Common.Enums;
using Femcare.POM;
using Femcare.Selenium.Framework.Core;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace Femcare.Selenium.Tests.TestCases
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
    }
}
