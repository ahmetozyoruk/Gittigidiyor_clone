using System;
using System.Collections.Generic;
using System.Text;

namespace GittiGidiyor.Models
{
    public class SepetimItem
    {
        public int Adet { get; set; }
        public string UrunAd { get; set; }
        public string UrunResim { get; set; }
        public string SaticiFirma { get; set; }
        public decimal Ucret { get; set; }
        public int Indirim { get; set; }
    }
}
