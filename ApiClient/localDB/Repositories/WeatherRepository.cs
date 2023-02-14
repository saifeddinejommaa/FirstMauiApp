using domain.models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.localDB.Repository
{
    public class WeatherRepository : ILocalDataRepository<Weather>
    {
        SQLiteAsyncConnection Database;


        public static async Task<WeatherRepository> createIntance()
        {
            WeatherRepository weatherRepository = new WeatherRepository();
            await weatherRepository.Init();
            return weatherRepository;
        }
        protected async Task Init()
        {

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await Database.CreateTableAsync<Weather>();
        }

        public async Task<int> InsertItem(Weather item)
        {

            int nbOfrows = await Database.InsertAsync(item);

            return nbOfrows;
        }

        public Task<bool> Delete()
        {
            throw new NotImplementedException();
        }

        public async Task<Weather> GetItem(int id)
        {
            return await Database.Table<Weather>().Where(t => t.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> Update(Weather item)
        {
            return await Database.UpdateAsync(item);
        }
    }
}






