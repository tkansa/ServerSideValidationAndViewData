using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewData.Models;

namespace ViewData.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			// when the user gets to the index, send along an empty password model for them to populate
			return View(new PasswordModel());
		}

		public IActionResult PasswordCheck(PasswordModel pwd)
		{
			// if the passwords don't match, send them back to the index with the error message to try again
			if(pwd.Password != pwd.PasswordConfirmation)
			{
				// this is the syntax to make some view data we are calling errorMessage
				// it is passed along with the view automatically
				// we will also pass a new model for them to try again
				ViewData["errorMessage"] = "Sorry your passwords don't match. Try again.";
				return View("Index", new PasswordModel());
			}
			else
			{
				// otherwise send the user to a success page
				return View("PasswordSuccess", pwd);
			}
			
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
