using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace Femcare.POM
{
    public class TestSettings
    {
        private static TestSettings femcareTestSettings = null;

        #region Main test settings
       
        #endregion

        #region Driver wait settings
        public int FindElementWaitSeconds { get; }
        public int PageLoadWaitSeconds { get; }
        #endregion

        public int EmailCampaignTestsMessageTimeoutSeconds { get; }

        public static string ProjectDirectory => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        private TestSettings(IConfigurationRoot configuration)
        {          
            FindElementWaitSeconds = int.Parse(configuration["findElementWaitSeconds"]);
            PageLoadWaitSeconds = int.Parse(configuration["pageLoadWaitSeconds"]);
        }

        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        public static string CurrentDirectory => Environment.CurrentDirectory;


        public static TestSettings GetTestSettings()
        {
            if (femcareTestSettings == null)
            {
                throw new InvalidOperationException("Test Settings are not created.");
            }
            return femcareTestSettings;
        }

        public static TestSettings GetTestSettings(IConfigurationRoot configuration)
        {
            if (femcareTestSettings != null)
            {
                throw new InvalidOperationException("Test Settings are already created.");
            }

            femcareTestSettings = new TestSettings(configuration);
            return femcareTestSettings;
        }
    }
}
