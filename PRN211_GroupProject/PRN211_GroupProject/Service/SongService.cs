using PRN211_GroupProject.Model;
using PRN211_GroupProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_GroupProject.Service
{
    public class SongService
    {
        private static SongService instance;
        private SongRepository repository;

        private SongService()
        {
            repository = SongRepository.gI();
        }

        public static SongService gI()
        {
            if (instance == null)
            {
                instance = new SongService();
            }
            return instance;
        }

        public List<Song> getALlSong()
        {
            return repository.findAll();
        }

        public Song getById(int id)
        {
            return repository.findById(id);
        }
        public List<Song> searchSong(string keyword)
        {
            return repository.findByKeyword(keyword);
        }

        public Song save(Song song)
        {
            return repository.save(song);
        }

        public void update(Song song)
        {
            repository.update(song);
        }
    }
}
