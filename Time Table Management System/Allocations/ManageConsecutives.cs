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
using Time_Table_Management_System.Services;
using Time_Table_Management_System.Messages;
using System.Data.SQLite;


namespace Time_Table_Management_System.Allocations
{
    public partial class ManageConsecutives : Form
    {
        private Consecutive selectedConsecutive = null;
        private IConsecutiveService consecutiveService = new ConsecutiveService();
        private bool executedFirstTime;

        public ManageConsecutives()
        {
            InitializeComponent();
            executedFirstTime = true;
            populateData();
        }

        public void populateData()
        {
            List<Consecutive> consecutivesArray = consecutiveService.getAllConsecutives();
            dataGridViewSessions.Rows.Clear();

            foreach (Consecutive consecutive in consecutivesArray)
            {
                dataGridViewSessions.Rows.Add(consecutive.Id, consecutive.Con1_id, consecutive.Con2_id);

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
                int selectedIndex = dataGridViewSessions.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if (dataGridViewSessions.SelectedRows[0].Cells[0].Value != null)
                    {
                        int id = int.Parse(dataGridViewSessions.SelectedRows[0].Cells[0].Value.ToString());
                        selectedConsecutive = new Consecutive();
                        selectedConsecutive = consecutiveService.GetConsecutive(id);

                        Console.WriteLine(id);

                        #region Set data to Fields
 

                        #endregion

                        
                        btnDelete.Enabled = true;
                    }
                }


            }
            catch (ArgumentOutOfRangeException es)
            {
                Console.WriteLine(es.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateData();
            selectedConsecutive = new Consecutive();
            btnDelete.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (consecutiveService.deleteConsecutive(selectedConsecutive.Id))
            {
                //SuccessMessage sm = new SuccessMessage("Session killed Successfully");
                //sm.Show();
                MessageBox.Show("Session killed Successfully");
                dataGridViewSessions.Rows.Clear();
                populateData();
                
            }
            else
            {
                //ErrorMessage em = new ErrorMessage("Oops, Somthing went wrong..");
                //em.Show();
                MessageBox.Show("Oops, Somthing went wrong..");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String typeGG = null;
            if (comboBoxSearch.Text == "Session 1 ID")
            {
                typeGG = "con1_id";
                List<Consecutive> consecutivesArray = consecutiveService.searchConsecutive(txtSearchKey.Text.Trim(), typeGG);
                if (consecutivesArray.Count == 0)
                {
                    //ErrorMessage em = new ErrorMessage("No data found!");
                    //em.Show();
                    MessageBox.Show("No data found!");
                }
                else
                {
                    dataGridViewSessions.Rows.Clear();

                    foreach (Consecutive consecutive in consecutivesArray)
                    {
                        dataGridViewSessions.Rows.Add(consecutive.Id, consecutive.Con1_id, consecutive.Con2_id);
                    }
                }


            }
            else if (comboBoxSearch.Text == "Session 2 ID")
            {
                typeGG = "con2_id";
                List<Consecutive> consecutivesArray = consecutiveService.searchConsecutive(txtSearchKey.Text, typeGG);
                if (consecutivesArray.Count == 0)
                {
                    //ErrorMessage em = new ErrorMessage("No data found!");
                    //em.Show();
                    MessageBox.Show("No data found!");
                }
                else
                {
                    dataGridViewSessions.Rows.Clear();

                    foreach (Consecutive consecutive in consecutivesArray)
                    {
                        dataGridViewSessions.Rows.Add(consecutive.Id, consecutive.Con1_id, consecutive.Con2_id);
                    }
                }
            }
            
            else
            {
                //ErrorMessage errorMessage = new ErrorMessage("Select a type to proceed...");
                //errorMessage.Show();
                MessageBox.Show("Select a type to proceed...");
            }
        }
    }
}
