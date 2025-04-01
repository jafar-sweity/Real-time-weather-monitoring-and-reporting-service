using WeatherService.interfaces;
using WeatherService.models;

namespace WeatherService.services.Bots
{
    public class RainBot : IWeatherBot
    {
        private double _threshold;
        private string _message;

        public RainBot(BotConfiguration botConfiguration)
        {
            _threshold = botConfiguration.Threshold;
            _message = botConfiguration.Message;
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
