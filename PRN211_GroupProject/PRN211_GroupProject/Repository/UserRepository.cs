using PRN211_GroupProject.Model;
using PRN211_GroupProject.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_GroupProject.Repository
{
    public class UserRepository
    {
        private static UserRepository instance;
        private SqlConnection connection;
        private string INSERT_SQL = "INSERT INTO Users VALUES ('{0}', '{1}', N'{2}', {3}, '{4}')";
        private string UPDATE_SQL = "UPDATE Users SET password = '{0}', fullName = '{1}', gender = {2}, createdAt = '{3}' WHERE username = '{4}'";
        private string SELECT_ALL_SQL = "SELECT * FROM Users";
        private string SELECT_SQL = "SELECT * FROM Users WHERE username = '{1}'";


        private UserRepository() {
            connection = DBContext.gI().getConnection();
        }

        public static UserRepository gI()
        {
            if (instance == null)
            {
                instance = new UserRepository();
            }
            return instance;
        }

        public List<User> findAll()
        {
            string SQL = SELECT_ALL_SQL;
            List<User> list = new List<User>();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string username = reader.GetString(0);
                        string password = reader.GetString(1);
                        string fullName = reader.GetString(2);
                        bool gender = reader.GetBoolean(3);
                        DateTime createdAt = reader.GetDateTime(4);

                        User user = new User(username, password, fullName, gender, createdAt);
                        list.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally { connection.Close(); }
            return list;
        }

        public User findById(string un)
        {
            string SQL = string.Format(SELECT_SQL, un);
            User user = null;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string username = reader.GetString(0);
                        string password = reader.GetString(1);
                        string fullName = reader.GetString(2);
                        bool gender = reader.GetBoolean(3);
                        DateTime createdAt = reader.GetDateTime(4);

                        user = new User(username, password, fullName, gender, createdAt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally { connection.Close(); }
            return user;
        }

        public User save(User user)
        {
            string SQL = string.Format(INSERT_SQL, user.username, user.password, user.fullName, user.gender ? 1 : 0, user.createdAt);
            Console.WriteLine(SQL);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                int reader = command.ExecuteNonQuery();
                if (reader < 0)
                {
                    throw new Exception("ERROR");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }finally { connection.Close(); }
            return user;
        }

        public void update(User user)
        {
            string SQL = string.Format(UPDATE_SQL, user.password, user.fullName, user.gender ? 1 : 0, user.createdAt, user.username);
            Console.WriteLine(SQL);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                int reader = command.ExecuteNonQuery();
                if (reader < 0)
                {
                    throw new Exception("ERROR");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally { connection.Close(); }
        }
    }
}
