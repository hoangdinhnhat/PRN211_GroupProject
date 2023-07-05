using PRN211_GroupProject.Model;
using PRN211_GroupProject.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PRN211_GroupProject.Repository
{
    public class PlayListRepository
    {

        private static PlayListRepository instance;
        private SqlConnection connection;
        private string INSERT_SQL = "INSERT INTO PlayList (name, createdAt, description) VALUES (N'{0}', '{1}', N'{2}')";
        private string UPDATE_SQL = "UPDATE PlayList SET name = N'{0}', createdAt = '{1}', description = N'{2}' WHERE id = {4}";
        private string SELECT_ALL_SQL = "SELECT * FROM PlayList";
        private string SELECT_SQL = "SELECT * FROM PlayList WHERE id = {1}";
        private string DELETE_SQL = "DELETE FROM PlayList WHERE id = {1}";


        private PlayListRepository()
        {
            connection = DBContext.gI().getConnection();
        }

        public static PlayListRepository gI()
        {
            if (instance == null)
            {
                instance = new PlayListRepository();
            }
            return instance;
        }

        public List<PlayList> findAll()
        {
            string SQL = SELECT_ALL_SQL;
            List<PlayList> list = new List<PlayList>();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        DateTime createdAt = reader.GetDateTime(2);
                        string description = reader.GetString(3);

                        PlayList playList = new PlayList(id, name, createdAt, description);
                        list.Add(playList);
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

        public PlayList findById(int plid)
        {
            string SQL = string.Format(SELECT_SQL, plid);
            PlayList playList = null;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        DateTime createdAt = reader.GetDateTime(2);
                        string description = reader.GetString(3);

                        playList = new PlayList(id, name, createdAt, description);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally { connection.Close(); }
            return playList;
        }

        public PlayList save(PlayList playList)
        {
            string SQL = string.Format(INSERT_SQL, playList.name, playList.createdAt, playList.description);
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
            return playList;
        }

        public void update(PlayList playList)
        {
            string SQL = string.Format(UPDATE_SQL, playList.name, playList.createdAt, playList.description, playList.id);
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

        public void delete(int id)
        {
            string SQL = string.Format(DELETE_SQL, id);
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
