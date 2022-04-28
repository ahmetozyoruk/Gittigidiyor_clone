using Firebase.Database;
using Firebase.Database.Query;
using GittiGidiyor.Models;
using GittiGidiyor.Services.Firebase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GittiGidiyor.ViewModels
{
    public class UyeOlPageViewModel
    {
        UyeOlService uyeOlService = new UyeOlService();
        public async Task AddUser(string ad, string tel, string email, string sifre)
        {
            await uyeOlService.AddUser(ad, tel, email, sifre);
        }

    }
}
