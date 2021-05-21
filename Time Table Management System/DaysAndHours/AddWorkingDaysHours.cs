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

namespace Time_Table_Management_System.DaysAndHours
{
    public partial class AddWorkingDaysHours : Form
    {
        private WorkingDaysHours workingDaysHours = new WorkingDaysHours();
        private IWorkingDaysHoursService workingDaysHoursService;
        public AddWorkingDaysHours()
        {
            InitializeComponent();
            if (checkExistData())
            {
                getData();
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                btnSave.Visible = false;
                btnClear.Visible = false;
            }
        }

        private Boolean checkExistData()
        {
            workingDaysHoursService = new WorkingDaysHoursService();
            return workingDaysHoursService.getExistWorkingDaysHours();
        }

        private void getData()
        {
            workingDaysHoursService = new WorkingDaysHoursService();
            workingDaysHours = workingDaysHoursService.getWorkingDaysHours();

            // set data to fields
            numericNoOfDays.Value = workingDaysHours.NoOfWorkingDays;
            numericTPerDayHours.Value = workingDaysHours.NoOfHours;
            numericTPerDayMinutes.Value = workingDaysHours.NoOfMinutes;
            if (workingDaysHours.Monday == 1)
                checkBoxMonday.Checked = true;
            if (workingDaysHours.Tuesday == 1)
                checkBoxTuesday.Checked = true;
            if (workingDaysHours.Wednesday == 1)
                checkBoxWednesday.Checked = true;
            if (workingDaysHours.Thursday == 1)
                checkBoxThursday.Checked = true;
            if (workingDaysHours.Friday == 1)
                checkBoxFriday.Checked = true;
            if (workingDaysHours.Saturday == 1)
                checkBoxSaturday.Checked = true;
            if (workingDaysHours.Sunday == 1)
                checkBoxSunday.Checked = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear()
        {
            numericNoOfDays.Value = 0;
            checkBoxMonday.Checked = false;
            checkBoxTuesday.Checked = false;
            checkBoxWednesday.Checked = false;
            checkBoxThursday.Checked = false;
            checkBoxFriday.Checked = false;
            checkBoxSaturday.Checked = false;
            checkBoxSunday.Checked = false;
            numericTPerDayHours.Value = 0;
            numericTPerDayMinutes.Value = 0;
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            #region adding validation
            if (numericNoOfDays.Value < 1 ^ numericNoOfDays.Value > 7)
            {
                numericNoOfDays.Focus();
                errorAddWorkingDays.SetError(numericNoOfDays, "Please Enter Valid No Of Working Days");
            }
            else if (checkBoxMonday.Checked == false & checkBoxTuesday.Checked == false & checkBoxWednesday.Checked == false & checkBoxThursday.Checked == false & checkBoxFriday.Checked == false & checkBoxSaturday.Checked == false & checkBoxSunday.Checked == false)
            {
                ErrorMessage em = new ErrorMessage("Please Select One More Working Days");
                em.Show();
            }
            else if (numericTPerDayHours.Value < 0 ^ numericTPerDayHours.Value > 24)
            {
                numericTPerDayHours.Focus();
                errorAddWorkingDays.SetError(numericTPerDayHours, "Please Enter Valid No Of Working Hours");
            }
            else if (numericTPerDayMinutes.Value < 0 ^ numericTPerDayMinutes.Value > 60)
            {
                numericTPerDayMinutes.Focus();
                errorAddWorkingDays.SetError(numericTPerDayMinutes, "Please Enter Valid No Of Working Minutes");
            }
            #endregion
            else
            {
                workingDaysHoursService = new WorkingDaysHoursService();

                #region Set Data to Object
                // Set Data to model
                workingDaysHours.NoOfWorkingDays = int.Parse(numericNoOfDays.Value.ToString());
                workingDaysHours.NoOfHours = int.Parse(numericTPerDayHours.Value.ToString());
                workingDaysHours.NoOfMinutes = int.Parse(numericTPerDayMinutes.Value.ToString());

                // Check Days Monday
                if (checkBoxMonday.Checked == true)
                    workingDaysHours.Monday = 1;
                else
                    workingDaysHours.Monday = 0;

                // Check Days Tuesday
                if (checkBoxTuesday.Checked == true)
                    workingDaysHours.Tuesday = 1;
                else
                    workingDaysHours.Tuesday = 0;

                // Check Days Wednesday
                if (checkBoxWednesday.Checked == true)
                    workingDaysHours.Wednesday = 1;
                else
                    workingDaysHours.Wednesday = 0;

                // Check Days Thursday
                if (checkBoxThursday.Checked == true)
                    workingDaysHours.Thursday = 1;
                else
                    workingDaysHours.Thursday = 0;

                // Check Days Friday
                if (checkBoxFriday.Checked == true)
                    workingDaysHours.Friday = 1;
                else
                    workingDaysHours.Friday = 0;

                // Check Days Saturday
                if (checkBoxSaturday.Checked == true)
                    workingDaysHours.Saturday = 1;
                else
                    workingDaysHours.Saturday = 0;

                // Check Days Sunday
                if (checkBoxSunday.Checked == true)
                    workingDaysHours.Sunday = 1;
                else
                    workingDaysHours.Sunday = 0;
                #endregion

                //Insert Data
                if (workingDaysHoursService.addWorkingDaysHours(workingDaysHours))
                {
                    
                    MessageBox.Show("Working Days And Hours Added Successfully !");
                    getData();
                    btnUpdate.Visible = true;
                    btnDelete.Visible = true;
                    btnSave.Visible = false;
                    btnClear.Visible = false;
                }
                else
                {
                    
                    MessageBox.Show("Oops, Somthing went wrong! You Should Have Active Internet Connection to Run This!!!");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        #region checks functions
        private void checkBoxMonday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int noOFDays = 0;
                if (checkBoxMonday.Checked == true)
                    noOFDays++;
                if (checkBoxTuesday.Checked == true)
                    noOFDays++;
                if (checkBoxWednesday.Checked == true)
                    noOFDays++;
                if (checkBoxThursday.Checked == true)
                    noOFDays++;
                if (checkBoxFriday.Checked == true)
                    noOFDays++;
                if (checkBoxSaturday.Checked == true)
                    noOFDays++;
                if (checkBoxSunday.Checked == true)
                    noOFDays++;

                numericNoOfDays.Value = noOFDays;
            }
            catch (Exception eMonday)
            {
                if (eMonday.Message == "")
                {

                }
            }

        }

        private void checkBoxTuesday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int noOFDays = 0;
                if (checkBoxMonday.Checked == true)
                    noOFDays++;
                if (checkBoxTuesday.Checked == true)
                    noOFDays++;
                if (checkBoxWednesday.Checked == true)
                    noOFDays++;
                if (checkBoxThursday.Checked == true)
                    noOFDays++;
                if (checkBoxFriday.Checked == true)
                    noOFDays++;
                if (checkBoxSaturday.Checked == true)
                    noOFDays++;
                if (checkBoxSunday.Checked == true)
                    noOFDays++;

                numericNoOfDays.Value = noOFDays;
            }
            catch (Exception eTuesday)
            {
                if (eTuesday.Message == "")
                {

                }
            }



        }

