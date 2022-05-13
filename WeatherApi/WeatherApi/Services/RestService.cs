using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApi.Models;

namespace WeatherApi.Services
{
    public class RestService : IRestService
    {
        HttpClient client;
        JsonSerializerOptions options;
        WeatherRoot rootModel { get; set; }
        public RestService()
        {
            client = new HttpClient();
            options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };

        }
        public async Task<WeatherRoot> GetWeatherAsync(string city)
        {
            var apiKey = ApiKey.key;

            Uri uri = new Uri($"{Constants.RestUrl}?q={city}&appid={apiKey}&units=metric");
            WeatherRoot weatherData = null;
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    weatherData = JsonConvert.DeserializeObject<WeatherRoot>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }

            return weatherData;

            //return rootModel.entries;
            //return rootModel.Weather;
        }
    }
}
