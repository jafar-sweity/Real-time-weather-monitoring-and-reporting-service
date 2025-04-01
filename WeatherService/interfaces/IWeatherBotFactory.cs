using WeatherService.models.Enum;

namespace WeatherService.interfaces
{
    public interface IWeatherBotFactory
    {
        public IWeatherBot CreateBot(BotTypes botTypes);
    }
}