        private void checkBoxWednesday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int noOFDays = 0;
                if (checkBoxMonday.Checked == true)
                    noOFDays++;
                if (checkBoxTuesday.Checked == true)
                    noOFDays++;
                if (checkBoxWednesday.Checked == true)
                    noOFDays++;
                if (checkBoxThursday.Checked == true)
                    noOFDays++;
                if (checkBoxFriday.Checked == true)
                    noOFDays++;
                if (checkBoxSaturday.Checked == true)
                    noOFDays++;
                if (checkBoxSunday.Checked == true)
                    noOFDays++;

                numericNoOfDays.Value = noOFDays;
            }
            catch (Exception eWednesday)
            {
                if (eWednesday.Message == "")
                {

                }
            }


        }

        private void checkBoxThursday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int noOFDays = 0;
                if (checkBoxMonday.Checked == true)
                    noOFDays++;
                if (checkBoxTuesday.Checked == true)
                    noOFDays++;
                if (checkBoxWednesday.Checked == true)
                    noOFDays++;
                if (checkBoxThursday.Checked == true)
                    noOFDays++;
                if (checkBoxFriday.Checked == true)
                    noOFDays++;
                if (checkBoxSaturday.Checked == true)
                    noOFDays++;
                if (checkBoxSunday.Checked == true)
                    noOFDays++;

                numericNoOfDays.Value = noOFDays;
            }
            catch (Exception eThursday)
            {
                if (eThursday.Message == "")
                {

                }
            }

        }

        private void checkBoxFriday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int noOFDays = 0;
                if (checkBoxMonday.Checked == true)
                    noOFDays++;
                if (checkBoxTuesday.Checked == true)
                    noOFDays++;
                if (checkBoxWednesday.Checked == true)
                    noOFDays++;
                if (checkBoxThursday.Checked == true)
                    noOFDays++;
                if (checkBoxFriday.Checked == true)
                    noOFDays++;
                if (checkBoxSaturday.Checked == true)
                    noOFDays++;
                if (checkBoxSunday.Checked == true)
                    noOFDays++;

                numericNoOfDays.Value = noOFDays;
            }
            catch (Exception eFriday)
            {
                if (eFriday.Message == "")
                {

                }
            }

        }

        private void checkBoxSaturday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int noOFDays = 0;
                if (checkBoxMonday.Checked == true)
                    noOFDays++;
                if (checkBoxTuesday.Checked == true)
                    noOFDays++;
                if (checkBoxWednesday.Checked == true)
                    noOFDays++;
                if (checkBoxThursday.Checked == true)
                    noOFDays++;
                if (checkBoxFriday.Checked == true)
                    noOFDays++;
                if (checkBoxSaturday.Checked == true)
                    noOFDays++;
                if (checkBoxSunday.Checked == true)
                    noOFDays++;

                numericNoOfDays.Value = noOFDays;
            }
            catch (Exception eSaturday)
            {
                if (eSaturday.Message == "")
                {

                }
            }

        }

        private void checkBoxSunday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int noOFDays = 0;
                if (checkBoxMonday.Checked == true)
                    noOFDays++;
                if (checkBoxTuesday.Checked == true)
                    noOFDays++;
                if (checkBoxWednesday.Checked == true)
                    noOFDays++;
                if (checkBoxThursday.Checked == true)
                    noOFDays++;
                if (checkBoxFriday.Checked == true)
                    noOFDays++;
                if (checkBoxSaturday.Checked == true)
                    noOFDays++;
                if (checkBoxSunday.Checked == true)
                    noOFDays++;

                numericNoOfDays.Value = noOFDays;
            }
            catch (Exception eSunday)
            {
                if (eSunday.Message == "")
                {

                }
            }

        }

        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            workingDaysHoursService = new WorkingDaysHoursService();
            if (workingDaysHoursService.deleteWorkingDaysHours())
            {
                
                MessageBox.Show("All Data Related to Working Days / Hours Deleted!");
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                btnSave.Visible = true;
                btnClear.Visible = true;
                clear();
            }
            else
            {
                
                MessageBox.Show("Ooops...Something went wrong");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            #region adding validation
            if (numericNoOfDays.Value < 1 ^ numericNoOfDays.Value > 7)
            {
                numericNoOfDays.Focus();
                errorAddWorkingDays.SetError(numericNoOfDays, "Please Enter Valid No Of Working Days");
            }
            else if (checkBoxMonday.Checked == false & checkBoxTuesday.Checked == false & checkBoxWednesday.Checked == false & checkBoxThursday.Checked == false & checkBoxFriday.Checked == false & checkBoxSaturday.Checked == false & checkBoxSunday.Checked == false)
            {
                ErrorMessage em = new ErrorMessage("Please Select One or More Working Days");
                em.Show();
            }
            else if (numericTPerDayHours.Value < 0 ^ numericTPerDayHours.Value > 24)
            {
                numericTPerDayHours.Focus();
                errorAddWorkingDays.SetError(numericTPerDayHours, "Please Enter Valid No Of Working Hours");
            }
            else if (numericTPerDayMinutes.Value < 0 ^ numericTPerDayMinutes.Value > 60)
            {
                numericTPerDayMinutes.Focus();
                errorAddWorkingDays.SetError(numericTPerDayMinutes, "Please Enter Valid No Of Working Minutes");
            }
            #endregion
            else
            {
                workingDaysHoursService = new WorkingDaysHoursService();
                WorkingDaysHours workingDaysHoursUpdate = new WorkingDaysHours();

                #region Set Data to Object
                // Set Data to model
                workingDaysHoursUpdate.NoOfWorkingDays = int.Parse(numericNoOfDays.Value.ToString());
                workingDaysHoursUpdate.NoOfHours = int.Parse(numericTPerDayHours.Value.ToString());
                workingDaysHoursUpdate.NoOfMinutes = int.Parse(numericTPerDayMinutes.Value.ToString());

                // Check Days Monday
                if (checkBoxMonday.Checked == true)
                    workingDaysHoursUpdate.Monday = 1;
                else
                    workingDaysHoursUpdate.Monday = 0;

                // Check Days Tuesday
                if (checkBoxTuesday.Checked == true)
                    workingDaysHoursUpdate.Tuesday = 1;
                else
                    workingDaysHoursUpdate.Tuesday = 0;

                // Check Days Wednesday
                if (checkBoxWednesday.Checked == true)
                    workingDaysHoursUpdate.Wednesday = 1;
                else
                    workingDaysHoursUpdate.Wednesday = 0;

                // Check Days Thursday
                if (checkBoxThursday.Checked == true)
                    workingDaysHoursUpdate.Thursday = 1;
                else
                    workingDaysHoursUpdate.Thursday = 0;

                // Check Days Friday
                if (checkBoxFriday.Checked == true)
                    workingDaysHoursUpdate.Friday = 1;
                else
                    workingDaysHoursUpdate.Friday = 0;

                // Check Days Saturday
                if (checkBoxSaturday.Checked == true)
                    workingDaysHoursUpdate.Saturday = 1;
                else
                    workingDaysHoursUpdate.Saturday = 0;

                // Check Days Sunday
                if (checkBoxSunday.Checked == true)
                    workingDaysHoursUpdate.Sunday = 1;
                else
                    workingDaysHoursUpdate.Sunday = 0;
                #endregion

                if (workingDaysHoursService.deleteWorkingDaysHours())
                {
                    if (workingDaysHoursService.addWorkingDaysHours(workingDaysHoursUpdate))
                    {
                      
                        MessageBox.Show("Working Days / Hours Updated Succesfully!");
                    } 
                }
                else
                {
                    
                    MessageBox.Show("Ooops...Something went wrong");
                }
            }
            
        }

        private void numericNoOfDays_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddWorkingDaysHours_Load(object sender, EventArgs e)
        {

        }
    }
}
