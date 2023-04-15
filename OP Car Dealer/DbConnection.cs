using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OP_Car_Dealer
{
    class DbConnection
    {
        static MySqlConnection conn;
        public static string server = "localhost";
        public static string userId = "root";
        public static string password = "";
        public static string db = "proyekpcs";

        public static void openConn()
        {
            // Try and open a connection to the MySql Database with the parameters provided.
            conn = new MySqlConnection($"server={server}; user id={userId}; password={password}; database={db}");
            conn.Open();
        }

        public static MySqlConnection getConn()
        {
            // Return the connection regardless if it is opened or not. Returned null if never been initialized before.
            return conn;
        }
    }
}
