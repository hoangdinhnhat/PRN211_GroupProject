using PRN211_GroupProject.Model;
using PRN211_GroupProject.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_GroupProject.Repository
{
    public class SongRepository
    {
        private static SongRepository instance;
        private SqlConnection connection;
        private string INSERT_SQL = "INSERT INTO Song (name, singer, YOP, path) VALUES (N'{0}', N'{1}', {2}, '{3}')";
        private string UPDATE_SQL = "UPDATE Song SET name = N'{0}', singer = N'{1}', YOP = {2}, path = '{3}' WHERE id = {4}";
        private string SELECT_ALL_SQL = "SELECT * FROM Song";
        private string SELECT_SQL = "SELECT * FROM Song WHERE id = {0}";
        private string SEARCH_SQL = "SELECT * FROM Song WHERE name LIKE '%{0}%' OR singer LIKE '%{1}%'";


        private SongRepository()
        {
            connection = DBContext.gI().getConnection();
        }

        public static SongRepository gI()
        {
            if (instance == null)
            {
                instance = new SongRepository();
            }
            return instance;
        }

        public List<Song> findAll()
        {
            string SQL = SELECT_ALL_SQL;
            List<Song> list = new List<Song>();
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
                        string singer = reader.GetString(2);
                        int YOP = reader.GetInt32(3);
                        string path = reader.GetString(4);

                        Song song = new Song(id, name, singer, YOP, path);
                        list.Add(song);
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

        public Song findById(int sid)
        {
            string SQL = string.Format(SELECT_SQL, sid);
            Song song = null;
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
                        string singer = reader.GetString(2);
                        int YOP = reader.GetInt32(3);
                        string path = reader.GetString(4);

                        song = new Song(id, name, singer, YOP, path);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally { connection.Close(); }
            return song;
        }

        public List<Song> findByKeyword(string keyword)
        {
            string SQL = string.Format(SEARCH_SQL, keyword, keyword);
            List<Song> list = new List<Song>();
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
                        string singer = reader.GetString(2);
                        int YOP = reader.GetInt32(3);
                        string path = reader.GetString(4);

                        Song song = new Song(id, name, singer, YOP, path);
                        list.Add(song);
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

        public Song save(Song song)
        {
            string SQL = string.Format(INSERT_SQL, song.name, song.singer, song.YOP, song.path);
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
            return song;
        }

        public void update(Song song)
        {
            string SQL = string.Format(UPDATE_SQL, song.name, song.singer, song.YOP, song.path, song.id);
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
