using PRN211_GroupProject.Model;
using PRN211_GroupProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_GroupProject.Service
{
    public class PlayListSongService
    {
        private static PlayListSongService instance;
        private PlayListSongRepository repository;

        private PlayListSongService()
        {
            repository = PlayListSongRepository.gI();
        }

        public static PlayListSongService gI()
        {
            if (instance == null)
            {
                instance = new PlayListSongService();
            }
            return instance;
        }

        public List<PlayListSong> getAllPlayList()
        {
            return repository.findAll();
        }

        public PlayListSong getById(int play_list_id, int song_id)
        {
            return repository.findById(play_list_id, song_id);
        }

        public List<PlayListSong> getByPlayListId(int play_list_id)
        {
            return repository.findByPlayListId(play_list_id);
        }

        public List<PlayListSong> getBySongId(int song_id)
        {
            return repository.findBySongId(song_id);
        }

        public PlayListSong save(PlayListSong playListSong)
        {
            return repository.save(playListSong);
        }

        public void delete(int play_list_id, int song_id)
        {
            repository.deleteSongFromPlayList(play_list_id , song_id);
        }
    }
}
