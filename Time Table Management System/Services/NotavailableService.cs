using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;
using System.Data.SQLite;
using MySql.Data.MySqlClient;


namespace Time_Table_Management_System.Services
{
    class NotavailableService : INotavailableService
    {
        public bool addNotavailable(Notavailable notavailable)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {

                string query = "INSERT INTO notavailables (duration, lec_name, group_code, subgroup_code, session_id) VALUES (@duration, @lec_name, @group_code, @subgroup_code, @session_id)";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@duration", notavailable.Duration);
                cmd.Parameters.AddWithValue("@lec_name", notavailable.Lec_name);
                cmd.Parameters.AddWithValue("@group_code", notavailable.Group_code);
                cmd.Parameters.AddWithValue("@subgroup_code", notavailable.Subgroup_code);
                cmd.Parameters.AddWithValue("@session_id", notavailable.Session_Id);


                cmd.Prepare();

                //Console.WriteLine(cmd);

                if (cmd.ExecuteNonQuery() == 1)
                    result = true;
                else
                    result = false;


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public bool deleteNotavailable(int id)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "DELETE FROM notavailables WHERE id = @id";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                if (cmd.ExecuteNonQuery() == 1)
                    result = true;
                else
                    result = false;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public List<Notavailable> getAllNotavailables()
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            List<Notavailable> arrayNotavailables = null;

         try
            {
                string query = "SELECT * FROM notavailables";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                arrayNotavailables = new List<Notavailable>();

                while (rdr.Read())
                {
                    Notavailable notavailable = new Notavailable();
                    notavailable.Id = rdr.GetInt32(0);
                    notavailable.Duration = rdr.GetString(1);
                    notavailable.Lec_name = rdr.GetString(2);
                    notavailable.Group_code = rdr.GetString(3);
                    notavailable.Subgroup_code = rdr.GetString(4);
                    notavailable.Session_Id = rdr.GetInt32(5);


                    arrayNotavailables.Add(notavailable);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return arrayNotavailables;
        }

        public Notavailable GetNotavailable(int id)
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
           // SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            Notavailable notavailable = new Notavailable();

            try
            {
                string query = "SELECT * FROM notavailables WHERE id = @id";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    notavailable.Id = rdr.GetInt32(0);
                    notavailable.Duration = rdr.GetString(1);
                    notavailable.Lec_name = rdr.GetString(2);
                    notavailable.Group_code = rdr.GetString(3);
                    notavailable.Subgroup_code = rdr.GetString(4);
                    notavailable.Session_Id = rdr.GetInt32(5);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return notavailable;
        }

        public List<Notavailable> searchNotavailable(string key, string type)
        {
            throw new NotImplementedException();
        }
    }
}
