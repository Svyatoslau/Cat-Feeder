using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Model1;

namespace DAL
{
    public static class DBHelper
    {
        private static MySqlConnection connection;
        private static MySqlCommand cmd = null;
        private static DataTable dt;
        private static MySqlDataAdapter sda;

        public static MySqlConnection Connection { get => connection; }

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
            catch(Exception ex)
            {
                MessageBox.Show("connection Failed");
            }
        }

        
        public static MySqlCommand RunQuery(string query, string Name)
        {
            try
            {
                if(connection != null)
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.ExecuteNonQuery();
                    
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            return cmd;
        }
        public static int getCountRow(string table)
        {
            string query = "SELECT COUNT(*) FROM "+ table + ";";
            int countRaw =-1;
            try
            {
                if (connection != null)
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
            if (cmd != null)
            {
                dt = new DataTable();
                sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    string count =  dr["COUNT(*)"].ToString();
                    countRaw = Int32.Parse(count);
                }
            }
            return countRaw;
        }

        public static void AddUser( string ID, string Name, string password, string status)
        {
            string query = "insert into mydb.user(ID, Name, password, status)"
                + " values(@ID, @Name, @password, @status)";
            try
            {
                if (connection != null)
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@status", status);
                  
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        public static void AddFeeder(string ID, string Name, string value, string type)
        {
            string query = "insert into mydb.feeder(ID, Name, value, type)"
                + " values(@ID, @Name, @value, @type)";
            try
            {
                if (connection != null)
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.Parameters.AddWithValue("@type", type);

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }
        }

    }
}
