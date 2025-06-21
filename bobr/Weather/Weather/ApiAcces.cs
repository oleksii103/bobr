using System;
using System.Collections.Generic;
using System.Configuration.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Weather
{
    internal class ApiAcces
    {
        private const string Key = "258d620f8224435cb0961215252106";
        private const string URL = "http://api.weatherapi.com/v1/current.json";

        public async Task<WeatherInfo> GetDate(string city)
        {
            HttpClient client = new HttpClient() { BaseAddress = new Uri(URL) };
            using HttpResponseMessage response = await client.GetAsync($"?key={Key}&q={city}&aqi=yes");

            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            Root a = JsonConvert.DeserializeObject<Root>(jsonResponse);

            return a.current;
        }
        public async Task<Stream> GetPicture(string pictureURL) 
        {
            HttpClient client = new HttpClient();
            var Potik = await client.GetStreamAsync("https:" + pictureURL);
            return Potik;
        }


    }
}
