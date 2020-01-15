using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Airports.Models;
using AirportsData;
using Airports.Models.Home;
using AirportsData.Models;
using OfficeOpenXml;
using NonFactors.Mvc.Grid;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Airports.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            HomeModel homeModel = new HomeModel();
            return View(homeModel);
        }

        [HttpGet]
        public ViewResult Distance()
        {
            HomeModel homeModel = new HomeModel();
            return View("Distance", homeModel);
        }

        [HttpGet]
        public ViewResult CalculateDistance(string principal, string target)
        {
            HomeModel homeModel = new HomeModel() { Principal = principal, Target = target };

            return View("Distance", homeModel);
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
