using WeatherService.models;

namespace WeatherService.interfaces
{
    public interface IWeatherDataConverter
    {
        public WeatherData Convert(string input);
    }
}
