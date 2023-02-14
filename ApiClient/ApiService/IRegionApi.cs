using domain.models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Api
{
    public interface IRegionApi
    {
        [Get("/onecall")]
        Task<WeatherDetails> getRegionWeather(double lat, double lon, string units, string exclude, string appid);
    }
}
