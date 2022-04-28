using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GittiGidiyor.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public String Ad { get; set; }
        public String Tel { get; set; }
        public String Email { get; set; }
        public String Sifre { get; set; }
    }
}
