using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Allocations;
using Time_Table_Management_System.Models;
using Time_Table_Management_System.Services;
using Time_Table_Management_System.Messages;
using MySql.Data.MySqlClient;


namespace Time_Table_Management_System.Allocations
{

    public partial class AllocateSession : Form
    {
        Boolean result = false;
        

        
        

        private SessionDTO selectedSession = null;
        private Notavailable notavailable = new Notavailable();

        private ISessionService sessionService = new SessionService();
        private IConsecutiveService consecutiveService = new ConsecutiveService();
        private INonoverlapService nonoverlapService = new NonoverlapService();
        private IParallelService parallelService = new ParallelService();
        private INotavailableService notavailableService = new NotavailableService();

        private int selectedLecCount = 0;

        private bool executedFirstTime;

        public AllocateSession()
        {
            InitializeComponent();
            executedFirstTime = true;
            populateData();

            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxColumn chkbox2 = new DataGridViewCheckBoxColumn();
            DataGridViewCheckBoxColumn chkbox3 = new DataGridViewCheckBoxColumn();

            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "checkBoxColumn";
            chkbox2.HeaderText = "";
            chkbox2.Width = 30;
            chkbox2.Name = "checkBoxColumn";
            chkbox3.HeaderText = "";
            chkbox3.Width = 30;
            chkbox3.Name = "checkBoxColumn";
            dataGridView1.Columns.Insert(0, chkbox);
            dataGridView2.Columns.Insert(0, chkbox2);
            dataGridView3.Columns.Insert(0, chkbox3);
        }

