using GittiGidiyor.Models;
using GittiGidiyor.Services.Firebase.FireBaseConnect;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GittiGidiyor.Services
{
    public class UrunService
    {
        public static UrunService _instance;

        public static UrunService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UrunService();

                return _instance;
            }
        }

        public UrunService()
        {
            //GetUrunlerAsync();
        }

        public static List<Urun> Urunler = new List<Urun>();

        public List<Urun> GetUrunlerAsync()
        {
            if (!(Urunler.Count > 1))
            {
                FirebaseDB firebaseDB = new FirebaseDB("https://gittigidiyor-2e746-default-rtdb.firebaseio.com/-MaFhVtN1IViIcVXHiIs/ProductCollection");
                FirebaseResponse getResponse = firebaseDB.Get();
                var result = JsonConvert.DeserializeObject<List<Urun>>(getResponse.JSONContent);
                Urunler.AddRange(result);
            }
            return Urunler;
        }

        public List<Urun> GetUrunlerFilterIda(string name)
        {
            var result = (from u in Urunler
                          where u.Name.Contains(name)
                          select u);
            List<Urun> FilterUrunler = (List<Urun>)result.ToList();
            if (FilterUrunler.Count == 0)
            {
                FilterUrunler = new List<Urun>();
            }

            return FilterUrunler;
        }

        public List<string> GetUrunlerFiltername(string name)
      {
            var result = (from u in Urunler
                          where u.Name.Contains(name)
                          select u.Name);
            List<string> FilterUrunler = (List<string>)result.ToList();
            if (FilterUrunler.Count == 0)
            {
                FilterUrunler = new List<string>();
            }

            return FilterUrunler;
        }
        public List<string> GetNamesUruns()
        {
            List<string> Filterednames = new List<string>() ;
            Filterednames.AddRange((List<string>)Urunler.Select((item) => item.Name));
            return Filterednames;
        }
    }
}
