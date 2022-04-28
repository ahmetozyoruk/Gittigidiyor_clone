using Firebase.Database;
using Firebase.Database.Query;
using GittiGidiyor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GittiGidiyor.Services.Firebase
{
    public class GirisYapService
    {
        FirebaseClient firebase = new FirebaseClient("https://gittigidiyor-2e746-default-rtdb.firebaseio.com/");
        
        public static GirisYapService _instance;

        public static GirisYapService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GirisYapService();

                return _instance;
            }
        }

        public async Task<List<User>> GetAllUsers()
        {
            return (await firebase
                .Child("User")
                .OnceAsync<User>()).Select(item => new User
                {
                    ID = item.Object.ID,
                    Ad = item.Object.Ad,
                    Email = item.Object.Email,
                    Sifre = item.Object.Sifre,
                    Tel = item.Object.Tel
                }).ToList();
        }

        private async Task<User> GetUserId(int id)
        {
            return (await firebase
                .Child("User")
                .OnceAsync<User>()).Select(item => new User { ID = id }).FirstOrDefault();
        }

        public async Task<User> GetUser(string email, string sifre)
        {

            var allUsers = await GetAllUsers();
            await firebase
                .Child("User")
                .OnceAsync<User>();
            return allUsers.Where(a => (a.Email == email) &&
                                       (a.Sifre == sifre)).FirstOrDefault();
        }
    }
}
