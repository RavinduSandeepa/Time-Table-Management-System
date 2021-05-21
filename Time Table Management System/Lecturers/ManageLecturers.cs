using System;
using System.Collections;
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

namespace Time_Table_Management_System.Lecturers
{
    public partial class ManageLecturers : Form
    {
        private bool executedFirstTime;
        private Lecturer selectedLec;
        private ILecturerService lecturerService;
        public ManageLecturers()
        {
            InitializeComponent();
            executedFirstTime = true;
            lecturerService = new LecturerService();
            populateData();
        }

        private void populateData()
        {
            ILecturerService lecturerService = new LecturerService();
            List<Lecturer> lecturersArray = lecturerService.getAllLecturers();

            foreach(Lecturer lecturer in lecturersArray)
            {
                dataGridLecturers.Rows.Add(lecturer.Id, lecturer.Name, lecturer.EmployeeID, lecturer.Faculty, lecturer.Department, lecturer.Center, lecturer.Building, lecturer.Level, lecturer.Rank);
            }
            
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

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxLecturerName.Text == String.Empty)
            {
                textBoxLecturerName.Focus();
                //errorManageLecturers.SetError(textBoxLecturerName, "Please Enter Lecturer Name");
                MessageBox.Show("Please Enter Lecturer Name", "Error");
            }
            else if (comboBoxFaculty.SelectedIndex == -1)
            {
                comboBoxFaculty.Focus();
                //errorManageLecturers.SetError(comboBoxFaculty, "Please Select Faculty");
                MessageBox.Show("Please Select Faculty", "Error");
            }
            else if (textBoxDepartment.SelectedIndex == -1)
            {
                textBoxDepartment.Focus();
                //errorManageLecturers.SetError(textBoxDepartment, "Please Enter Department");
                MessageBox.Show("Please Select Department", "Error");
            }
            else if (comboBoxCenter.SelectedIndex == -1)
            {
                comboBoxCenter.Focus();
                //errorManageLecturers.SetError(comboBoxCenter, "Please Select Center");
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
                Lecturer lecturer = new Lecturer();

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
                if (lecturerService.updateLecturer(selectedLec.Id,lecturer))
                {
                    //SuccessMessage sc = new SuccessMessage("Lecturer Updated Successfully !");
                    //sc.Show();
                    MessageBox.Show("Lecturer Updated Successfully !");
                    dataGridLecturers.Rows.Clear();
                    populateData();
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

        private void dataGrid_Selection(object sender, EventArgs e)
        {
            if (executedFirstTime)
            {
                executedFirstTime = false;
                return;
            }
            try
            {
                int selectedIndex = dataGridLecturers.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if(dataGridLecturers.SelectedRows[0].Cells[0].Value != null)
                    {
                        int id = int.Parse(dataGridLecturers.SelectedRows[0].Cells[0].Value.ToString()); 
                        selectedLec = lecturerService.GetLecturer(id);

                        #region Set data to Fields
                        textBoxLecturerName.Text = selectedLec.Name;
                        textBoxEmployeeID.Text = selectedLec.EmployeeID;
                        switch (selectedLec.Faculty)
                        {
                            case "Computing": 
                                comboBoxFaculty.SelectedIndex = 0;
                                break;
                            case "Engineering":
                                comboBoxFaculty.SelectedIndex = 1;
                                break;
                            case "Business":
                                comboBoxFaculty.SelectedIndex = 2;
                                break;
                            case "Humanities & Sciences":
                                comboBoxFaculty.SelectedIndex = 3;
                                break;
                        }
                        textBoxDepartment.Text = selectedLec.Department;

                        switch (selectedLec.Center)
                        {
                            case "Malabe":
                                comboBoxCenter.SelectedIndex = 0;
                                break;
                            case "Metro":
                                comboBoxCenter.SelectedIndex = 1;
                                break;
                            case "Matara":
                                comboBoxCenter.SelectedIndex = 2;
                                break;
                            case "Kandy":
                                comboBoxCenter.SelectedIndex = 3;
                                break;
                            case "Kurunagala":
                                comboBoxCenter.SelectedIndex = 4;
                                break;
                            case "Jaffna":
                                comboBoxCenter.SelectedIndex = 5;
                                break;
                        }

                        switch (selectedLec.Building)
                        {
                            case "New building":
                                comboBoxBuilding.SelectedIndex = 0;
                                break;
                            case "A-block":
                                comboBoxBuilding.SelectedIndex = 1;
                                break;
                            case "B-block":
                                comboBoxBuilding.SelectedIndex = 2;
                                break;
                            case "C-block":
                                comboBoxBuilding.SelectedIndex = 3;
                                break;
                            case "D-block":
                                comboBoxBuilding.SelectedIndex = 4;
                                break;
                            case "E-block":
                                comboBoxBuilding.SelectedIndex = 5;
                                break;
                        }
                        switch (selectedLec.Level)
                        {
                            case 1: 
                                comboBoxLevel.SelectedIndex = 0;
                                break;
                            case 2:
                                comboBoxLevel.SelectedIndex = 1;
                                break;
                            case 3:
                                comboBoxLevel.SelectedIndex = 2;
                                break;
                            case 4:
                                comboBoxLevel.SelectedIndex = 3;
                                break;
                            case 5:
                                comboBoxLevel.SelectedIndex = 4;
                                break;
                            case 6:
                                comboBoxLevel.SelectedIndex = 5;
                                break;
                            case 7:
                                comboBoxLevel.SelectedIndex = 6;
                                break;
                        }
                        textBoxRank.Text = selectedLec.Rank;
                        #endregion

                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }


            }catch(ArgumentOutOfRangeException es)
            {
                Console.WriteLine(es.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lecturerService.deleteLecturer(selectedLec.Id))
            {
                //SuccessMessage sm = new SuccessMessage("Lecturer Removed Successfully");
                //sm.Show();
                MessageBox.Show("Lecturer Removed Successfully");
                dataGridLecturers.Rows.Clear();
                populateData();
                clear();
            }
            else
            {
                //ErrorMessage em = new ErrorMessage("Oops, Somthing went wrong..");
                //em.Show();
                MessageBox.Show("Oops, Somthing went wrong..");
            }
        }

        private void btnGenerateRank_Click(object sender, EventArgs e)
        {
            if (textBoxEmployeeID.Text == String.Empty)
            {
                textBoxEmployeeID.Focus();
                //errorManageLecturers.SetError(textBoxEmployeeID, "Please Enter Employee ID");
                MessageBox.Show("Please Enter Employee ID", "Error");
            }
            else if (textBoxEmployeeID.Text.Length != 6)
            {
                textBoxEmployeeID.Focus();
                MessageBox.Show("Please Enter Valid Employee ID, Employee ID should be 6 digits", "Error");
            }
            else if (comboBoxLevel.SelectedIndex == -1)
            {
                comboBoxLevel.Focus();
                //errorManageLecturers.SetError(comboBoxLevel, "Please Select Level");
                MessageBox.Show("Please Select Level", "Error");
            }
            else
            {
                textBoxRank.Text = comboBoxLevel.SelectedItem + "." + textBoxEmployeeID.Text.Trim();
                textBoxEmployeeID.ReadOnly = true;
                comboBoxLevel.Enabled = false;
                btnGenerateRank.Enabled = false;
            }
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

        private void ManageLecturers_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
