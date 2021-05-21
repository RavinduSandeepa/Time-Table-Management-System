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
using Time_Table_Management_System.Messages;
using Time_Table_Management_System.Services;
using System.Text.RegularExpressions;

namespace Time_Table_Management_System
{
    public partial class AddSubject : Form
    {
        public AddSubject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            comboBoxOfferdYear.SelectedIndex = -1;
            radioButtonSem1.Checked = false;
            radioButtonSem2.Checked = false;
            textBoxSubName.Text = "";
            textBoxSubCode.Text = "";
            numericLecHours.Value = 2;
            numericTuteHours.Value = 1;
            numericLabHours.Value = 2;
            numericEvaluationHours.Value = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Validation
            //validation
            if (comboBoxOfferdYear.SelectedIndex == -1)
            {
                comboBoxOfferdYear.Focus();
                //errorAddSubject.SetError(comboBoxOfferdYear, "Please Select offered Year");
                MessageBox.Show("Please Select offered Year", "Error");
            }
            else if(radioButtonSem1.Checked==false & radioButtonSem2.Checked == false)
            {
                //errorAddSubject.SetError(radioButtonSem2, "Please Select offered Semester");
                MessageBox.Show("Please Select offered Semester", "Error");
            }
            else if(textBoxSubName.Text == String.Empty)
            {
                textBoxSubName.Focus();
                //errorAddSubject.SetError(textBoxSubName, "Please Enter Subject Name");
                MessageBox.Show("Please Enter Subject Name, Subject Name should not contain any space", "Error");
            }
            else if(textBoxSubCode.Text == String.Empty)
            {
                textBoxSubCode.Focus();
                //errorAddSubject.SetError(textBoxSubCode, "Please Enter Subject Code");
                MessageBox.Show("Please Enter Subject Code", "Error");
            }
            else if(numericLecHours.Value <= 0 ^ numericLecHours.Value >= 5){
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
                ISubjectService subjectService = new SubjectService();

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

                //Insert Data
                if (subjectService.addSubject(subject))
                {
                    //MessageBox.Show(subject.SubjectName);
                    //SuccessMessage sc = new SuccessMessage("Subject Added Successfully !");
                    //sc.Show();
                    MessageBox.Show("Subject Added Successfully !");
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

    }
}
