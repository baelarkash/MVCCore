using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCore.Models;
using Newtonsoft.Json;
using MVCCore.EF;

namespace MVCCore.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{

			using (StreamReader r = new StreamReader("JSON/set01.json"))
			{
				string json = r.ReadToEnd();
				Models.Rootobject item= JsonConvert.DeserializeObject<Rootobject>(json);
			}
			//MVCCore.Utilities.DBSetUp.createDefaultLanguages();
			return View();
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
