using System.Text.Json;
using WeatherService.models;
using WeatherService.models.Enum;

namespace WeatherService.services
{
    public static class BotConfigurationLoader
    {
        public static Dictionary<BotTypes, BotConfiguration> LoadFromFile(string path)
        {
            var json = File.ReadAllText(path);
            var config = JsonSerializer.Deserialize<Dictionary<string, BotConfiguration>>(json);
            var result = new Dictionary<BotTypes, BotConfiguration>();

            foreach (var item in config)
            {
                if (Enum.TryParse(item.Key, out BotTypes botType))
                {
                    result[botType] = item.Value;
                }
            }

            return result;
        }
    }
}
