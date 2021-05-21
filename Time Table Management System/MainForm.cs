using  System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Lecturers;
using Time_Table_Management_System.Students;
using Time_Table_Management_System.Tags;
using Time_Table_Management_System.Locations;
using Time_Table_Management_System.DaysAndHours;
using Time_Table_Management_System.Session;
using Time_Table_Management_System.Messages;
using Time_Table_Management_System.Generate;
using Time_Table_Management_System.Allocations;
using Time_Table_Management_System.LocationAllocation;


namespace Time_Table_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
            loadTimeDate();
        }

        #region Functions for NavBar
        private void customizeDesign()
        {
            panelWorkingHoursSubMenu.Visible = false;
            panelLecturersSubMenu.Visible = false;
            panelSubjectsSubMenu.Visible = false;
            panelStudentsSubMenu.Visible = false;
            panelTagsSubMenu.Visible = false;
            panelLocationsSubMenu.Visible = false;

            btnAddSession.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            btnGenerate.Visible = true;

            //visible these things after
            button4.Visible = false;
            textBoxDate.Visible = false;
            textBoxTime.Visible = false;
            pictureBox1.Visible = true;
            label1.Visible = true;
            devTeam.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;

        }
        private void hideSubMenu()
        {
            if (panelWorkingHoursSubMenu.Visible == true)
                panelWorkingHoursSubMenu.Visible = false;
            if (panelLecturersSubMenu.Visible == true)
                panelLecturersSubMenu.Visible = false;
            if (panelSubjectsSubMenu.Visible == true)
                panelSubjectsSubMenu.Visible = false;
            if (panelStudentsSubMenu.Visible == true)
                panelStudentsSubMenu.Visible = false;
            if (panelTagsSubMenu.Visible == true)
                panelTagsSubMenu.Visible = false;
            if (panelLocationsSubMenu.Visible == true)
                panelLocationsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void defaultBtn()
        {
            btnDashBoard.BackColor = Color.FromArgb(51, 51, 76);
            btnWorkingHours.BackColor = Color.FromArgb(51, 51, 76);
            btnLecturers.BackColor = Color.FromArgb(51, 51, 76);
            btnSubjects.BackColor = Color.FromArgb(51, 51, 76);
            btnStudents.BackColor = Color.FromArgb(51, 51, 76);
            btnTags.BackColor = Color.FromArgb(51, 51, 76);
            btnLocations.BackColor = Color.FromArgb(51, 51, 76);
            //btnAddSession.BackColor = Color.FromArgb(224, 224, 224);
            //btnGenerate.BackColor = Color.FromArgb(224, 224, 224);
        }
        #endregion

        #region WorkingHours

        private void btnWorkingHours_Click(object sender, EventArgs e)
        {
            defaultBtn();
            btnWorkingHours.BackColor = Color.FromArgb(51, 51, 76);
            showSubMenu(panelWorkingHoursSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new AddWorkingDaysHours());

            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageWorkingDaysHours());

            hideSubMenu();
        }
        private void btnManageTimeSlots_Click(object sender, EventArgs e)
        {
            openChildForm(new AddTimeSlots());

            hideSubMenu();
        }

        #endregion

        #region DashBoard
        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            defaultBtn();
            btnDashBoard.BackColor = Color.FromArgb(51, 51, 76);

            openChildForm(new DashBoard());
            //..
            // your code
            //..

            hideSubMenu();
        }

        #endregion

        #region Lecturers
        private void btnLecturers_Click(object sender, EventArgs e)
        {
            defaultBtn();
            btnLecturers.BackColor = Color.FromArgb(51, 51, 76);
            showSubMenu(panelLecturersSubMenu);
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            openChildForm(new AddLecturer());
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void btnManageLecturers_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageLecturers());
            //..
            // your code
            //..

            hideSubMenu();
        }
        #endregion

        #region Subjects
        private void btnSubjects_Click(object sender, EventArgs e)
        {
            defaultBtn();
            btnSubjects.BackColor = Color.FromArgb(51, 51, 76);
            showSubMenu(panelSubjectsSubMenu);
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            openChildForm(new AddSubject());
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void btnManageSubjects_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageSubjects());
            //..
            // your code
            //..

            hideSubMenu();
        }

        #endregion

        #region Students
        private void btnStudents_Click(object sender, EventArgs e)
        {
            defaultBtn();
            btnStudents.BackColor = Color.FromArgb(51, 51, 76);
            showSubMenu(panelStudentsSubMenu);
        }

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            openChildForm(new AddStudent());
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudents());
            //..
            // your code
            //..

            hideSubMenu();
        }
        #endregion

        #region Tags
        private void btnTags_Click(object sender, EventArgs e)
        {
            defaultBtn();
            btnTags.BackColor = Color.FromArgb(51, 51, 76);
            showSubMenu(panelTagsSubMenu);
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            openChildForm(new AddTag());
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void btnManageTags_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageTags());
            //..
            // your code
            //..

            hideSubMenu();
        }
        #endregion

        #region Locations
        private void btnLocations_Click(object sender, EventArgs e)
        {
            defaultBtn();
            btnLocations.BackColor = Color.FromArgb(51, 51, 76);
            showSubMenu(panelLocationsSubMenu);
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            openChildForm(new AddLocations());
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void btnManageLocations_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageLocations());
            //..
            // your code
            //..

            hideSubMenu();
        }
        #endregion

        #region Time and Date
        private void loadTimeDate()
        {
            timerDateNTime.Start();
            textBoxTime.Text = DateTime.Now.ToLongTimeString();
            textBoxDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxTime.Text = DateTime.Now.ToLongTimeString();
            timerDateNTime.Start();
        }



        #endregion

        #region child form function
        private Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion


        private void btnAddSession_Click(object sender, EventArgs e)
        {
            defaultBtn();
            btnAddSession.BackColor = Color.FromArgb(224, 224, 224);

            openChildForm(new ManageSessionsMain());
            //..
            // your code
            //..

            hideSubMenu();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            defaultBtn();
            btnGenerate.BackColor = Color.FromArgb(224, 224, 224);

            openChildForm(new GenerateTimeTable());

            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            defaultBtn();
            btnAddSession.BackColor = Color.FromArgb(224, 224, 224);

            openChildForm(new AllocateSession());
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            defaultBtn();
            button7.BackColor = Color.FromArgb(224, 224, 224);

            openChildForm(new AllocateLocationMain());
            //..
            // your code
            //..

            hideSubMenu();
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}