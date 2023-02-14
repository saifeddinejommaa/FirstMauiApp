using domain.LocalDataRepositories;
using domain.models;
using SQLite;

namespace Data.localDB.Repository
{
    public class RegionRepository : IRegionRepository
    {
        SQLiteAsyncConnection? Database;


        public RegionRepository()
        {
            Task.Run(() => Init());
        }
        protected async Task Init()
        {

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await Database.CreateTableAsync<Region>();
        }

        public async Task<int> InsertItem(Region region)
        {
            var nbOfrows = -1;
            if (Database != null)
            {
                 nbOfrows = await Database.InsertAsync(region);
            }
            return nbOfrows;
        }

        public async Task<int> UpdateRegion(Region region)
        {
            if (Database != null)
            {
                return await Database.UpdateAsync(region);
            }
            return -1;
        }

        public Task<bool> DeleteRegion(int regionId)
        {
            throw new NotImplementedException();
        }

        public async Task<Region?> GetRegionById(int id)
        {
            
            if (Database != null)
            {
                return await Database.Table<Region>().Where(t => t.Id == id).FirstOrDefaultAsync();
            }

            return null;
        }

        public async Task<List<Region>?> GetAllRegions()
        {
            if (Database != null)
            {
                return await Database.Table<Region>().ToListAsync();
            }

            return null;
        }
    }
}
