using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService.interfaces;
using WeatherService.models;

namespace WeatherService.services.Bots
{
    public class SunBot : IWeatherBot
    {
        private double _threshold;
        private string _message;

        public SunBot(double threshold, string message)
        {
            _threshold = threshold;
            _message = message;
        }

        public void ActivateBot(WeatherData weatherData)
        {
            if (weatherData.temperature > _threshold)
            {
                Console.WriteLine("SunBot activated!");
                Console.WriteLine(_message);
            }
        }
    }
}
