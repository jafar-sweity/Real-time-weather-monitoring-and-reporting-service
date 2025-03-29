using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService.interfaces;
using WeatherService.models;
using WeatherService.models.Enum;
using WeatherService.services.Bots;

namespace WeatherService.services
{
    public class WeatherFactory : IWeatherBotFactory
    {
        private readonly Dictionary<BotTypes,BotConfiguration> _config;

        public WeatherFactory(Dictionary<BotTypes, BotConfiguration> botConfigurations)
        {
            _config = botConfigurations;
        }

        public IWeatherBot CreateBot(BotTypes botTypes)
        {
            if (!_config.ContainsKey(botTypes))
            {
                throw new ArgumentException("Bot Configuration not found");
            }

            var botConfig = _config[botTypes];

            switch (botTypes)
            {
                case BotTypes.RainBot:
                    return new RainBot(botConfig);
                case BotTypes.SnowBot:
                    return new SnowBot(botConfig);
                case BotTypes.SunBot:
                    return new SunBot(botConfig);
                default:
                    throw new ArgumentException("Invalid Bot Type");
            }
        }
    }
}
