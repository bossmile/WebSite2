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
            var card1 = new CardViewModel
            {
                CardName = "Goyf",
                Type = 1,
                GathererUrl = "http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=457123",
                PictureUrl = "https://img.scryfall.com/cards/large/front/4/2/42e56220-81c3-4440-9f97-8616d630a8ee.jpg?1541423404"
            };


            var card2 = new CardViewModel
            {
                CardName = "Wrath of god",
                Type = 2,
                GathererUrl = "http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=429866",
                PictureUrl = "https://img.scryfall.com/cards/large/en/p07/1.jpg?1517813031"
            };

            var card3 = new CardViewModel
            {
                CardName = "Kompanija",
                Type = 3,
                GathererUrl = "http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=394519",
                PictureUrl = "https://pm1.narvii.com/6205/662e4a6714d9020da5a1b3cc55c9213d492d15c4_hq.jpg"
            };

            var card4 = new CardViewModel
            {
                CardName = "Sol Ring",
                Type = 4,
                GathererUrl = "http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=420611",
                PictureUrl = "https://img.scryfall.com/cards/large/en/mps/24.jpg?1517813031",
            };

            var card5 = new CardViewModel
            {
                CardName = "Phyrexian Arena",
                Type = 5,
                GathererUrl = "http://gatherer.wizards.com/Pages/Card/Details.aspx?name=phyrexian%20arena",
                PictureUrl = "https://img.scryfall.com/cards/large/en/cn2/144.jpg?1517813031",
            };

            List<CardViewModel> listaKarataZaNaslovnicu = new List<CardViewModel>();
			listaKarataZaNaslovnicu.Add(card1);
			listaKarataZaNaslovnicu.Add(card2);
			listaKarataZaNaslovnicu.Add(card3);
            listaKarataZaNaslovnicu.Add(card4);
            listaKarataZaNaslovnicu.Add(card5);



			return View(listaKarataZaNaslovnicu);
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Parody page pls dont sue us wizards";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "We r poor plz gibe moni";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

        public IActionResult Commander()
        {
            ViewData["Message"] = "Commander stuffzz";


            return View();
        }

        public IActionResult Extra()
        {
            ViewData["Message"] = "Extra fancy stufffzzz";

            return View();
        }

        public IActionResult Spicy()
        {
            ViewData["Message"] = "Spicy content coming real soon";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
