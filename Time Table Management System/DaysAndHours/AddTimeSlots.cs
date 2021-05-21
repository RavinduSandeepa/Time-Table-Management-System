using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Messages;
using Time_Table_Management_System.Models;
using Time_Table_Management_System.Services;

namespace Time_Table_Management_System.DaysAndHours
{
    public partial class AddTimeSlots : Form
    {
        private TimeSlot timeSlot = new TimeSlot();
        private bool executedFirstTime;
        private TimeSlot selectedTimeSlot;
        private ITimeSlotService timeSlotService;

        public AddTimeSlots()
        {
            InitializeComponent();
            executedFirstTime = true;
            timeSlotService = new TimeSlotService();
            populateData();
        }

        private void populateData()
        {
            List<TimeSlot> timeSlotsArray = new List<TimeSlot>();
            timeSlotsArray = timeSlotService.getAllTimeSlots();

            foreach (TimeSlot timeSlot in timeSlotsArray)
            {
                dataGridTimeSlots.Rows.Add(timeSlot.Id, timeSlot.StHours + " : " + timeSlot.StMinutes, timeSlot.EtHours + " : " + timeSlot.EtMinutes, timeSlot.Duration);
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear()
        {
            numericSThours.Value = 0;
            comboBoxSTMinutes.SelectedIndex = -1;
            ETHours.Text = String.Empty;
            ETMinutes.Text = String.Empty;
            comboBoxDuration.SelectedIndex = -1;

        }

        private void btnAddTimeSlot_Click(object sender, EventArgs e)
        {
            if (numericSThours.Value < 0 ^ numericSThours.Value > 24)
            {
                numericSThours.Focus();
                errorProviderTimeSlot.SetError(numericSThours, "Please Enter Valid Hours");
                clear();
            }
            else if (comboBoxSTMinutes.SelectedIndex == -1)
            {
                comboBoxSTMinutes.Focus();
                errorProviderTimeSlot.SetError(comboBoxSTMinutes, "Please Select Valid Minutes");
                clear();
            }


            else if (comboBoxDuration.SelectedIndex == -1)
            {
                comboBoxDuration.Focus();
                errorProviderTimeSlot.SetError(comboBoxDuration, "Please Select Valid Time Slot");
                clear();
            }

            else if (ETHours.Text == String.Empty)
            {
                ETHours.Focus();
                errorProviderTimeSlot.SetError(ETHours, "Please generate end time");
                clear();
            }
            else if (ETMinutes.Text == String.Empty) {
                ETMinutes.Focus();
                errorProviderTimeSlot.SetError(ETMinutes, "Please generate end time");
                clear();
            }
            

            else
            {
                ITimeSlotService timeSlotService = new TimeSlotService();

                #region Set Data to Object
                // Set Data to model
                timeSlot.StHours = int.Parse(numericSThours.Value.ToString());
                timeSlot.StMinutes = int.Parse(comboBoxSTMinutes.SelectedItem.ToString());
                timeSlot.EtHours = int.Parse(ETHours.Text.Trim());
                timeSlot.EtMinutes = int.Parse(ETMinutes.Text.Trim());
                timeSlot.Duration = comboBoxDuration.SelectedItem.ToString();

                
                #endregion

                //Insert Data
                if (timeSlotService.addTimeSlots(timeSlot))
                {
                    //SuccessMessage sc = new SuccessMessage("Working Days And Hours Added Successfully !");
                    //sc.Show();
                    MessageBox.Show("Working Days And Hours Added Successfully !");
                    dataGridTimeSlots.Rows.Clear();
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
                int selectedIndex = dataGridTimeSlots.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if (dataGridTimeSlots.SelectedRows[0].Cells[0].Value != null)
                    {
                        int id = int.Parse(dataGridTimeSlots.SelectedRows[0].Cells[0].Value.ToString());
                        selectedTimeSlot = timeSlotService.getTimeSlot(id);

                        #region Set data to Fields
                        numericSThours.Value = selectedTimeSlot.StHours;

                        switch (selectedTimeSlot.StMinutes)
                        {
                            case 00:
                                comboBoxSTMinutes.SelectedIndex = 0;
                                break;
                            case 30:
                                comboBoxSTMinutes.SelectedIndex = 1;
                                break;
                           
                        }

                        ETHours.Text = selectedTimeSlot.EtHours.ToString();
                        ETMinutes.Text = selectedTimeSlot.EtMinutes.ToString();

                        switch (selectedTimeSlot.Duration)
                        {
                            case "30 Minutes":
                                comboBoxDuration.SelectedIndex = 0;
                                break;
                            case "1 Hour":
                                comboBoxDuration.SelectedIndex = 1;
                                break;

                            case "2 Hours":
                                comboBoxDuration.SelectedIndex = 2;
                                break;

                        }

                        #endregion

                    }
                }


            }
            catch (ArgumentOutOfRangeException es)
            {
                Console.WriteLine(es.Message);
            }
        }

        

        private void btnGenerateRank_Click(object sender, EventArgs e)
        {

            if (numericSThours.Value < 0 ^ numericSThours.Value > 24)
            {
                numericSThours.Focus();
                errorProviderTimeSlot.SetError(numericSThours, "Please Enter Valid Hours");
                clear();
            }
            else if (comboBoxSTMinutes.SelectedIndex == -1)
            {
                comboBoxSTMinutes.Focus();
                errorProviderTimeSlot.SetError(comboBoxSTMinutes, "Please Select Valid Minutes");
                clear();
            }


            else if (comboBoxDuration.SelectedIndex == -1)
            {
                comboBoxDuration.Focus();
                errorProviderTimeSlot.SetError(comboBoxDuration, "Please Select Valid Time Slot");
                clear();
            }
            else {

                try
                {

                    if (comboBoxDuration.SelectedItem.Equals("30 Minutes"))
                    {

                        if (comboBoxSTMinutes.SelectedItem.Equals("30"))
                        {

                            ETMinutes.Text = "00";
                            ETHours.Text = (numericSThours.Value + 1).ToString();
                        }
                        else if (comboBoxSTMinutes.SelectedItem.Equals("00"))
                        {

                            ETMinutes.Text = "30";
                            ETHours.Text = numericSThours.Value.ToString();
                        }
                    }
                    else if (comboBoxDuration.SelectedItem.Equals("1 Hour"))
                    {

                        if (comboBoxSTMinutes.SelectedItem.Equals("30"))
                        {

                            ETMinutes.Text = "30";
                            ETHours.Text = (numericSThours.Value + 1).ToString();
                        }
                        else if (comboBoxSTMinutes.SelectedItem.Equals("00"))
                        {

                            ETMinutes.Text = "00";
                            ETHours.Text = (numericSThours.Value + 1).ToString();
                        }

                    }
                    else if (comboBoxDuration.SelectedItem.Equals("2 Hours"))
                    {


                        if (comboBoxSTMinutes.SelectedItem.Equals("30"))
                        {

                            ETMinutes.Text = "30";
                            ETHours.Text = (numericSThours.Value + 2).ToString();
                        }
                        else if (comboBoxSTMinutes.SelectedItem.Equals("00"))
                        {

                            ETMinutes.Text = "00";
                            ETHours.Text = (numericSThours.Value + 2).ToString();
                        }

                    }

                }
                catch (Exception eDuration)
                {


                }

            }

        }

        private void btnDeleteTimeSlot_Click(object sender, EventArgs e)
        {
            if (timeSlotService.deleteTimeSlot(selectedTimeSlot.Id))
            {
                //SuccessMessage sm = new SuccessMessage("Timeslot Deleted Successfully");
                //sm.Show();
                MessageBox.Show("Timeslot Deleted Successfully");
                dataGridTimeSlots.Rows.Clear();
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


    

    

    
    }
}
