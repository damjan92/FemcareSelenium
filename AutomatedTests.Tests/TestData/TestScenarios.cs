
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Newtonsoft.Json;

namespace AutomatedTests.Tests
{
	public class TestScenarios
	{
		public static string jsonPath = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
		public static string json = File.ReadAllText(jsonPath);

		public List<string> lines = new List<string>();

		public string Home { get; set; }
		public string ContactUs { get; set; }
		public string PeriodTracker { get; set; }
		public string ExpertAdvice { get; set; }
		public string ProductCategoryPage { get; set; }
		public string ProductLandingPage { get; set; }
		public string ProductDetailPage { get; set; }
		public string PromotionForm { get; set; }
		public string AskTheExpert { get; set; }
	}
}
