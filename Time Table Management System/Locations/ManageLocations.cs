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


namespace Time_Table_Management_System.Locations
{
    public partial class ManageLocations : Form
    {
        private bool executedFirstTime;
        private ILocationService locationService;
        private Location selectedLoc;


        public ManageLocations()
        {
            InitializeComponent();
            executedFirstTime = true;
            locationService = new LocationService();
            populateData();
        }
        private void populateData()
        {
            ILocationService locationService = new LocationService();
            List<Location> locationsArray = locationService.getAllLocations();

            foreach (Location location in locationsArray)
            {
                dataGridLocations.Rows.Add(location.Id, location.BuildingName, location.RoomName, location.RoomType, location.Capacity);
            }

        }




        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void btnClear_Click(object sender, EventArgs e)
        {


            clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                int selectedIndex = dataGridLocations.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if (dataGridLocations.SelectedRows[0].Cells[0].Value != null)
                    {
                        int id = int.Parse(dataGridLocations.SelectedRows[0].Cells[0].Value.ToString());
                        selectedLoc = locationService.GetLocation(id);

                        #region Set data to Fields
                        textBoxBuildName.Text = selectedLoc.BuildingName;
                        textBoxRoomName.Text = selectedLoc.RoomName;


                        if (selectedLoc.RoomType == "Lecture Hall")
                        {
                            radioButtonLectureHall.Checked = true;
                        }
                        else
                        {
                            radioButtonLaboratory.Checked = true;
                        }

                        textBoxCapacity.Text = selectedLoc.Capacity;
                       
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           if (textBoxBuildName.Text == String.Empty)
            {
                textBoxBuildName.Focus();
                errorLocation.SetError(textBoxBuildName, "Please Enter Building Name");
            }
            else if (textBoxRoomName.Text == String.Empty)
            {
                textBoxRoomName.Focus();
                errorLocation.SetError(textBoxRoomName, "Please Enter Room Name");
            }
            else if (textBoxRoomName.Text == String.Empty)
            {
                textBoxRoomName.Focus();
                errorLocation.SetError(textBoxRoomName, "Please Enter Room Name");
            }
            else if (radioButtonLectureHall.Checked == false & radioButtonLaboratory.Checked == false)
            {
                errorLocation.SetError(radioButtonLaboratory, "Please Select Room Type");
            }
            else if (textBoxCapacity.Text == String.Empty)
            {
                textBoxCapacity.Focus();
                errorLocation.SetError(textBoxCapacity, "Please Enter Room Capacity");
            }


            else
            {
                Location location = new Location();

                #region Set Data to Object
                // Set Data to model
                location.BuildingName = textBoxBuildName.Text.Trim();
                location.RoomName = textBoxRoomName.Text.Trim();
            

                if (radioButtonLectureHall.Checked == true)
                    location.RoomType= "Lecture Hall";
                else if (radioButtonLaboratory.Checked == true)
                    location.RoomType = "Laboratory";

                location.Capacity = textBoxCapacity.Text.Trim();

                Console.WriteLine(selectedLoc.Id);

                #endregion

                //Update Data
                if (locationService.updateLocation(selectedLoc.Id, location))
                {
                    SuccessMessage sc = new SuccessMessage("Location Updated Successfully !");
                    sc.Show();
                    dataGridLocations.Rows.Clear();
                    populateData();
                    clear(); 
                }
                else
                {
                    ErrorMessage ec = new ErrorMessage("Oops, Somthing went wrong!");
                    ec.Show();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (locationService.deleteLocation(selectedLoc.Id))
            {
                SuccessMessage sm = new SuccessMessage("Subject Deleted Successfully");
                sm.Show();
                dataGridLocations.Rows.Clear();
                populateData();
                clear();
            }
            else
            {
                ErrorMessage em = new ErrorMessage("Oops, Somthing went wrong..");
                em.Show();
            }
        }

        private void textBoxCapacity_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridLocations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButtonLectureHall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonLaboratory_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            textBoxBuildName.Text = String.Empty;
            radioButtonLectureHall.Checked = false;
            radioButtonLaboratory.Checked = false;
            textBoxCapacity.Text = String.Empty;
            radioButtonLectureHall.Checked = false;
            radioButtonLaboratory.Checked = false;

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void ManageLocations_Load(object sender, EventArgs e)
        {

        }
    }
}
