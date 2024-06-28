namespace Femcare.Selenium.Framework.Core
{
    public class BrowserSettings
    {
        public readonly BrowserType BrowserType;
        public readonly string AssemblyDirectory;

        public BrowserSettings(BrowserType browserType, string assemblyDirectory)
        {
            BrowserType = browserType;
            AssemblyDirectory = assemblyDirectory;
        }
    }
}
