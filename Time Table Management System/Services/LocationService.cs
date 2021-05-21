using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Time_Table_Management_System.Models;
using MySql.Data.MySqlClient;

namespace Time_Table_Management_System.Services
{
    class LocationService : ILocationService
    {
        public bool addLocation(Location location)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            

            try
            {
                
                string query = "INSERT INTO locations (buildingName, roomName, roomType,capacity) VALUES (@buildingname, @roomname, @roomtype,@capacity)";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@buildingname", location.BuildingName);
                cmd.Parameters.AddWithValue("@roomname", location.RoomName);
                cmd.Parameters.AddWithValue("@roomtype", location.RoomType);
                cmd.Parameters.AddWithValue("@capacity", location.Capacity);
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

        public bool deleteLocation(int id)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            
            try
            {
                string query = "DELETE FROM locations WHERE id = @id";

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


        public List<Location> getAllLocations()
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            
            List<Location> arrayLocs = null;


            try
            {
                string query = "SELECT * FROM locations";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                arrayLocs = new List<Location>();

                while (rdr.Read())
                {
                    Location loc = new Location();
                    loc.Id = rdr.GetInt32(0);
                    loc.BuildingName = rdr.GetString(1);
                    loc.RoomName = rdr.GetString(2);
                    loc.RoomType = rdr.GetString(3);
                    loc.Capacity = rdr.GetString(4);

                    arrayLocs.Add(loc);
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

            return arrayLocs;
        }


        public Location GetLocation(int id)
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            
            Location loc = new Location();

            try
            {
                string query = "SELECT * FROM locations WHERE id = @id";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    loc.Id = rdr.GetInt32(0);
                    loc.BuildingName = rdr.GetString(1);
                    loc.RoomName = rdr.GetString(2);
                    loc.RoomType = rdr.GetString(3);
                    loc.Capacity = rdr.GetString(4);
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

            return loc;
        }
        public bool updateLocation(int id, Location location)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            
            try
            {
                string query = "UPDATE locations SET buildingName = @buildingname, roomName = @roomname, roomType = @roomtype, capacity = @capacity WHERE id = @id";


                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@buildingname", location.BuildingName);
                cmd.Parameters.AddWithValue("@roomname", location.RoomName);
                cmd.Parameters.AddWithValue("@roomtype", location.RoomType);
                cmd.Parameters.AddWithValue("@capacity", location.Capacity);
                cmd.Parameters.AddWithValue("@id", id);

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
    }
}
