using WeatherService.interfaces;
using WeatherService.models;

namespace WeatherService.services
{
    public class WeatherServices : IWeatherService
    {
        private readonly List<IWeatherBot> _bots;

        public WeatherServices(List<IWeatherBot> bots)
        {
            _bots = bots;
        }

        public void ProcessWeatherData(string input, IWeatherDataConverter converter)
        {
            var data = converter.Convert(input);
            NotifyBots(data);
        }

        public void NotifyBots(WeatherData weatherData)
        {
            foreach (var bot in _bots)
            {
                bot.ActivateBot(weatherData);
            }
        }
    }
}
