using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService.interfaces;
using WeatherService.models;

namespace WeatherService.services.Bots
{
    public class RainBot : IWeatherBot
    {
        private double _threshold;
        private string _message;

        public RainBot(double threshold, string message)
        {
            _threshold = threshold;
            _message = message;
        }

        public void ActivateBot(WeatherData weatherData)
        {
            if (weatherData.humidity > _threshold)
            {
                Console.WriteLine("RainBot activated!");
                Console.WriteLine(_message);
            }
        }
    }
}
