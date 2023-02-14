using SQLite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.localDB
{
    static class Constants
    {
        public const string DatabaseFilename = "TodoSQLite.db3";

        public const SQLiteOpenFlags Flags =
        // open the database in read/write mode
            SQLiteOpenFlags.ReadWrite |
        // create the database if it doesn't exist
            SQLiteOpenFlags.Create |
        // enable multi-threaded database access
            SQLiteOpenFlags.SharedCache;

        public static string DatabasePath =>
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DatabaseFilename);
    }
}
