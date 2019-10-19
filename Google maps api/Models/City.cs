using System;
using System.ComponentModel.DataAnnotations;


namespace Google_maps_api.Models
{
    public class City
    {
        public string Title { get; set; }

        public double Lat { get; set; }

        public double Lng { get; set; }

        public double Oz { get; set;}

        public double NO2  { get; set; }

        public double SO2 { get; set; }

        public double CO2 { get; set; }

    }
}