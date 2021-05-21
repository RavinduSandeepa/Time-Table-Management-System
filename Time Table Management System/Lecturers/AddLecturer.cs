using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Time_Table_Management_System.Messages;
using Time_Table_Management_System.Models;
using Time_Table_Management_System.Services;

namespace Time_Table_Management_System.Lecturers
{
    public partial class AddLecturer : Form
    {
        private Lecturer lecturer = new Lecturer();

        public AddLecturer()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            textBoxLecturerName.Text = String.Empty;
            textBoxEmployeeID.Text = String.Empty;
            comboBoxFaculty.SelectedIndex = -1;
            textBoxDepartment.Text = String.Empty;
            comboBoxCenter.SelectedIndex = -1;
            comboBoxBuilding.SelectedIndex = -1;
            comboBoxLevel.SelectedIndex = -1;
            textBoxRank.Text = String.Empty;
            textBoxEmployeeID.ReadOnly = false;
            comboBoxLevel.Enabled = true;
            btnGenerateRank.Enabled = true;
        }

        private void btnGenerateRank_Click(object sender, EventArgs e)
        {
            if (textBoxEmployeeID.Text == String.Empty)
            {
                textBoxEmployeeID.Focus();
                //errorAddLecturer.SetError(textBoxEmployeeID, "Please Enter Employee ID");
                MessageBox.Show("Please Enter Employee ID", "Error");
            }
            else if(textBoxEmployeeID.Text.Length != 6)
            {
                textBoxEmployeeID.Focus();
                MessageBox.Show("Please Enter Valid Employee ID, Employee ID should be 6 digits", "Error");
            }
            else if(comboBoxLevel.SelectedIndex == -1)
            {
                comboBoxLevel.Focus();
                //errorAddLecturer.SetError(comboBoxLevel, "Please Select Level");
                MessageBox.Show("Please Select Level", "Error");
            }
            else
            {
                lecturer.Rank = comboBoxLevel.SelectedItem + "." + textBoxEmployeeID.Text.Trim();
                textBoxRank.Text = lecturer.Rank;
                textBoxEmployeeID.ReadOnly = true;
                comboBoxLevel.Enabled = false;
                btnGenerateRank.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxLecturerName.Text == String.Empty)
            {
                textBoxLecturerName.Focus();
                //errorAddLecturer.SetError(textBoxLecturerName, "Please Enter Lecturer Name");
                MessageBox.Show("Please Enter Lecturer Name", "Error");
            }
            else if (comboBoxFaculty.SelectedIndex == -1)
            {
                comboBoxFaculty.Focus();
                //errorAddLecturer.SetError(comboBoxFaculty, "Please Select Faculty");
                MessageBox.Show("Please Select Faculty", "Error");
            }
            else if (textBoxDepartment.SelectedIndex == -1)
            {
                textBoxDepartment.Focus();
                //errorAddLecturer.SetError(textBoxDepartment, "Please Enter Department");
                MessageBox.Show("Please Select Department", "Error");
            }
            else if (comboBoxCenter.SelectedIndex == -1)
            {
                comboBoxCenter.Focus();
                //errorAddLecturer.SetError(comboBoxCenter, "Please Select Center");
                MessageBox.Show("Please Select Center", "Error");
            }
            else if (comboBoxBuilding.SelectedIndex == -1)
            {
                comboBoxBuilding.Focus();
                MessageBox.Show("Please Select Building", "Error");
            }
            else if (textBoxRank.Text == String.Empty)
            {
                btnGenerateRank.Focus();
                //ErrorMessage em = new ErrorMessage("Please Generate Rank before Save");
                //em.Show();
                MessageBox.Show("Please Generate Rank before Save");
            }
            else
            {
                ILecturerService lecturerService = new LecturerService();

                #region Set Data to Object
                // Set Data to model
                lecturer.Name = textBoxLecturerName.Text.Trim();
                lecturer.EmployeeID = textBoxEmployeeID.Text.Trim();
                lecturer.Faculty = comboBoxFaculty.SelectedItem.ToString();
                lecturer.Department = textBoxDepartment.Text.Trim();
                lecturer.Center = comboBoxCenter.SelectedItem.ToString();
                lecturer.Building = comboBoxBuilding.SelectedItem.ToString();
                lecturer.Level = int.Parse(comboBoxLevel.SelectedItem.ToString());
                lecturer.Rank = textBoxRank.Text.Trim();
                #endregion

                //Insert Data
                if (lecturerService.addLecturer(lecturer))
                {
                    //SuccessMessage sc = new SuccessMessage("Lecturer Added Successfully !");
                    //sc.Show();
                    MessageBox.Show("Lecturer Added Successfully !");
                    clear();


                }
                else
                {
                    //ErrorMessage ec = new ErrorMessage("Oops, Somthing went wrong!");
                    //ec.Show();
                    MessageBox.Show("Oops, Somthing went wrong!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<String> items = new List<String>();
            textBoxDepartment.Items.Clear();

            switch (comboBoxFaculty.SelectedItem)
            {
                case "Computing": 
                    items.Add("Information Technology");
                    items.Add("Software Engineering");
                    items.Add("Cyber Security");
                    items.Add("Data Science");
                    items.Add("Information System engineering");
                    items.Add("Computer Systems and Network");
                    items.Add("Interactive Media");
                    break;
                case "Engineering":
                    items.Add("Civil Engineering");
                    items.Add("Electrical & Electronic Engineering");
                    items.Add("Mechanical Engineering");
                    items.Add("Mechatronic");
                    items.Add("Materials Engineering");
                    items.Add("Architecture");
                    items.Add("Quantity Surveying");
                    break;
                case "Business":
                    items.Add("Accounting & Finance");
                    items.Add("Business Analytics");
                    items.Add("Human Capital Management");
                    items.Add("Marketing Management");
                    items.Add("Logistics & Supply Chain Management");
                    break;
                case "Humanities & Sciences":
                    items.Add("Biotechnology");
                    items.Add("Education");
                    items.Add("Law");
                    items.Add("Mathematics");
                    items.Add("Nursing");
                    items.Add("Psychology");
                    break;
                case "Architecture":
                    items.Add("Architecture");
                    break;
                case "Hospitality & Culinary":
                    items.Add("Hospitality Management");
                    items.Add("Commercial Cookery");
                    items.Add("Event Management");
                    items.Add("Patisserie Programme");
                    break;
            }
            textBoxDepartment.Items.AddRange(items.ToArray());
        }
    }
}
