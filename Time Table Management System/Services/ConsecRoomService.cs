using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;
using MySql.Data.MySqlClient;


namespace Time_Table_Management_System.Services
{
    class ConsecRoomService : IConsecRoomService
    {
        public bool addConsecutive(int con_id, ConsecRoom room)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            
            try
            {

                string query = "INSERT INTO consecutives (con_id,room) VALUES (@con_id,@room)";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@con_id", con_id);
                cmd.Parameters.AddWithValue("@room", room);



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
            throw new NotImplementedException();
        }

        public List<ConsecRoom> getAllConsecutives()
        {
            throw new NotImplementedException();
        }

        public ConsecRoom GetConsecutive(int id)
        {
            throw new NotImplementedException();
        }

        public List<Consecutive> searchConsecutive(string key, string type)
        {
            throw new NotImplementedException();
        }

        public bool updateConsecutive(int id, Consecutive consecutive)
        {
            throw new NotImplementedException();
        }
    }
}
