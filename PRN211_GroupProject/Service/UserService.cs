using PRN211_GroupProject.Model;
using PRN211_GroupProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_GroupProject.Service
{
    public class UserService
    {
        private static UserService instance;
        private UserRepository repository;

        private UserService() {
            repository = UserRepository.gI();
        }

        public static UserService gI()
        {
            if (instance == null)
            {
                instance = new UserService();
            }
            return instance;
        }

        public List<User> getAllUser()
        {
            return repository.findAll();
        }

        public User getByUsername(string username)
        {
            return repository.findById(username);
        }

        public User save(User user)
        {
            return repository.save(user);
        }

        public void update(User user)
        {
            repository.update(user);
        }
    }
}
