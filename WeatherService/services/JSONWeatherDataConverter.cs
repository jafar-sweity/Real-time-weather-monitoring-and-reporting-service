using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherService.interfaces;
using WeatherService.models;

namespace WeatherService.services
{
    class JSONWeatherDataConverter : IWeatherDataConverter
    {
        public WeatherData Convert(string input) => JsonSerializer.Deserialize<WeatherData>(input);
    }
}
