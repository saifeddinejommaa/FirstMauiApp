


using domain.LocalDataRepositories;
using domain.models;
using domain.RemoteRepositories;

namespace domain.useCases
{
    public class RegionUseCase
    {
        IRegionRepository _localDBRepo;

        IDistantRegionRepository _distantRepo;
        public RegionUseCase(IRegionRepository localDBRep, IDistantRegionRepository distantRepo) {

            _localDBRepo= localDBRep;
            _distantRepo= distantRepo;
        }

        public async Task<int> insertNewRegion(Region region)
        {
           int result = await  _localDBRepo.InsertItem(region);

            return result;

        }

        public async Task<List<Region>?> getAllRegions()
        {
            List<Region> result =  await _localDBRepo.GetAllRegions();
            return result;
        }

        public async Task<WeatherDetails?> getWeatherDetails(double lat, double lon)
        {
            return await _distantRepo.getRegionWeatherDetails(lat, lon);
        }

        public async Task<Region?> GetRegionById(int id)
        {
            return await _localDBRepo.GetRegionById(id);
        }


    }
}
