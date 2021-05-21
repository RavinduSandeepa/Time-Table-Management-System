using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Messages;
using Time_Table_Management_System.Models;
using Time_Table_Management_System.Services;

namespace Time_Table_Management_System.LocationAllocation
{
    public partial class AllocateLocationMain : Form
    {
        private SessionDTO selectedSession = null;
        private ISessionService sessionService = new SessionService();
        private bool executedFirstTime;

        private Consecutive session = null;

        private ConsecRoom consession = null;

        private IConsecRoomService consecRoomService = new ConsecRoomService();

        private IConsecutiveService consecutiveService = new ConsecutiveService();

        //private bool executedFirstTime;
        public AllocateLocationMain()
        {
            InitializeComponent();
            executedFirstTime = true;
            populateData();

            DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();

            chkbox.HeaderText = "";
            chkbox.Width = 30;
            chkbox.Name = "checkBoxColumn";
            
            dataGridViewSessions.Columns.Insert(0, chkbox);
        }
        public void populateData()
        {
            List<Consecutive> session1 = consecutiveService.getAllConsecutives();
            dataGridViewSessions.Rows.Clear();
            foreach (Consecutive sessionCon in session1)
            {
                dataGridViewSessions.Rows.Add(sessionCon.Id, sessionCon.Con1_id, sessionCon.Con2_id);

            }




            List<SessionDTO> sessionsArray = sessionService.getAllSessions();
            dataGridViewSessionRoom.Rows.Clear();

            foreach (SessionDTO session in sessionsArray)
            {
                dataGridViewSessionRoom.Rows.Add(session.Id, session.Lec1_name, session.Lec2_name, session.Subject_code, session.Subject_name, session.Group_code, session.Tag, session.Room);
            }

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            ManageSessionRoom locationAllocation = new ManageSessionRoom();
            locationAllocation.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateData();
            selectedSession = new SessionDTO();
        }

        private void dataGridViewSessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addConsecRoom_Click(object sender, EventArgs e)
        {
            int conSessionID1 = 0;
            int selectedSessionsCount = 0;

            foreach (DataGridViewRow dr in dataGridViewSessions.Rows)
            {
                bool chkboxselected = Convert.ToBoolean(dr.Cells["checkBoxColumn"].Value);

                if (chkboxselected)
                {
                    if (selectedSessionsCount == 0)
                    {
                        conSessionID1 = int.Parse(dr.Cells[1].Value.ToString());
                        selectedSessionsCount++;

                    }

                }


            }

            ConsecRoom ses = new ConsecRoom();
            IConsecRoomService consecRoomService = new ConsecRoomService();
            ses.Room = comboRoom.Text.Trim();

            if (consecRoomService.addConsecutive(conSessionID1, ses))
            {
                label1.Text = "Consecutive Sessions Added Successfully";
            }
            else
            {
                label1.Text = "Oops...Something went wrong";
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRoom.Text == String.Empty)
            {
                txtRoom.Focus();
                errorProvider1.SetError(txtRoom, "Please Select Building");
            }
            else if (comboBoxDay.Text == String.Empty)
            {
                comboBoxDay.Focus();
                errorProvider1.SetError(comboBoxDay, "Please Enter Subject Code");
            }
            else if (txtStartTime.Text == String.Empty)
            {
                txtStartTime.Focus();
                errorProvider1.SetError(txtStartTime, "Please Enter Subject Code");
            }
            else if (txtEndTime.Text == String.Empty)
            {
                txtEndTime.Focus();
                errorProvider1.SetError(txtEndTime, "Please Enter Subject Code");
            }


            else
            {
                Unavailable unavailable = new Unavailable();
                IUnavailableService unavailableService = new UnavailableService();

                // Set Data

                unavailable.Room = txtRoom.Text.Trim();
                unavailable.Day = comboBoxDay.Text.Trim();
                unavailable.Start_time = txtStartTime.Text.Trim();



                unavailable.End_time = txtEndTime.Text.Trim();

                //Insert Data
                if (unavailableService.addUnavailable(unavailable))
                {
                    //MessageBox.Show(tag.Tag);
                    SuccessMessage sc = new SuccessMessage("Unavailable Locations Added Successfully !");
                    sc.Show();
                }
                else
                {
                    ErrorMessage ec = new ErrorMessage("Oops, Somthing went wrong!");
                    ec.Show();
                }
            }

        }

        private void btnViewN_Click(object sender, EventArgs e)
        {
            txtRoom.Text = "";
            comboBoxDay.Text = "";
            txtStartTime.Text = "";
            txtEndTime.Text = "";
            
        }

        private void txtStartTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

