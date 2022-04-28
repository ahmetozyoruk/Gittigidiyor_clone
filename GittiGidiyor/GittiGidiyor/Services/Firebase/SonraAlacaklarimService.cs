using Firebase.Database;
using Firebase.Database.Query;
using GittiGidiyor.Models;
using GittiGidiyor.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GittiGidiyor.Services.Firebase
{
    public class SonraAlacaklarimService
    {

        public static SonraAlacaklarimService _instance;

        public static SonraAlacaklarimService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SonraAlacaklarimService();

                return _instance;
            }
        }
        public async Task<List<Urun>> GetAllSonraAlinacaklar()
        {

            var receivedUrunler = UrunService.Urunler;
            var result = (from u in receivedUrunler
                          where u.isSonraAlinacak == true
                          select u);
            List<Urun> SonraAlinacaklar = (List<Urun>)result.ToList();
            if (SonraAlinacaklar.Count == 0)
            {
                SonraAlinacaklar = new List<Urun>();
            }
            
            return SonraAlinacaklar;
        }

        public void SilSonraAlinacaklar(string id)
        {
            if (UrunService.Urunler.Count != 0)
            {
                var receivedUrunler = UrunService.Urunler;
                var result = (from u in receivedUrunler
                              where u.isSonraAlinacak == true && u.ProductId.Contains(id)
                              select u);
                Urun urun = result.FirstOrDefault();
                urun.isSonraAlinacak = false;
            }
        }
        public void SepeteEkle(string id)
        {
            if(UrunService.Urunler.Count !=0)
            {
                var receivedUrunler = UrunService.Urunler;
                var result = (from u in receivedUrunler
                              where u.isSonraAlinacak == true && u.ProductId.Contains(id)
                              select u);
                Urun urun = result.FirstOrDefault();
                urun.isSonraAlinacak = false;
                urun.isSepetim = true;
            }
        }
    }
}
