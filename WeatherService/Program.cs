using WeatherService.interfaces;
using WeatherService.services;
using WeatherService.Utilities;

public class Program
{
    public static void Main()
    {
        var filepath = @"C:\Users\asus\source\repos\WeatherService\WeatherService\botconfig.json";
        var botConfig = BotConfigurationLoader.LoadFromFile(filepath);
        var factory = new WeatherFactory(botConfig);
        var bots = botConfig.Keys.Where(botType => botConfig[botType].Enabled).Select(factory.CreateBot).ToList();

        var weatherServices = new WeatherServices(bots);
        var jsonConverter = new JSONWeatherDataConverter();
        var xmlConverter = new XMLWeatherDataConverter();
        var menu = new ShowMainMenu(weatherServices, jsonConverter, xmlConverter);
        menu.ShowMenu();

    }
}