
using domain.models;

namespace domain.LocalDataRepositories
{
    public interface IRegionRepository
    {
        abstract Task<int> UpdateRegion(Region item);

        abstract Task<bool> DeleteRegion(int regionId);

        abstract Task<Region?> GetRegionById(int id);

        abstract Task<List<Region>?> GetAllRegions();

        abstract Task<int> InsertItem(Region region);


    }
}
