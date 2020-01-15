using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airports.Models.Home
{
    public class HomeFilterModel
    {
        public string CodeIATA { get; set; }

        public string AirportName { get; set; }

        public string AirportCountry { get; set; }

        public string Size { get; set; }

        public int Status { get; set; }
    }
}
