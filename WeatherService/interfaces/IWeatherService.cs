namespace WeatherService.interfaces
{
    public interface IWeatherService
    {
        public void ProcessWeatherData(string input , IWeatherDataConverter converter);
    }
}
