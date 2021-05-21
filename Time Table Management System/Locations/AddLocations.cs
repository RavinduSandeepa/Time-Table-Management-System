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

namespace Time_Table_Management_System.Locations
{
    public partial class AddLocations : Form
    {
        public AddLocations()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonSem1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxBuildingName.Text = "";
            textBoxRoomName.Text = "";
            radioButtonLectureHall.Checked = false;
            radioButtonLaboratory.Checked = false;
            textBoxCapacity.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxBuildingName.Text == String.Empty)
            {
                comboBoxBuildingName.Focus();
                errorLocation.SetError(comboBoxBuildingName, "Please Select Building");
            }
            else if (textBoxRoomName.Text == String.Empty)
            {
                textBoxRoomName.Focus();
                errorLocation.SetError(textBoxRoomName, "Please Enter Subject Code");
            }

            else if (radioButtonLectureHall.Checked == false & radioButtonLaboratory.Checked == false)
            {
                errorLocation.SetError(radioButtonLectureHall, "Please Select Room Type");
            }
            else if (textBoxCapacity.Text == String.Empty)
            {
                textBoxCapacity.Focus();
                errorLocation.SetError(textBoxCapacity, "Please Enter Capacity");
            }
            else
            {
                Location location = new Location();
                ILocationService locationService = new LocationService();

                // Set Data

                location.BuildingName = comboBoxBuildingName.Text.Trim();
                location.RoomName = textBoxRoomName.Text.Trim();

                if (radioButtonLectureHall.Checked == true)
                    location.RoomType = "Lecture Hall";
                else
                    location.RoomType = "Laboratory";

                location.Capacity = textBoxCapacity.Text.Trim();

                //Insert Data
                if (locationService.addLocation(location))
                {
                    //MessageBox.Show(tag.Tag);
                    //SuccessMessage sc = new SuccessMessage("Locations Added Successfully !");
                    //sc.Show();
                    MessageBox.Show("Locations Added Successfully !");
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBuilduing_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddLocations_Load(object sender, EventArgs e)
        {

        }
    }
}
