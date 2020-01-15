using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AirportsData.Models;
using Newtonsoft.Json;

namespace AirportsData
{
    public class AirportDataRetriever : IAirportDataRetriever
    {
        string clientURL = "https://raw.githubusercontent.com/jbrooksuk/JSON-Airports/master/airports.json";

        public async Task<IQueryable<AirportItem>> GetAirports()
        {
            var euAirports = await GetEuropeanAirports();
            return euAirports.OrderBy(d => d.Iata).AsQueryable();
        }

        private async Task<IQueryable<AirportItem>> GetEuropeanAirports()
        {
            var allAirports = await GetAllAirports();
            if (allAirports != null && allAirports.Any())
            {
                return allAirports.Where(x => x.Continent.Equals("EU", StringComparison.OrdinalIgnoreCase)).AsQueryable();
            }

            return Enumerable.Empty<AirportItem>().AsQueryable();
        }

        private async Task<IEnumerable<AirportItem>> GetAllAirports()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("name", "form-feed");

                var content = await client.GetStringAsync(clientURL);
                return JsonConvert.DeserializeObject<IEnumerable<AirportItem>>(content);
            }
        }
    }
}
