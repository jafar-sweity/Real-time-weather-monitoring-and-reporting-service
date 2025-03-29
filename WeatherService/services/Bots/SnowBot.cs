using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService.interfaces;
using WeatherService.models;

namespace WeatherService.services.Bots
{
    public class SnowBot : IWeatherBot
    {
        private double _threshold;
        private string _message;

        public SnowBot(BotConfiguration botConfiguration)
        {
            _threshold =  botConfiguration.Threshold;
            _message = botConfiguration.Message;
        }

        public void ActivateBot(WeatherData weatherData)
        {
            if (weatherData.temperature < _threshold)
            {
                Console.WriteLine("SnowBot activated!");
                Console.WriteLine(_message);
            }
        }
    }
}
