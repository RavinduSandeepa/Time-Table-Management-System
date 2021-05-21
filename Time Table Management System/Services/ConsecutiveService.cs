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
    class ConsecutiveService : IConsecutiveService
    {
            
        public bool addConsecutive(int conSessionID1 , int conSessionID2)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
           // SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {

                string query = "INSERT INTO consecutives (con1_id, con2_id) VALUES (@con1_id, @con2_id)";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@con1_id", conSessionID1);
                cmd.Parameters.AddWithValue("@con2_id", conSessionID2);


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

        public bool deleteConsecutive(int id)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "DELETE FROM consecutives WHERE id = @id";

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

        public List<Consecutive> getAllConsecutives()
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            List<Consecutive> arrayConsecutives = null;

            try
            {
                string query = "SELECT * FROM consecutives";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                arrayConsecutives = new List<Consecutive>();

                while (rdr.Read())
                {
                    Consecutive consecutive = new Consecutive();
                    consecutive.Id = rdr.GetInt32(0);
                    consecutive.Con1_id = rdr.GetInt32(1);
                    try
                    {
                        consecutive.Con2_id = rdr.GetInt32(2);
                    }
                    catch (Exception er)
                    {
                        if (er.Message == "")
                        {

                        }
                    }


                    arrayConsecutives.Add(consecutive);
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

            return arrayConsecutives;


        }

        public Consecutive GetConsecutive(int id)
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            Consecutive consecutive = new Consecutive();

            try
            {
                string query = "SELECT * FROM consecutives WHERE id = @id";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    consecutive.Id = rdr.GetInt32(0);
                    consecutive.Con1_id = rdr.GetInt32(1);
                    try
                    {
                        consecutive.Con2_id = rdr.GetInt32(2);
                    }
                    catch (Exception er)
                    {
                        if (er.Message == "")
                        {

                        }
                    }
                  
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

            return consecutive;
        }

        public List<Consecutive> searchConsecutive(string key, string type)
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            List<Consecutive> arrayConsecutives = null;

            try
            {
                    string query = "SELECT * FROM consecutives WHERE " + type + " LIKE '%" + key + "%'";
                    conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@type", type);
                MySqlDataReader rdr = cmd.ExecuteReader();
                    arrayConsecutives = new List<Consecutive>();

                    while (rdr.Read())
                    {
                        Consecutive consecutive = new Consecutive();
                        consecutive.Id = rdr.GetInt32(0);
                        consecutive.Con1_id = rdr.GetInt32(1);
                        consecutive.Con2_id = rdr.GetInt32(2);
          

                        arrayConsecutives.Add(consecutive);
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

            return arrayConsecutives;
        }

        public bool updateConsecutive(int id, Consecutive consecutive)
        {
            throw new NotImplementedException();
        }
    }
}
