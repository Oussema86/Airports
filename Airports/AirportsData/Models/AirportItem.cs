using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

namespace AirportsData.Models
{
    [DataContract]
    public class AirportItem
    {
        public AirportItem() { }

        private string countryISO;
        private string countryName;

        [DataMember(Name = "iata")]
        public string Iata { get; set; }

        [DataMember(Name = "lon")]
        public string Longitude { get; set; }

        [DataMember(Name = "iso")]
        public string CountryISO
        {
            get
            {
                return this.countryISO;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.countryISO = value;
                    if (value.Length == 2)
                    {
                        try
                        {
                            RegionInfo regionInfo = new RegionInfo(value);
                            this.countryName = regionInfo?.EnglishName;
                        }
                        catch { }
                    }
                }
            }
        }

        [DataMember]
        public string CountryName
        {
            get
            {
                return this.countryName;
            }
            set
            {
                /* NOTHING */
            }
        }

        [DataMember(Name = "status")]
        public int Status { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "continent")]
        public string Continent { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "lat")]
        public string Latitude { get; set; }

        [DataMember(Name = "size")]
        public string Size { get; set; }
    }
}
