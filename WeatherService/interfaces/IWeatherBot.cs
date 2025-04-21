using WeatherService.models;

namespace WeatherService.interfaces
{
    public interface IWeatherBot
    {
        public void ActivateBot(WeatherData weatherData);
    }
}
