using AirportsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportsData
{
    interface IAirportDataRetriever
    {
        Task<IQueryable<AirportItem>> GetAirports();
    }
}
