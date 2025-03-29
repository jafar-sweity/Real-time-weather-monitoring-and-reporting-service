using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService.interfaces
{
    public interface IWeatherService
    {
        public void ProcessWeatherData(string input , IWeatherDataConverter converter);
    }
}
