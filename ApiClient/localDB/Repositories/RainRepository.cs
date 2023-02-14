using domain.models;
using SQLite;

namespace Data.localDB.Repository
{
    public class RainRepository : ILocalDataRepository<Rain>
    {
        SQLiteAsyncConnection Database;


        public static async Task<RainRepository> createIntance()
        {
            RainRepository rainRepository = new RainRepository();
            await rainRepository.Init();
            return rainRepository;
        }
        protected async Task Init()
        {

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await Database.CreateTableAsync<Rain>();
        }

        public async Task<int> InsertItem(Rain item)
        {

            int nbOfrows = await Database.InsertAsync(item);

            return nbOfrows;
        }

        public Task<bool> Delete()
        {
            throw new NotImplementedException();
        }

        public async Task<Rain> GetItem(int id)
        {
            return await Database.Table<Rain>().Where(t => t.StateId == id).FirstOrDefaultAsync();
        }

        public async Task<int> Update(Rain item)
        {
            return await Database.UpdateAsync(item);
        }
    }
}


