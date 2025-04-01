using System.Xml.Serialization;
using WeatherService.interfaces;
using WeatherService.models;

namespace WeatherService.services
{
    public class XMLWeatherDataConverter : IWeatherDataConverter
    {
        public WeatherData Convert(string input)
        {
            var serializer = new XmlSerializer(typeof(WeatherData));

            using (var reader = new StringReader(input))
            {
                return (WeatherData)serializer.Deserialize(reader);
            }

        }
    }
}
