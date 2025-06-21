using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal class Root
    {
        public Location location { get; set; }
        public WeatherInfo current { get; set; }
    }

    internal class Location
    {
        public string name { get; set; }
        public string country { get; set; }
        public string localtime { get; set; }
    }

    internal class WeatherInfo
    {
        public double temp_c { get; set; }
        public double temp_f { get; set; }
        public double wind_kph { get; set; }
        public double pressure_mb { get; set; }
        public double cloud { get; set; }
        public double humidity { get; set; }
        public double precip_mm { get; set; }

        public Condition condition {  get; set; }

    }

    internal class Condition
    {
        public string text { get; set; }
        public string icon { get; set; }
        public int code { get; set; }
    }

}