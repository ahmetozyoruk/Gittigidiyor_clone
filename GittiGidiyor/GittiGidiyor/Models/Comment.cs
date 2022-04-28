using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GittiGidiyor.Models
{
    public class Comment
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string ProductId { get; set; }

        public string UserId { get; set; }
        public Dictionary<string, List<string>> Comments { get; set; }
    }
}
