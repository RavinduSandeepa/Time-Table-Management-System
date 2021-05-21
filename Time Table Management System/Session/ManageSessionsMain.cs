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

namespace Time_Table_Management_System.Session
{
    public partial class ManageSessionsMain : Form
    {
        private SessionDTO selectedSession = null;
        private ISessionService sessionService = new SessionService();
        private bool executedFirstTime;

        public ManageSessionsMain()
        {
            InitializeComponent();
            executedFirstTime = true;
            populateData();
        }

        public void populateData()
        {
            List<SessionDTO> sessionsArray = sessionService.getAllSessions();
            dataGridViewSessions.Rows.Clear();

            foreach (SessionDTO session in sessionsArray)
            {
                dataGridViewSessions.Rows.Add(session.Id, session.Lec1_name, session.Lec2_name, session.Subject_code, session.Subject_name, session.Group_code, session.Tag);
            }

        }

        private void dataGrid_Selection(object sender, EventArgs e)
        {
            if (executedFirstTime)
            {
                executedFirstTime = false;
                return;
            }
            try
            {
                //int selectedIndex = ;
                if (dataGridViewSessions.SelectedRows[0].Index != -1)
                {
                    if (dataGridViewSessions.SelectedRows[0].Cells[0].Value != null)
                    {
                        int id = int.Parse(dataGridViewSessions.SelectedRows[0].Cells[0].Value.ToString());
                        selectedSession = new SessionDTO();
                        selectedSession = sessionService.GetSession(id);

                        Console.WriteLine(id);

                        #region Set data to Fields
                        
                        #endregion

                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnView.Enabled = true;
                    }
                }


            }
            catch (ArgumentOutOfRangeException es)
            {
                Console.WriteLine(es.Message);
            }
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            ManageSessions manageSessions = new ManageSessions();
            manageSessions.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String typeGG = null;
            if (comboBoxSearch.Text == "Lecturer")
            {
                typeGG = "Lecturer";
                List<SessionDTO> sessionsArray = sessionService.searchSession(txtSearchKey.Text.Trim(), typeGG);
                if (sessionsArray.Count == 0)
                {
                    //ErrorMessage em = new ErrorMessage("No data found!");
                    //em.Show();
                    MessageBox.Show("No data found!");
                }
                else
                {
                    dataGridViewSessions.Rows.Clear();

                    foreach (SessionDTO session in sessionsArray)
                    {
                        dataGridViewSessions.Rows.Add(session.Id, session.Lec1_name, session.Lec2_name, session.Subject_code, session.Subject_name, session.Group_code, session.Tag);
                    }
                }


            }
            else if (comboBoxSearch.Text == "Subject Name")
            {
                typeGG = "subject_name";
                List<SessionDTO> sessionsArray = sessionService.searchSession(txtSearchKey.Text, typeGG);
                if (sessionsArray.Count == 0)
                {
                    //ErrorMessage em = new ErrorMessage("No data found!");
                    //em.Show();
                    MessageBox.Show("No data found!");
                }
                else
                {
                    dataGridViewSessions.Rows.Clear();

                    foreach (SessionDTO session in sessionsArray)
                    {
                        dataGridViewSessions.Rows.Add(session.Id, session.Lec1_name, session.Lec2_name, session.Subject_code, session.Subject_name, session.Group_code, session.Tag);
                    }
                }
            }
            else if (comboBoxSearch.Text == "Group ID")
            {
                typeGG = "group_code";
                List<SessionDTO> sessionsArray = sessionService.searchSession(txtSearchKey.Text, typeGG);
                if (sessionsArray.Count == 0)
                {
                    //ErrorMessage em = new ErrorMessage("No data found!");
                    //em.Show();
                    MessageBox.Show("No data found!");
                }
                else
                {
                    dataGridViewSessions.Rows.Clear();

                    foreach (SessionDTO session in sessionsArray)
                    {
                        dataGridViewSessions.Rows.Add(session.Id, session.Lec1_name, session.Lec2_name, session.Subject_code, session.Subject_name, session.Group_code, session.Tag);
                    }
                }
            }
            else
            {
                //ErrorMessage errorMessage = new ErrorMessage("Select a type to proceed...");
                // errorMessage.Show();
                MessageBox.Show("Select a type to proceed...");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (sessionService.deleteSession(selectedSession.Id))
            {
                //SuccessMessage sm = new SuccessMessage("Session Removed Successfully");
                //sm.Show();
                MessageBox.Show("Session Removed Successfully");
                dataGridViewSessions.Rows.Clear();
                populateData();
                selectedSession = new SessionDTO();
                btnDelete.Enabled = false;
                btnView.Enabled = false;
                btnUpdate.Enabled = false;

            }
            else
            {
                //ErrorMessage em = new ErrorMessage("Oops, Somthing went wrong..");
                //em.Show();
                MessageBox.Show("Oops, Somthing went wrong..");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewSession viewSession = new ViewSession(selectedSession.Id);
            viewSession.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateData();
            selectedSession = new SessionDTO();
            btnDelete.Enabled = false;
            btnView.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSession updateSession = new UpdateSession(selectedSession.Id);
            updateSession.Show();
        }

        private void dataGridViewSessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
