using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;
using MySql.Data.MySqlClient;


namespace Time_Table_Management_System.Services
{
    class UnavailableService : IUnavailableService
    {
        public bool addUnavailable(Unavailable unavailable)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");

            try
            {
                //string query = "SELECT * FROM people WHERE username= @user AND password= @pass";
                string query = "INSERT INTO locationunavailable (room, day, start_time,end_time) VALUES (@room, @day, @start_time,@end_time)";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@room", unavailable.Room);
                cmd.Parameters.AddWithValue("@day", unavailable.Day);
                cmd.Parameters.AddWithValue("@start_time", unavailable.Start_time);
                cmd.Parameters.AddWithValue("@end_time", unavailable.End_time);
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

        public bool deleteUnavailable(int id)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            //SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            try
            {
                string query = "DELETE FROM locationunavailable WHERE id = @id";

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

        public List<Unavailable> getAllUnavailable()
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
           // SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3;");
            List<Unavailable> arrayUnavailable = null;


            try
            {
                string query = "SELECT * FROM locationunavailable";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                arrayUnavailable = new List<Unavailable>();

                while (rdr.Read())
                {
                    Unavailable unavailable = new Unavailable();
                    unavailable.Id = rdr.GetInt32(0);
                    unavailable.Room = rdr.GetString(1);
                    unavailable.Day = rdr.GetString(2);
                    unavailable.Start_time = rdr.GetString(3);
                    unavailable.End_time = rdr.GetString(4);

                    arrayUnavailable.Add(unavailable);
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

            return arrayUnavailable;
        }

        public Unavailable GetUnavailable(int id)
        {

            throw new NotImplementedException();
        }

        public bool updateUnavailable(int id, Unavailable unavailable)
        {
            throw new NotImplementedException();
        }
    }
}
