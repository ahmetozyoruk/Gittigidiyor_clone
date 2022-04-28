using Firebase.Database;
using Firebase.Database.Query;
using GittiGidiyor.Models;
using GittiGidiyor.Services.Firebase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GittiGidiyor.ViewModels
{
    public class GirisYapViewModel
    {
        GirisYapService girisYapService = new GirisYapService();

        public async Task<User> GetUser(string entryKullanici, string entrySifre)
        {
            return await girisYapService.GetUser(entryKullanici, entrySifre);
        }
    }
}
