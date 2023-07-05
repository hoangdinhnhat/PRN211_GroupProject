using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_GroupProject.Model
{
    public class PlayListSong
    {
        public PlayListSong() { }

        public PlayListSong(int play_list_id, int song_id) {
            this.play_list_id = play_list_id;
            this.song_id = song_id;
        }

        public int play_list_id { get; set; }
        public int song_id {get; set;}
    }
}
