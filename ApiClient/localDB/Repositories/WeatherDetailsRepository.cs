using domain.models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.localDB.Repository
{
    public class WeatherDetailsRepository: ILocalDataRepository<WeatherDetails>
    {
        SQLiteAsyncConnection Database;


        public static async Task<WeatherDetailsRepository> createIntance()
        {
            WeatherDetailsRepository weatherDetailsRepository = new WeatherDetailsRepository();
            await weatherDetailsRepository.Init();
            return weatherDetailsRepository;
        }
        protected async Task Init()
        {

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await Database.CreateTableAsync<WeatherDetails>();
        }

        public async Task<int> InsertItem(WeatherDetails item)
        {

            int nbOfrows = await Database.InsertAsync(item);

            return nbOfrows;
        }

        public Task<bool> Delete()
        {
            throw new NotImplementedException();
        }

        public async Task<WeatherDetails> GetItem(int id)
        {
            return await Database.Table<WeatherDetails>().Where(t => t.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> Update(WeatherDetails item)
        {
            return await Database.UpdateAsync(item);
        }
    }
}
