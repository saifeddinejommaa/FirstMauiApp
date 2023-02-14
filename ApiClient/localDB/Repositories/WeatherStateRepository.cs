using domain.models;
using SQLite;

namespace Data.localDB.Repository
{
    public class WeatherStateRepository : ILocalDataRepository<WeatherState>
    {
        SQLiteAsyncConnection Database;

        public static async Task<WeatherStateRepository> createIntance()
        {
            WeatherStateRepository weatherStateRepository = new WeatherStateRepository();
            await weatherStateRepository.Init();
            return weatherStateRepository;
        }
        protected async Task Init()
        {

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await Database.CreateTableAsync<WeatherState>();
        }
        public async Task<bool> Delete()
        {
            throw new NotImplementedException();
        }

        public async Task<WeatherState> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> InsertItem(WeatherState item)
        {

            int nbOfrows = await Database.InsertAsync(item);

            return nbOfrows;
        }

        public Task<int> Update(WeatherState item)
        {
            throw new NotImplementedException();
        }
    }
}
