using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebSite2.Models;

namespace WebSite2.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			var card1 = new CardViewModel();
			card1.CardName = "Goyf";
			card1.Type = 1;

            var card2 = new CardViewModel
            {
                CardName = "Wrath of god",
                Type = 2
            };

            var card3 = new CardViewModel();
			card3.CardName = "Kompanija";
			card3.Type = 3;

			List<CardViewModel> listaKarataZaNaslovnicu = new List<CardViewModel>();
			listaKarataZaNaslovnicu.Add(card1);
			listaKarataZaNaslovnicu.Add(card2);
			listaKarataZaNaslovnicu.Add(card3);

			return View(listaKarataZaNaslovnicu);
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
