using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Time_Table_Management_System.Services
{
    class LecturerService : ILecturerService
    {
        public bool addLecturer(Lecturer lecturer)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            
            try
            {
                string query = "INSERT INTO lecturers (lec_name, employee_id, faculty, department, center, building, level, rank) VALUES (@lecname, @employeeid, @faculty, @department, @center, @building, @level, @rank)";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@lecname", lecturer.Name);
                cmd.Parameters.AddWithValue("@employeeid", lecturer.EmployeeID);
                cmd.Parameters.AddWithValue("@faculty", lecturer.Faculty);
                cmd.Parameters.AddWithValue("@department", lecturer.Department);
                cmd.Parameters.AddWithValue("@center", lecturer.Center);
                cmd.Parameters.AddWithValue("@building", lecturer.Building);
                cmd.Parameters.AddWithValue("@level", lecturer.Level);
                cmd.Parameters.AddWithValue("@rank", lecturer.Rank);

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

        public bool deleteLecturer(int id)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                string query = "DELETE FROM lecturers WHERE id = @id";

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

        public List<Lecturer> getAllLecturers()
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            List<Lecturer> arrayLecs = null;
            

            try
            {
                string query = "SELECT * FROM lecturers";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                arrayLecs = new List<Lecturer>();

                while (rdr.Read())
                {
                    Lecturer lec = new Lecturer();
                    lec.Id = rdr.GetInt32(0);
                    lec.Name = rdr.GetString(1);
                    lec.EmployeeID = rdr.GetString(2);
                    lec.Faculty = rdr.GetString(3);
                    lec.Department = rdr.GetString(4);
                    lec.Center = rdr.GetString(5);
                    lec.Building = rdr.GetString(6);
                    lec.Level = rdr.GetInt32(7);
                    lec.Rank = rdr.GetString(8);

                    arrayLecs.Add(lec);
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

            return arrayLecs;
        }

        public Lecturer GetLecturer(int id)
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            Lecturer lec = new Lecturer();

            try
            {
                string query = "SELECT * FROM lecturers WHERE id = @id";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    lec.Id = rdr.GetInt32(0);
                    lec.Name = rdr.GetString(1);
                    lec.EmployeeID = rdr.GetString(2);
                    lec.Faculty = rdr.GetString(3);
                    lec.Department = rdr.GetString(4);
                    lec.Center = rdr.GetString(5);
                    lec.Building = rdr.GetString(6);
                    lec.Level = rdr.GetInt32(7);
                    lec.Rank = rdr.GetString(8);
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

            return lec;
        }

        public bool updateLecturer(int id, Lecturer lecturer)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                string query = "UPDATE lecturers SET lec_name = @lecname, employee_id = @employeeid, faculty = @faculty, department = @department, center = @center, building = @building, level = @level, rank = @rank WHERE id = @id";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@lecname", lecturer.Name);
                cmd.Parameters.AddWithValue("@employeeid", lecturer.EmployeeID);
                cmd.Parameters.AddWithValue("@faculty", lecturer.Faculty);
                cmd.Parameters.AddWithValue("@department", lecturer.Department);
                cmd.Parameters.AddWithValue("@center", lecturer.Center);
                cmd.Parameters.AddWithValue("@building", lecturer.Building);
                cmd.Parameters.AddWithValue("@level", lecturer.Level);
                cmd.Parameters.AddWithValue("@rank", lecturer.Rank);
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
    }
}
