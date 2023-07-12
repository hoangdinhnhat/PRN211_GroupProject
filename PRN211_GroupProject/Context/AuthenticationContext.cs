using PRN211_GroupProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_GroupProject.Context
{
    public class AuthenticationContext
    {
        private static AuthenticationContext instance;
        private User authenticatedUser;

        private AuthenticationContext() { }

        public static AuthenticationContext gI()
        {
            if (instance == null)
            {
                instance = new AuthenticationContext();
            }
            return instance;
        }

        public void setUser(User user)
        {
            authenticatedUser = user;
        }

        public User getUser()
        {
            return authenticatedUser;
        }
    }
}
