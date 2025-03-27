using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService.models;

namespace WeatherService.interfaces
{
    public interface IWeatherBot
    {
        public void ActivateBot(WeatherData weatherData);
    }
}
