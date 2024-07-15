using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeatherApp.Database.Entity
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Temp { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
        public double Wind { get; set; }
        public string Weather { get; set; }
    }
}