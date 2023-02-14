using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.localDB
{
     interface ILocalDataRepository<T>
    {
      

        abstract Task<int> Update(T item);

        abstract Task<bool> Delete();

        abstract Task<T> GetItem(int id);

        abstract Task<int> InsertItem(T item);

    }
}
