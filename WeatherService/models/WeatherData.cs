using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherService.models
{
    public class WeatherData
    {
        public string location { get; set; }
        public string temperature { get; set; }
        public string humidity { get; set; }
    }
}
