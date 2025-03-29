using MongoDB.Bson.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WeatherService.interfaces;
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
