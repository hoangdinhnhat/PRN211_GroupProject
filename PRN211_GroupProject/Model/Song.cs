using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_GroupProject.Model
{
    public class Song
    {
        public Song() { }

        public Song(int id, string name, string singer, int YOP, string path)
        {
            this.id = id;
            this.name = name;
            this.singer = singer;
            this.YOP = YOP;
            this.path = path;
        }

        public int id { get; set; }
        public string name { get; set; }
        public string singer { get; set; }
        public int YOP { get; set; }
        public string path { get; set; }
    }
}
