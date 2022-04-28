using GittiGidiyor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GittiGidiyor.Services
{
    public class KategoriService
    {
        public static KategoriService _instance;

        public static KategoriService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new KategoriService();

                return _instance;
            }
        }

        public List<Kategori> GetKategori()
        {
            return new List<Kategori>
            {
                new Kategori{ Name="Telefon"},
                new Kategori{ Name="Masa"},
                new Kategori{ Name="Televizyon"},
            };
        }

    }
}
