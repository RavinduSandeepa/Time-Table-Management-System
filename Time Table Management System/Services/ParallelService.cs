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
    class ParallelService : IParallelService
    {
        public bool addParallel(int parSessionID1, int parSessionID2, int parSessionID3)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {

                string query = "INSERT INTO parallels (par1_id, par2_id, par3_id) VALUES (@par1_id, @par2_id, @par3_id)";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@par1_id", parSessionID1);
                cmd.Parameters.AddWithValue("@par2_id", parSessionID2);
                cmd.Parameters.AddWithValue("@par3_id", parSessionID3);


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

        public bool deleteParallel(int id)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                string query = "DELETE FROM parallels WHERE id = @id";

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

        public List<ParalleDTO> getAllParallels()
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            List<ParalleDTO> arrayParallels = null;

            try
            {
                string query = "SELECT * FROM parallels";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                arrayParallels = new List<ParalleDTO>();

                while (rdr.Read())
                {
                    ParalleDTO paralleDTO = new ParalleDTO();
                    paralleDTO.Id = rdr.GetInt32(0);
                    paralleDTO.Par1_id = rdr.GetInt32(1);
                    try
                    {
                        paralleDTO.Par2_id = rdr.GetInt32(2);
                        paralleDTO.Par3_id = rdr.GetInt32(3);
                    }
                    catch (Exception er)
                    {
                        if (er.Message == "")
                        {

                        }
                    }


                    arrayParallels.Add(paralleDTO);
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

            return arrayParallels;

        }

        public ParalleDTO GetParallel(int id)
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            ParalleDTO paralleDTO = new ParalleDTO();

            try
            {
                string query = "SELECT * FROM parallels WHERE id = @id";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    paralleDTO.Id = rdr.GetInt32(0);
                    paralleDTO.Par1_id = rdr.GetInt32(1);
                    try
                    {
                        paralleDTO.Par2_id = rdr.GetInt32(2);
                        paralleDTO.Par3_id = rdr.GetInt32(3);
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

            return paralleDTO;
        }

        public List<ParalleDTO> searchParallel(string key, string type)
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);

            List<ParalleDTO> arrayParallels = null;

            try
            {
                string query = "SELECT * FROM parallels WHERE " + type + " LIKE '%" + key + "%'";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@type", type);
                MySqlDataReader rdr = cmd.ExecuteReader();
                arrayParallels = new List<ParalleDTO>();

                while (rdr.Read())
                {
                    ParalleDTO paralleDTO = new ParalleDTO();
                    paralleDTO.Id = rdr.GetInt32(0);
                    paralleDTO.Par1_id = rdr.GetInt32(1);
                    paralleDTO.Par2_id = rdr.GetInt32(2);
                    paralleDTO.Par3_id = rdr.GetInt32(3);


                    arrayParallels.Add(paralleDTO);
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

            return arrayParallels;
        }

        public bool updateParallel(int id, ParalleDTO parallel)
        {
            throw new NotImplementedException();
        }
    }
}
