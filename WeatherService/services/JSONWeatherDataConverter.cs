using System.Text.Json;
using WeatherService.interfaces;
using WeatherService.models;

namespace WeatherService.services
{
    class JSONWeatherDataConverter : IWeatherDataConverter
    {
        public WeatherData Convert(string input)
        {
            try
            {
                return System.Text.Json.JsonSerializer.Deserialize<WeatherData>(input);
            }
            catch (JsonException e)
            {
                Console.WriteLine($"Error converting JSON to WeatherData: {e.Message}");
                return null;
            }
        }
    }
}
