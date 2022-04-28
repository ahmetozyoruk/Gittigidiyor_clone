using System;
using System.Collections.Generic;
using System.Text;

namespace GittiGidiyor.Models
{
    public class Urun
    {
        public string Category { get; set; }
        public string CurrencyCode { get; set; }
        public string DateOfSale { get; set; }
        public double Depth { get; set; }
        public string Description { get; set; }
        public string DimUnit { get; set; }
        public double Height { get; set; }
        public string MainCategory { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ProductId { get; set; }
        public string ProductPicUrl { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public string SupplierName { get; set; }
        public string TaxTarifCode { get; set; }
        public string UoM { get; set; }
        public double WeightMeasure { get; set; }
        public string WeightUnit { get; set; }
        public double Width { get; set; }

        public bool isSepetim { get; set; } = false;
        public bool isSonraAlinacak { get; set; } = false;
    }
}
