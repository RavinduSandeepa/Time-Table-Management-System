using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Models;
using Time_Table_Management_System.Services;

namespace Time_Table_Management_System.Session
{
    public partial class ViewSession : Form
    {

        public ViewSession(int id)
        {
            InitializeComponent();
            loadData(id);
        }

        private void loadData(int id)
        {
            SessionDTO selectedSession = new SessionDTO();
            ISessionService sessionService = new SessionService();
            selectedSession = sessionService.GetSession(id);

            txtSessionID.Text = selectedSession.Id.ToString();
            txtLecs.Text = selectedSession.Lec1_name;
            if (selectedSession.Lec2_name != null)
                txtLecs.Text = selectedSession.Lec1_name + " , " + selectedSession.Lec2_name;
            txtTag.Text = selectedSession.Tag;
            txtGroupID.Text = selectedSession.Group_code;
            txtSubjectCode.Text = selectedSession.Subject_code;
            txtSubjectName.Text = selectedSession.Subject_name;
            txtStudentCount.Text = selectedSession.Student_count.ToString();
            txtDuration.Text = selectedSession.Duration.ToString();

            if(selectedSession.Lec2_name == null)
            {
                txtSummery.Text = selectedSession.Lec1_name + Environment.NewLine +
                                  selectedSession.Subject_name + "(" + selectedSession.Subject_code + ")" + Environment.NewLine +
                                  selectedSession.Tag + Environment.NewLine +
                                  selectedSession.Group_code + Environment.NewLine +
                                  selectedSession.Student_count.ToString() + "( "+ selectedSession.Duration.ToString() + ")";
            }
            else
            {
                txtSummery.Text = selectedSession.Lec1_name + ", " + selectedSession.Lec2_name + Environment.NewLine +
                                  selectedSession.Subject_name + "(" + selectedSession.Subject_code + ")" + Environment.NewLine +
                                  selectedSession.Tag + Environment.NewLine +
                                  selectedSession.Group_code + Environment.NewLine +
                                  selectedSession.Student_count.ToString() + "( " + selectedSession.Duration.ToString() + ")";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSummery_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
