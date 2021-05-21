using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Table_Management_System.Models;
using System.Data;
using MySql.Data.MySqlClient;


namespace Time_Table_Management_System.Services
{
    class SubjectService : ISubjectService
    {
        public bool addSubject(Subject subject)
        {
            Boolean result =false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                string query = "INSERT INTO subjects (subjectName, subjectCode, offeredYear, offeredSem, LecHours, TuteHours, LabHours, EvaluationHours) VALUES (@subname, @subcode, @offeredyear, @offeredSem, @lechours, @tutehours, @labhours, @evaluationhours)";
                
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@subname", subject.SubjectName);
                cmd.Parameters.AddWithValue("@subcode", subject.SubjectCode);
                cmd.Parameters.AddWithValue("@offeredyear", subject.OfferedYear);
                cmd.Parameters.AddWithValue("@offeredSem", subject.OfferedSem);
                cmd.Parameters.AddWithValue("@lechours", subject.LabHours);
                cmd.Parameters.AddWithValue("@tutehours", subject.TuteHours);
                cmd.Parameters.AddWithValue("@labhours", subject.LabHours);
                cmd.Parameters.AddWithValue("@evaluationhours", subject.EvaluationHours);

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

        public bool deleteSubject(int id)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                string query = "DELETE FROM subjects WHERE id = @id";

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

        public List<Subject> getAllSubjects()
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            List<Subject> arraySubs = null;


            try
            {
                string query = "SELECT * FROM subjects";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                arraySubs = new List<Subject>();

                while (rdr.Read())
                {
                    Subject sub = new Subject();
                    sub.Id = rdr.GetInt32(0);
                    sub.SubjectName = rdr.GetString(1);
                    sub.SubjectCode = rdr.GetString(2);
                    sub.OfferedYear = rdr.GetInt32(3);
                    sub.OfferedSem = rdr.GetInt32(4);
                    sub.LecHours = rdr.GetInt32(5);
                    sub.TuteHours = rdr.GetInt32(6);
                    sub.LabHours = rdr.GetInt32(7);
                    sub.EvaluationHours = rdr.GetInt32(8);

                    arraySubs.Add(sub);
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

            return arraySubs;
        }

        public Subject getSubject(int id)
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            Subject sub = new Subject();

            try
            {
                string query = "SELECT * FROM subjects WHERE id = @id";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    sub.Id = rdr.GetInt32(0);
                    sub.SubjectName = rdr.GetString(1);
                    sub.SubjectCode = rdr.GetString(2);
                    sub.OfferedYear = rdr.GetInt32(3);
                    sub.OfferedSem = rdr.GetInt32(4);
                    sub.LecHours = rdr.GetInt32(5);
                    sub.TuteHours = rdr.GetInt32(6);
                    sub.LabHours = rdr.GetInt32(7);
                    sub.EvaluationHours = rdr.GetInt32(8);
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

            return sub;
        }

        public bool updateSubject(int id, Subject subject)
        {
            Boolean result = false;
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                string query = "UPDATE subjects SET subjectName = @subname, subjectCode = @subcode, offeredYear = @offeredyear, offeredSem = @offeredSem, LecHours = @lechours, TuteHours = @tutehours, LabHours = @labhours, EvaluationHours = @evaluationhours WHERE id = @id";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@subname", subject.SubjectName);
                cmd.Parameters.AddWithValue("@subcode", subject.SubjectCode);
                cmd.Parameters.AddWithValue("@offeredyear", subject.OfferedYear);
                cmd.Parameters.AddWithValue("@offeredSem", subject.OfferedSem);
                cmd.Parameters.AddWithValue("@lechours", subject.LabHours);
                cmd.Parameters.AddWithValue("@tutehours", subject.TuteHours);
                cmd.Parameters.AddWithValue("@labhours", subject.LabHours);
                cmd.Parameters.AddWithValue("@evaluationhours", subject.EvaluationHours);
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
