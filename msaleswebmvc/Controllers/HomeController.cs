using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using msaleswebmvc.Models;

namespace msaleswebmvc.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()  //IActionResult - tipo de retorno para todas ações, é uma interface de tipo genérico para todo resultado de alguma ação que se desdobra em vários tipos específicos como: ViewResult, PartialViewResult, ContentResult, entre outros.

		{
			return View();
		}

		public IActionResult About()
		{
			ViewData["Message"] = "MSalles WEB MVC App from C# Course";
			ViewData["Professor"] = "Marcos Cozatti"; 

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
