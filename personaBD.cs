using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class personaBD
    {
        readonly SQLiteAsyncConnection _database;

        public personaBD(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<personaModel>().Wait();
        }

        public Task<List<personaModel>> enlistar()
        {
            return _database.Table<personaModel>().ToListAsync();
        }

        public Task<int> SaveSurveyAsync(personaModel persona)
        {
            if (persona.Id != 0)
            {
                return _database.UpdateAsync(persona);
            }
            else
            {
                return _database.InsertAsync(persona);
            }
        }

        public Task<int> Borrar(personaModel persona)
        {
            return _database.DeleteAsync(persona);
        }


    }
}
