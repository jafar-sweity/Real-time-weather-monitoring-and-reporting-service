using WeatherService.interfaces;
using WeatherService.models;

namespace WeatherService.services.Bots
{
    public class SunBot : IWeatherBot
    {
        private double _threshold;
        private string _message;

        public SunBot(BotConfiguration botConfiguration)
        {
            _threshold = botConfiguration.Threshold;
            _message = botConfiguration.Message;
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
