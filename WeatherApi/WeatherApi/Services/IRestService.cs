using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApi.Models;

namespace WeatherApi.Services
{
    public interface IRestService
    {
        Task<WeatherRoot> GetWeatherAsync(string city);
    }
}
