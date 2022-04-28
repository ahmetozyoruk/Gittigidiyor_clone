using Firebase.Database;
using Firebase.Database.Query;
using GittiGidiyor.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GittiGidiyor.Services.Firebase
{
    public class UyeOlService
    {
        FirebaseClient firebase = new FirebaseClient("https://gittigidiyor-2e746-default-rtdb.firebaseio.com/");

        public static UyeOlService _instance;

        public static UyeOlService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UyeOlService();

                return _instance;
            }
        }
        static int id = -1;
        public async Task AddUser( string ad, string tel, string email, string sifre)
        {
            id++;
            await firebase
                .Child("User")
                .PostAsync(new User() { ID = id, Ad = ad, Email = email, Sifre = sifre, Tel = tel });
        }
    }
}
