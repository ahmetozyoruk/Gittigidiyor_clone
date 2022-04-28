using GittiGidiyor.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GittiGidiyor.Services.SqlDatabase
{
    public class UserSqlDatabase
    {
        readonly SQLiteAsyncConnection database;

        public UserSqlDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();
        }

        //public Task<List<User>> GetUserAsync()
        //{
        //    return database.Table<User>().ToListAsync();
        //}

        public Task<User> GetUserAsync(int id)
        {
            return database.Table<User>()
                .Where(I => I.ID == id)
                .FirstOrDefaultAsync();
        }

        public Task<User> GetUserAsync(string email,string sifre)
        {
            return database.Table<User>()
                .Where(I => I.Email == email && I.Sifre == sifre)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveUserAsync(User user)
        {
            if(user.ID != 0)
            {
                return database.UpdateAsync(user);
            }
            else
            {
                return database.InsertAsync(user);
            }
        }

        public Task<int> DeleteUserAsynC(User user)
        {
            return database.DeleteAsync(user);
        }

    }
}
