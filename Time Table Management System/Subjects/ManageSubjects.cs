using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Messages;
using Time_Table_Management_System.Models;
using Time_Table_Management_System.Services;

namespace Time_Table_Management_System
{
    public partial class ManageSubjects : Form
    {
        private bool executedFirstTime;
        private Subject selectedSub;
        private ISubjectService subjectService;
        private List<Subject> subjectsArray;

        public ManageSubjects()
        {
            InitializeComponent();
            executedFirstTime = true;
            subjectService = new SubjectService();
            populateData();
        }

        private void populateData()
        {
            subjectsArray = new List<Subject>();
            subjectsArray = subjectService.getAllSubjects();

            foreach (Subject subject in subjectsArray)
            {
                dataGridSubjects.Rows.Add(subject.Id, subject.SubjectName, subject.SubjectCode, subject.OfferedYear, subject.OfferedSem, subject.LecHours, subject.TuteHours, subject.LabHours, subject.EvaluationHours);
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            textBoxSubName.Text = String.Empty;
            textBoxSubCode.Text = String.Empty;
            comboBoxOfferdYear.SelectedIndex = -1;
            radioButtonSem1.Checked = false;
            radioButtonSem2.Checked = false;
            numericLecHours.Value = 2;
            numericTuteHours.Value = 1;
            numericLabHours.Value = 2;
            numericEvaluationHours.Value = 1;

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            //validation
            if (comboBoxOfferdYear.SelectedIndex == -1)
            {
                comboBoxOfferdYear.Focus();
                //errorAddSubject.SetError(comboBoxOfferdYear, "Please Select offered Year");
                MessageBox.Show("Please Select offered Year", "Error");
            }
            else if (radioButtonSem1.Checked == false & radioButtonSem2.Checked == false)
            {
                //errorAddSubject.SetError(radioButtonSem2, "Please Select offered Semester");
                MessageBox.Show("Please Select offered Semester", "Error");
            }
            else if (textBoxSubName.Text == String.Empty)
            {
                textBoxSubName.Focus();
                //errorAddSubject.SetError(textBoxSubName, "Please Enter Subject Name");
                MessageBox.Show("Please Enter Subject Name", "Error");
            }
            else if (!new Regex("^[A-Z][a-z]*$").IsMatch(textBoxSubName.Text))
            {
                textBoxSubName.Focus();
                //errorAddSubject.SetError(textBoxSubName, "Please Enter Subject Name");
                MessageBox.Show("Please Enter Valid Subject Name, Subject Name should not contain any space", "Error");
            }
            else if (textBoxSubCode.Text == String.Empty)
            {
                textBoxSubCode.Focus();
                //errorAddSubject.SetError(textBoxSubCode, "Please Enter Subject Code");
                MessageBox.Show("Please Enter Subject Code", "Error");
            }
            else if (numericLecHours.Value <= 0 ^ numericLecHours.Value >= 5)
            {
                numericLecHours.Focus();
                //errorAddSubject.SetError(numericLecHours, "Please Enter Valid Number of Hours");
                MessageBox.Show("Please Enter Valid Number of Hours", "Error");
            }
            else if (numericTuteHours.Value <= 0 ^ numericTuteHours.Value >= 5)
            {
                numericTuteHours.Focus();
                //errorAddSubject.SetError(numericTuteHours, "Please Enter Valid Number of Hours");
                MessageBox.Show("Please Enter Valid Number of Hours", "Error");
            }
            else if (numericLabHours.Value <= 0 ^ numericLabHours.Value >= 5)
            {
                numericLabHours.Focus();
                //errorAddSubject.SetError(numericLabHours, "Please Enter Valid Number of Hours");
                MessageBox.Show("Please Enter Valid Number of Hours", "Error");
            }
            else if (numericEvaluationHours.Value <= 0 ^ numericEvaluationHours.Value >= 5)
            {
                numericEvaluationHours.Focus();
                //errorAddSubject.SetError(numericEvaluationHours, "Please Enter Valid Number of Hours");
                MessageBox.Show("Please Enter Valid Number of Hours", "Error");
            }
            #endregion
            else
            {
                Subject subject = new Subject();

                #region Set Data to Object
                // Set Data to model
                subject.SubjectName = textBoxSubName.Text.Trim();
                subject.SubjectCode = textBoxSubCode.Text.Trim();
                switch (comboBoxOfferdYear.SelectedIndex)
                {
                    case 0:
                        subject.OfferedYear = 1;
                        break;
                    case 1:
                        subject.OfferedYear = 2;
                        break;
                    case 2:
                        subject.OfferedYear = 3;
                        break;
                    case 3:
                        subject.OfferedYear = 4;
                        break;
                }

                if (radioButtonSem1.Checked == true)
                    subject.OfferedSem = 1;
                else
                    subject.OfferedSem = 2;

                subject.LecHours = int.Parse(numericLecHours.Value.ToString());
                subject.TuteHours = int.Parse(numericTuteHours.Value.ToString());
                subject.LabHours = int.Parse(numericLabHours.Value.ToString());
                subject.EvaluationHours = int.Parse(numericEvaluationHours.Value.ToString());
                #endregion

                //Update Data
                if (subjectService.updateSubject(selectedSub.Id,subject))
                {
                    //SuccessMessage sc = new SuccessMessage("Subject Updated Successfully !");
                    //sc.Show();
                    MessageBox.Show("Subject Updated Successfully !");
                    dataGridSubjects.Rows.Clear();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (subjectService.deleteSubject(selectedSub.Id))
            {
                //SuccessMessage sm = new SuccessMessage("Subject Deleted Successfully");
                //sm.Show();
                MessageBox.Show("Subject Deleted Successfully");
                dataGridSubjects.Rows.Clear();
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

        private void dataGrid_Selection(object sender, EventArgs e)
        {
            if (executedFirstTime)
            {
                executedFirstTime = false;
                return;
            }
            try
            {
                int selectedIndex = dataGridSubjects.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if (dataGridSubjects.SelectedRows[0].Cells[0].Value != null)
                    {
                        int id = int.Parse(dataGridSubjects.SelectedRows[0].Cells[0].Value.ToString());
                        selectedSub = subjectService.getSubject(id);

                        #region Set data to Fields
                        textBoxSubName.Text = selectedSub.SubjectName;
                        textBoxSubCode.Text = selectedSub.SubjectCode;
                        switch (selectedSub.OfferedYear)
                        {
                            case 1:
                                comboBoxOfferdYear.SelectedIndex = 0;
                                break;
                            case 2:
                                comboBoxOfferdYear.SelectedIndex = 1;
                                break;
                            case 3:
                                comboBoxOfferdYear.SelectedIndex = 2;
                                break;
                            case 4:
                                comboBoxOfferdYear.SelectedIndex = 3;
                                break;
                        }

                        if(selectedSub.OfferedSem == 1)
                        {
                            radioButtonSem1.Checked = true;
                        }
                        else
                        {
                            radioButtonSem2.Checked = true;
                        }

                        numericLecHours.Value = selectedSub.LecHours;
                        numericTuteHours.Value = selectedSub.TuteHours;
                        numericLabHours.Value = selectedSub.LabHours;
                        numericEvaluationHours.Value = selectedSub.EvaluationHours;
                        #endregion

                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }


            }
            catch (ArgumentOutOfRangeException es)
            {
                Console.WriteLine(es.Message);
            }
        }
    }
}
