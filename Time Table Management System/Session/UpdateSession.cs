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
    public partial class UpdateSession : Form
    {
        private SessionDTO session = new SessionDTO();
        private ISessionService sessionService = new SessionService();
        private int selectedLecCount = 0;
        private int selectedSessionID;

        public UpdateSession(int id)
        {
            InitializeComponent();
            loadData();
            setData(id);
        }
        private void loadData()
        {
            // add Lecturers
            ILecturerService lecturerService = new LecturerService();
            List<Lecturer> lecList = new List<Lecturer>();
            List<String> lecNameList = new List<String>();
            lecList = lecturerService.getAllLecturers();

            foreach (Lecturer lec in lecList)
            {
                lecNameList.Add(lec.Name);
            }
            comboBoxLec.Items.AddRange(lecNameList.ToArray());

            // add tags
            ITagService tagService = new TagService();
            List<Tag> tagList = new List<Tag>();
            List<String> tagNameList = new List<String>();
            tagList = tagService.getAllTags();

            foreach (Tag tag in tagList)
            {
                tagNameList.Add(tag.RelatedTag);
            }
            comboBoxTag.Items.AddRange(tagNameList.ToArray());

            // add subject
            ISubjectService subjectService = new SubjectService();
            List<Subject> subList = new List<Subject>();
            List<String> subNameList = new List<String>();
            subList = subjectService.getAllSubjects();

            foreach (Subject sub in subList)
            {
                subNameList.Add(sub.SubjectName + " | " + sub.SubjectCode);
            }
            comboBoxSubject.Items.AddRange(subNameList.ToArray());
        }

        private void setData(int id)
        {
            SessionDTO selectedSession = new SessionDTO();
            ISessionService sessionService = new SessionService();
            selectedSession = sessionService.GetSession(id);

            selectedSessionID = selectedSession.Id;
            txtSelectedLec.Text = selectedSession.Lec1_name;
            session.Lec1_name = selectedSession.Lec1_name;
            selectedLecCount++;
            if (selectedSession.Lec2_name != null)
            {
                txtSelectedLec.Text = selectedSession.Lec1_name + " , " + selectedSession.Lec2_name;
                session.Lec2_name = selectedSession.Lec2_name;
                selectedLecCount++;
            }  
            comboBoxTag.SelectedItem = selectedSession.Tag;
            comboBoxGroup.SelectedItem = selectedSession.Group_code;
            comboBoxSubject.Text = selectedSession.Subject_name + " | " + selectedSession.Subject_code;
            txtNoOfStudents.Text = selectedSession.Student_count.ToString();
            txtDuration.Text = selectedSession.Duration.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            comboBoxGroup.SelectedIndex = -1;
            comboBoxSubject.SelectedIndex = -1;
            txtDuration.Text = String.Empty;
            txtNoOfStudents.Text = String.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxLec.SelectedIndex = -1;
            comboBoxTag.SelectedIndex = -1;
            txtSelectedLec.Text = String.Empty;
            selectedLecCount = 0;
            session.Lec1_name = null;
            session.Lec2_name = null;
            txtSelectedLec.Text = null;
        }

        private void comboBoxTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            // add group
            IStudentService studentService = new StudentService();
            List<Student> stuList = new List<Student>();
            List<String> stuNameList = new List<String>();
            stuList = studentService.getAllStudents();
            comboBoxGroup.Items.Clear();

            switch (comboBoxTag.SelectedItem)
            {
                case "Lecture":
                    txtNoOfStudents.Text = "120";
                    txtDuration.Text = "2";
                    foreach (Student stu in stuList)
                    {
                        stuNameList.Add(stu.GroupId);
                    }
                    comboBoxGroup.Items.AddRange(stuNameList.ToArray());
                    break;
                case "Tutorial":
                    txtNoOfStudents.Text = "120";
                    txtDuration.Text = "1";
                    foreach (Student stu in stuList)
                    {
                        stuNameList.Add(stu.GroupId);
                    }
                    comboBoxGroup.Items.AddRange(stuNameList.ToArray());
                    break;
                case "Lab":
                    txtNoOfStudents.Text = "60";
                    txtDuration.Text = "2";
                    foreach (Student stu in stuList)
                    {
                        stuNameList.Add(stu.SubGroupId);
                    }
                    comboBoxGroup.Items.AddRange(stuNameList.ToArray());
                    break;
            }
        }

        private void comboBoxLec_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLecCount++;
            if (selectedLecCount == 1)
            {
                session.Lec1_name = comboBoxLec.Text;
                txtSelectedLec.Text = session.Lec1_name;

            }
            else if (selectedLecCount == 2)
            {
                session.Lec2_name = comboBoxLec.Text;
                txtSelectedLec.Text = session.Lec1_name + " , " + session.Lec2_name;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //validation
            if (txtSelectedLec.Text == String.Empty)
            {
                comboBoxLec.Focus();
                MessageBox.Show("Please Select atleast 1 lecturer", "Error");
            }
            else if (comboBoxTag.SelectedIndex == -1)
            {
                comboBoxTag.Focus();
                MessageBox.Show("Please select Tag", "Error");
            }
            else if (comboBoxGroup.SelectedIndex == -1)
            {
                comboBoxGroup.Focus();
                MessageBox.Show("Please select Group", "Error");
            }
            else if (comboBoxSubject.SelectedIndex == -1)
            {
                comboBoxSubject.Focus();
                MessageBox.Show("Please select Subject", "Error");
            }
            else if (txtNoOfStudents.Text == String.Empty)
            {
                txtNoOfStudents.Focus();
                MessageBox.Show("Please enter Number of Students", "Error");
            }
            else if (txtDuration.Text == String.Empty)
            {
                txtDuration.Focus();
                MessageBox.Show("Please enter Session Duration", "Error");
            }
            else
            {
                // set data
                session.Tag = comboBoxTag.Text;
                session.Group_code = comboBoxGroup.Text;

                String subject = comboBoxSubject.Text;
                char[] spearator = { ',', ' ' };
                String[] strlist = subject.Split(spearator);
                session.Subject_name = strlist[0];
                session.Subject_code = strlist[2];

                session.Student_count = int.Parse(txtNoOfStudents.Text);
                session.Duration = int.Parse(txtDuration.Text);

                //Update Data
                if (sessionService.updateSession(selectedSessionID, session))
                {
                    this.Close();
                    //SuccessMessage sc = new SuccessMessage("Session Updated Successfully !");
                    //sc.Show();
                    MessageBox.Show("Session Updated Successfully !");
                }
                else
                {
                    //ErrorMessage ec = new ErrorMessage("Oops, Somthing went wrong!");
                    //ec.Show();
                    MessageBox.Show("Oops, Somthing went wrong!");
                }
            }
        }
    }
}
