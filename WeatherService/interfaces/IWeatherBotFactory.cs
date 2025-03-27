using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService.models.Enum;

namespace WeatherService.interfaces
{
    public interface IWeatherBotFactory
    {
        public IWeatherBot CreateBot(BotTypes botTypes);
    }
}
