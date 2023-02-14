
using domain.models;

namespace domain.RemoteRepositories
{
    public interface IDistantRegionRepository
    {
        public Task<WeatherDetails?> getRegionWeatherDetails(double lat, double lng);
    }
}
