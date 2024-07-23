using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AutomatedTests.Tests
{
	public class JsonReader
	{
		public static string jsonPath = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
		public static string json = File.ReadAllText(jsonPath);

		public string Home { get; set; }
		public string ContactUs { get; set; }
		public string PeriodTracker { get; set; }
		public string ExpertAdvice { get; set; }
		public string ProductCategoryPage { get; set; }
		public string ProductLandingPage { get; set; }
		public string ProductDetailPage { get; set; }
		public string PromotionForm { get; set; }
		public string AskTheExpert { get; set; }

		public static void ReadJson()
		{
			string jsonPath = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
			var json = File.ReadAllText(jsonPath);
			

			//var model = JsonSerializer.Deserialize
		}
		

	}
}
