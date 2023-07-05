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
    public class PlayListSongRepository
    {
        private static PlayListSongRepository instance;
        private SqlConnection connection;
        private string INSERT_SQL = "INSERT INTO PlayList_Song (play_list_id, song_id) VALUES ({0}, {1})";
        private string DELETE_SQL = "DELETE FROM PlayList_Song WHERE play_list_id = {0} AND song_id = {1}";
        private string SELECT_ALL_SQL = "SELECT * FROM PlayList_Song";
        private string SELECT_SQL_BY_PLID = "SELECT * FROM PlayList_Song WHERE play_list_id = {0}";
        private string SELECT_SQL_BY_SID = "SELECT * FROM PlayList_Song WHERE song_id = {0}";
        private string SELECT_SQL = "SELECT * FROM PlayList_Song WHERE play_list_id = {0} AND song_id = {1}";


        private PlayListSongRepository()
        {
            connection = DBContext.gI().getConnection();
        }

        public static PlayListSongRepository gI()
        {
            if (instance == null)
            {
                instance = new PlayListSongRepository();
            }
            return instance;
        }

        public List<PlayListSong> findAll()
        {
            string SQL = SELECT_ALL_SQL;
            List<PlayListSong> list = new List<PlayListSong>();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int playListId = reader.GetInt32(0);
                        int songId = reader.GetInt32(1);

                        PlayListSong pls = new PlayListSong(playListId, songId);
                        list.Add(pls);
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

        public List<PlayListSong> findByPlayListId(int id)
        {
            string SQL = string.Format(SELECT_SQL_BY_PLID, id);
            List<PlayListSong> list = new List<PlayListSong>();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int playListId = reader.GetInt32(0);
                        int songId = reader.GetInt32(1);

                        PlayListSong playListSong = new PlayListSong(playListId, songId);
                        list.Add(playListSong);
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

        public List<PlayListSong> findBySongId(int id)
        {
            string SQL = string.Format(SELECT_SQL_BY_SID, id);
            List<PlayListSong> list = new List<PlayListSong>();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int playListId = reader.GetInt32(0);
                        int songId = reader.GetInt32(1);

                        PlayListSong playListSong = new PlayListSong(playListId, songId);
                        list.Add(playListSong);
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

        public PlayListSong findById(int pId, int sId)
        {
            string SQL = string.Format(SELECT_SQL, pId, sId);
            PlayListSong playListSong = null;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(SQL, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int playListId = reader.GetInt32(0);
                        int songId = reader.GetInt32(1);

                        playListSong = new PlayListSong(playListId, songId);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally { connection.Close(); }
            return playListSong;
        }

        public PlayListSong save(PlayListSong playListSong)
        {
            string SQL = string.Format(INSERT_SQL, playListSong.play_list_id, playListSong.song_id);
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
            return playListSong;
        }

        public void deleteSongFromPlayList(int play_list_id, int song_id)
        {
            string SQL = string.Format(DELETE_SQL, play_list_id, song_id);
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
