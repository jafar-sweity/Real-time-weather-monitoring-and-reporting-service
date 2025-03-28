using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherService.interfaces;
using WeatherService.models.Enum;

namespace WeatherService.services
{
    public class WeatherFactory : IWeatherBotFactory
    {
        public IWeatherBot CreateBot(BotTypes botTypes)
        {
            throw new NotImplementedException();
        }




    }
}
