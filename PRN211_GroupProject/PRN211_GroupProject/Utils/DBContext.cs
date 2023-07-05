using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_GroupProject.Utils
{
    public class DBContext
    {
        private static DBContext instance;
        private string connectionString = "Data Source=localhost;Initial Catalog=PRN211_GroupProject;User ID=sa;Password=12345;";
        private SqlConnection connection;

        private DBContext()
        {
            connection = new SqlConnection(connectionString);
        }

        public static DBContext gI()
        {
            if (instance == null)
            {
                instance = new DBContext();
            }
            return instance;
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
