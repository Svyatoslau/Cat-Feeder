using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public static class DBHelper
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static void EstablishConnection()
        {
            try
            {
                MySqlConnectionStringBuilder buider = new MySqlConnectionStringBuilder();
                buider.Server = "127.0.0.1";
                buider.UserID = "root";
                buider.Password = "ROOT";
                buider.Database = "mydb";
                buider.SslMode = MySqlSslMode.None;
                connection = new MySqlConnection(buider.ToString());
                MessageBox.Show("Database connection successfull", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("connection Failed");
            }
        }

    }
}
