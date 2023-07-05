using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_GroupProject.Model
{
    public class User
    {
        public User(string username, string password, string fullName, bool gender, DateTime createdAt)
        {
            this.username = username;
            this.password = password;
            this.fullName = fullName;
            this.gender = gender;
            this.createdAt = createdAt;
        }

        public string username { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
        public bool gender { get; set; }

        public DateTime createdAt { get; set; }

    }
}
