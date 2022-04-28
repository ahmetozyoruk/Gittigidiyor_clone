using GittiGidiyor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GittiGidiyor.Services
{
    class SepetimService
    {
        public static SepetimService _instance;

        public static SepetimService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SepetimService();

                return _instance;
            }
        }

        public async Task<List<Urun>> GetSepet()
        {

            var receivedUrunler = UrunService.Urunler;
            var result = (from u in receivedUrunler
                          where u.isSepetim == true
                          select u);
            List<Urun> sepet = (List<Urun>)result.ToList();
            if (sepet.Count == 0)
            {
                sepet = new List<Urun>();
            }

            return sepet;
        }

        public void SilSepetAll()
        {
            if (UrunService.Urunler.Count != 0)
            {
                var receivedUrunler = UrunService.Urunler;
                var result = (from u in receivedUrunler
                              where u.isSepetim == true
                              select u);
                List<Urun> urunler = result.ToList();
                foreach (var urun in urunler)
                {
                    urun.isSepetim = false;
                }
            }
        }

        public void SilSepet(string id)
        {
            if (UrunService.Urunler.Count != 0)
            {
                var receivedUrunler = UrunService.Urunler;
                var result = (from u in receivedUrunler
                              where u.isSepetim == true && u.ProductId.Contains(id)
                              select u);
                Urun urun = result.FirstOrDefault();
                urun.isSepetim = false;
            }
        }
        public void EkleSonraAlacaklar(string id)
        {
            if (UrunService.Urunler.Count != 0)
            {
                var receivedUrunler = UrunService.Urunler;
                var result = (from u in receivedUrunler
                              where u.isSepetim == true && u.ProductId.Contains(id)
                              select u);
                Urun urun = result.FirstOrDefault();
                urun.isSepetim = false;
                urun.isSonraAlinacak = true;
            }
        }
    }
}
