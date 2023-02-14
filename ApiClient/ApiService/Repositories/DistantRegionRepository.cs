using Data.Api;
using domain.models;
using domain.RemoteRepositories;
using Refit;
using System.Linq.Expressions;

namespace Data.ApiService.Repositories
{
    public class DistantRegionRepository : IDistantRegionRepository
    {

       private IRegionApi? _api;

        public DistantRegionRepository() {

            Init();
        }

        public async Task<WeatherDetails?> getRegionWeatherDetails(double lat, double lng)
        {
            try
            {
                if (_api != null)
                {
                    return await _api.getRegionWeather(lat, lng,"metric", "hourly", "d2f440e516b216616bdd7cd9f0d72e03");

                }
            }
            catch(Exception ex)
            {
                return null;
            }
            return null;
        }

        private void Init()
        {
           _api=  RestService.For<IRegionApi>(BaseApi.BaseUrl);
        }
    }
}
