using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_GroupProject.Model
{
    public class PlayList
    {
        public PlayList() { }

        public PlayList(int id, string name, DateTime createdAt, string description)
        {
            this.id = id;
            this.name = name;
            this.createdAt = createdAt;
            this.description = description;
        }

        public int id { get; set; }
        public string name { get; set; }
        public DateTime createdAt { get; set; }
        public string description { get; set; }
        public string username { get; set; }
    }
}