        public void populateData()
        {
            
            List<SessionDTO> sessionsArray = sessionService.getAllSessions();
            dataGridView1.Rows.Clear();

            foreach (SessionDTO session in sessionsArray)
            {
                dataGridView1.Rows.Add(session.Id, session.Lec1_name, session.Lec2_name, session.Subject_code, session.Subject_name, session.Group_code, session.Tag);

                dataGridView2.Rows.Add(session.Id, session.Lec1_name, session.Lec2_name, session.Subject_code, session.Subject_name, session.Group_code, session.Tag);

                dataGridView3.Rows.Add(session.Id, session.Lec1_name, session.Lec2_name, session.Subject_code, session.Subject_name, session.Group_code, session.Tag);

            }


        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            int conSessionID1 = 0;
            int conSessionID2 = 0;
            int selectedSessionsCount = 0;

            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                bool chkboxselected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);
                if (chkboxselected)
                {
                    if (selectedSessionsCount == 0)
                    {
                        conSessionID1 = int.Parse(dr.Cells[1].Value.ToString());
                        selectedSessionsCount++;

                    }
                    else if (selectedSessionsCount == 1)
                    {
                        conSessionID2 = int.Parse(dr.Cells[1].Value.ToString());
                        selectedSessionsCount++;
                    }
                }

            }
            if (consecutiveService.addConsecutive(conSessionID1, conSessionID2))
            {
                label1.Text = "Consecutive Sessions Added Successfully";
            }
            else
            {
                label1.Text = "Oops...Something went wrong";
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ManageConsecutives consecutiveSession = new ManageConsecutives();
            consecutiveSession.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewN_Click(object sender, EventArgs e)
        {
            ManageNonoverlaps nonoverlapSession = new ManageNonoverlaps();
            nonoverlapSession.Show();
        }

        private void btnViewP_Click(object sender, EventArgs e)
        {
            ManageParallels parallelSession = new ManageParallels();
            parallelSession.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int parSessionID1 = 0;
            int parSessionID2 = 0;
            int parSessionID3 = 0;
            int selectedSessionsCount2 = 0;

            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                bool chkboxselected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);
                if (chkboxselected)
                {
                    if (selectedSessionsCount2 == 0)
                    {
                        parSessionID1 = int.Parse(dr.Cells[1].Value.ToString());
                        selectedSessionsCount2++;

                    }
                    else if (selectedSessionsCount2 == 1)
                    {
                        parSessionID2 = int.Parse(dr.Cells[1].Value.ToString());
                        selectedSessionsCount2++;
                    }
                    else if (selectedSessionsCount2 == 2)
                    {
                        parSessionID3 = int.Parse(dr.Cells[1].Value.ToString());
                        selectedSessionsCount2++;
                    }
                }

            }
            if (parallelService.addParallel(parSessionID1, parSessionID2, parSessionID3))
            {
                label2.Text = "Parallel Sessions Added Successfully";
            }
            else
            {
                label2.Text = "Oops...Something went wrong";
            }

        }

        private void btnAddN_Click(object sender, EventArgs e)
        {

            int nonSessionID1 = 0;
            int nonSessionID2 = 0;
            int nonSessionID3 = 0;
            int nonSessionID4 = 0;
            int selectedSessionsCount3 = 0;

            foreach (DataGridViewRow dr in dataGridView3.Rows)
            {
                bool chkboxselected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);
                if (chkboxselected)
                {
                    if (selectedSessionsCount3 == 0)
                    {
                        nonSessionID1 = int.Parse(dr.Cells[1].Value.ToString());
                        selectedSessionsCount3++;

                    }
                    else if (selectedSessionsCount3 == 1)
                    {
                        nonSessionID2 = int.Parse(dr.Cells[1].Value.ToString());
                        selectedSessionsCount3++;
                    }
                    else if (selectedSessionsCount3 == 2)
                    {
                        nonSessionID3 = int.Parse(dr.Cells[1].Value.ToString());
                        selectedSessionsCount3++;
                    }
                    else if (selectedSessionsCount3 == 3)
                    {
                        nonSessionID4 = int.Parse(dr.Cells[1].Value.ToString());
                        selectedSessionsCount3++;
                    }

                }
                if (nonoverlapService.addNonoverlap(nonSessionID1, nonSessionID2, nonSessionID3, nonSessionID4))
                {
                    label3.Text = "Non Overlapping Sessions Added Successfully";
                }
                else
                {
                    label3.Text = "Oops...Something went wrong";
                }

            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxLec_SelectedIndexChanged(object sender, EventArgs e)
        {
                 notavailable.Lec_name = comboBoxLec.Text;
                               
        }



        private void AllocateSession_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_9513ba349fe86de;Uid=bf862fa75e1087;Pwd=92fff314;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            comboBoxLec.Items.Clear();
            comboBoxGroup.Items.Clear();
            comboBoxSub.Items.Clear();
            comboBoxSid.Items.Clear();
            
            
            string query = "SELECT lec_name FROM lecturers";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Prepare();

            string query2 = "SELECT groupId FROM students";
            MySqlCommand cmd2 = new MySqlCommand(query2, conn);
            cmd2.Prepare();

            string query3 = "SELECT subGroupId FROM students";
            MySqlCommand cmd3 = new MySqlCommand(query3, conn);
            cmd3.Prepare();

            string query4 = "SELECT id FROM sessions";
            MySqlCommand cmd4 = new MySqlCommand(query4, conn);
            cmd4.Prepare();

            if (cmd.ExecuteNonQuery() == 1)
                result = true;
            else
                result = false;

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
            MySqlDataAdapter da4 = new MySqlDataAdapter(cmd4);

            da.Fill(dt);
            da2.Fill(dt2);
            da3.Fill(dt3);
            da4.Fill(dt4);

            foreach (DataRow dr in dt.Rows)
            {
                comboBoxLec.Items.Add(dr["lec_name"].ToString());
            }

            foreach (DataRow dr2 in dt2.Rows)
            {
                comboBoxGroup.Items.Add(dr2["groupId"].ToString());
            }

            foreach (DataRow dr3 in dt3.Rows)
            {
                comboBoxSub.Items.Add(dr3["subGroupId"].ToString());
            }

            foreach (DataRow dr4 in dt4.Rows)
            {
                comboBoxSid.Items.Add(dr4["id"].ToString());
            }

           conn.Close();
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            notavailable.Group_code = comboBoxGroup.Text;
        }

        private void comboBoxSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            notavailable.Subgroup_code = comboBoxSub.Text;
        }

        private void comboBoxSid_SelectedIndexChanged(object sender, EventArgs e)
        {
            notavailable.Session_Id = comboBoxSid.SelectedIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBoxLec.SelectedIndex = -1;
            comboBoxGroup.SelectedIndex = -1;
            comboBoxSub.SelectedIndex = -1;
            comboBoxSid.SelectedIndex = -1;           
            textBox1.Text = String.Empty;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageNotavailables notavailableSession = new ManageNotavailables();
            notavailableSession.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(comboBoxLec.SelectedIndex == -1)
            {
                comboBoxLec.Focus();
                
            }
            else if (comboBoxGroup.SelectedIndex == -1)
            {
                comboBoxGroup.Focus();
                
            }
            else if (comboBoxSub.SelectedIndex == -1)
            {
                comboBoxSub.Focus();
                
            }
            else if (comboBoxSid.SelectedIndex == -1)
            {
                comboBoxSid.Focus();
                
            }
            else if(textBox1.Text == String.Empty)
            {
                textBox1.Focus();
                errorNot.SetError(textBox1, "Please Enter Time");
            }
            else
            {
                Notavailable notavailable = new Notavailable();
                INotavailableService notavailableService = new NotavailableService();
                // Set Data
                notavailable.Duration = textBox1.Text.Trim();
                notavailable.Lec_name = comboBoxLec.Text;
                notavailable.Group_code = comboBoxGroup.Text;
                notavailable.Subgroup_code = comboBoxSub.Text;
                notavailable.Session_Id = int.Parse(comboBoxSid.Text);
                
                //Insert Data
                if (notavailableService.addNotavailable(notavailable))
                {

                    //SuccessMessage sc = new SuccessMessage("Not Available Time Added Successfully !");
                    //sc.Show();
                    MessageBox.Show("Not Available Time Added Successfully !");
                    textBox1.Text = "";
                    comboBoxLec.SelectedIndex = -1;
                    comboBoxGroup.SelectedIndex = -1;
                    comboBoxSub.SelectedIndex = -1;
                    comboBoxSid.SelectedIndex = -1;


                }
                else
                {
                    //ErrorMessage ec = new ErrorMessage("Oops, Somthing went wrong!");
                    //ec.Show();
                    MessageBox.Show("Oops, Somthing went wrong!");
                    textBox1.Text = "";
                    comboBoxLec.SelectedIndex = -1;
                    comboBoxGroup.SelectedIndex = -1;
                    comboBoxSub.SelectedIndex = -1;
                    comboBoxSid.SelectedIndex = -1;
                }
            }
        }
    }
}