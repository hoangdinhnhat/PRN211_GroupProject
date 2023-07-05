using PRN211_GroupProject.Model;
using PRN211_GroupProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_GroupProject.Service
{
    public class PlayListService
    {
        private static PlayListService instance;
        private PlayListRepository repository;

        private PlayListService()
        {
            repository = PlayListRepository.gI();
        }

        public static PlayListService gI()
        {
            if (instance == null)
            {
                instance = new PlayListService();
            }
            return instance;
        }

        public List<PlayList> getAllPlayList()
        {
            return repository.findAll();
        }

        public PlayList getById(int id)
        {
            return repository.findById(id);
        }

        public PlayList save(PlayList playList)
        {
            return repository.save(playList);
        }

        public void update(PlayList playList)
        {
            repository.update(playList);
        }

        public void delete(int id) {
            repository.delete(id);
        }
    }
}
