using AirportsData;
using AirportsData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airports.Models.Home
{
    public class HomeModel : PageModel
    {
        public HomeModel()
        {
            OnGet();
        }

        public void OnGet()
        {
            AirportDataRetriever service = new AirportDataRetriever();
            AirportsList = service.GetAirports().Result;
        }

        [BindProperty]
        public IQueryable<AirportItem> AirportsList { get; set; }

        public string Principal { get; set; }

        public string Target { get; set; }
    }
}
