using domain.models;
using SQLite;

namespace Data.localDB.Repository
{
    public class WeatherSequenceRepository: ILocalDataRepository<WeathlySequence>
    {
        SQLiteAsyncConnection? Database;

        public WeatherSequenceRepository()
        {
            Task.Run(()=>Init());
        }
        protected async Task Init()
        {

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await Database.CreateTableAsync<WeathlySequence>();
        }

        public async Task<int> InsertItem(WeathlySequence item)
        {
            int nbOfrows = -1;
            if (Database != null)
            {
                nbOfrows = await Database.InsertAsync(item);
            }

            return nbOfrows;
        }

        public Task<bool> Delete()
        {
            throw new NotImplementedException();
        }

        public async Task<WeathlySequence?> GetItem(int id)
        {
            WeathlySequence? result = null;
            if (Database != null)
            {
                result = await Database.Table<WeathlySequence>().Where(t => t.StateId == id).FirstOrDefaultAsync();
            }

            return result;
        }

        public async Task<int> Update(WeathlySequence item)
        {
            var result = -1;
            if (Database != null)
            {
                result = await Database.UpdateAsync(item);
                
            }
            return result;
        }
    }
}
