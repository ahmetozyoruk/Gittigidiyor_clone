using System;
using System.Collections.Generic;
using System.Text;

namespace GittiGidiyor.Models
{
    public class ShoppingCart
    {
        public int ID { get; set; }
        public decimal ToplamUcret { get; set; }
        public int ToplamSayi { get; set; }
        public decimal KargoUcret { get; set; }
        public int DiscountID { get; set; }
    }
}
