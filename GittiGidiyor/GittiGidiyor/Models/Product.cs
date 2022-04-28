using System;
using System.Collections.Generic;
using System.Text;

namespace GittiGidiyor.Models
{
    public class Product
    {
        public int ID { get; set; }
        public double Fiyat { get; set; }
        public string UrunImage { get; set; }
        public string Aciklama { get; set; }
        public string Ad { get; set; }
        public int CategoriID { get; set; }
        public int BrandID { get; set; }
        public bool IsSonraAlinacak { get; set; } = false;
        public bool IsSepetim { get; set; } = false;
    }
}
