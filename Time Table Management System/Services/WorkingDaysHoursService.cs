using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;
using MySql.Data.MySqlClient;

namespace Time_Table_Management_System.Services
{
    class WorkingDaysHoursService : IWorkingDaysHoursService
    {

        public bool addWorkingDaysHours(WorkingDaysHours workingDaysHours)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            
            try
            {
                string query = "INSERT INTO workingdayshours (noOfWorkingDays, monday, tuesday, wednesday, thursday, friday, saturday, sunday, noOfWorkingHours, noOfWorkingMinutes) VALUES (@noOfWorkingDays, @monday, @tuesday, @wednesday, @thursday, @friday, @saturday, @sunday, @noOfWorkingHours, @noOfWorkingMinutes)";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@noOfWorkingDays",workingDaysHours.NoOfWorkingDays);
                cmd.Parameters.AddWithValue("@monday", workingDaysHours.Monday);
                cmd.Parameters.AddWithValue("@tuesday", workingDaysHours.Tuesday);
                cmd.Parameters.AddWithValue("@wednesday", workingDaysHours.Wednesday);
                cmd.Parameters.AddWithValue("@thursday", workingDaysHours.Thursday);
                cmd.Parameters.AddWithValue("@friday", workingDaysHours.Friday);
                cmd.Parameters.AddWithValue("@saturday", workingDaysHours.Saturday);
                cmd.Parameters.AddWithValue("@sunday", workingDaysHours.Sunday);
                cmd.Parameters.AddWithValue("@noOfWorkingHours", workingDaysHours.NoOfHours);
                cmd.Parameters.AddWithValue("@noOfWorkingMinutes", workingDaysHours.NoOfMinutes);

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

        public bool deleteWorkingDaysHours()
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            
            try
            {
                string query = "DELETE FROM workingdayshours";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();

                if (cmd.ExecuteNonQuery() != 0)
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

        public bool getExistWorkingDaysHours()
        {
            
            Boolean exist = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                string query = "SELECT * FROM workingdayshours";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
               
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    exist = true;
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

            return exist;
        }

        public WorkingDaysHours getWorkingDaysHours()
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            WorkingDaysHours workingDaysHours = new WorkingDaysHours();
            try
            {
                string query = "SELECT * FROM workingdayshours";
                conn.Open();
                

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                

                while (rdr.Read())
                {
                    workingDaysHours.Id = rdr.GetInt32(0);
                    workingDaysHours.NoOfWorkingDays = rdr.GetInt32(1);
                    workingDaysHours.Monday = rdr.GetInt32(2);
                    workingDaysHours.Tuesday = rdr.GetInt32(3);
                    workingDaysHours.Wednesday = rdr.GetInt32(4);
                    workingDaysHours.Thursday = rdr.GetInt32(5);
                    workingDaysHours.Friday = rdr.GetInt32(6);
                    workingDaysHours.Saturday = rdr.GetInt32(7);
                    workingDaysHours.Sunday = rdr.GetInt32(8);
                    workingDaysHours.NoOfHours = rdr.GetInt32(9);
                    workingDaysHours.NoOfMinutes = rdr.GetInt32(10);
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

            return workingDaysHours;
        }




        public Boolean updateWorkingDaysHours(WorkingDaysHours workingDaysHours)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            
            try
            {
                string query = "UPDATE workingdayshours SET noOfWorkingDays = @noworkingdays WHERE id = 2";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                

                cmd.Parameters.AddWithValue("@noworkingdays", workingDaysHours);

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


    }
}
