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
    public partial class ManageParallels : Form
    {

        private ParalleDTO selectedParallel = null;
        private IParallelService parallelService = new ParallelService();
        private bool executedFirstTime;

        public ManageParallels()
        {
            InitializeComponent();
            executedFirstTime = true;
            populateData();
        }

        public void populateData()
        {
            List<ParalleDTO> parallelsArray = parallelService.getAllParallels();
            dataGridViewSessions.Rows.Clear();

            foreach (ParalleDTO paralleDTO in parallelsArray)
            {
                dataGridViewSessions.Rows.Add(paralleDTO.Id, paralleDTO.Par1_id, paralleDTO.Par2_id, paralleDTO.Par3_id);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateData();
            selectedParallel = new ParalleDTO();
            btnDelete.Enabled = false;
            
        }

        private void close_Click(object sender, EventArgs e)
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
                int selectedIndex = dataGridViewSessions.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if (dataGridViewSessions.SelectedRows[0].Cells[0].Value != null)
                    {
                        int id = int.Parse(dataGridViewSessions.SelectedRows[0].Cells[0].Value.ToString());
                        selectedParallel = new ParalleDTO();
                        selectedParallel = parallelService.GetParallel(id);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (parallelService.deleteParallel(selectedParallel.Id))
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
                typeGG = "par1_id";
                List<ParalleDTO> parallelsArray = parallelService.searchParallel(txtSearchKey.Text.Trim(), typeGG);
                if (parallelsArray.Count == 0)
                {
                    //ErrorMessage em = new ErrorMessage("No data found!");
                    //em.Show();
                    MessageBox.Show("No data found!");
                }
                else
                {
                    dataGridViewSessions.Rows.Clear();

                    foreach (ParalleDTO paralleDTO in parallelsArray)
                    {
                        dataGridViewSessions.Rows.Add(paralleDTO.Id, paralleDTO.Par1_id, paralleDTO.Par2_id, paralleDTO.Par3_id);
                    }
                }


            }
            else if (comboBoxSearch.Text == "Session 2 ID")
            {
                typeGG = "par2_id";
                List<ParalleDTO> parallelsArray = parallelService.searchParallel(txtSearchKey.Text, typeGG);
                if (parallelsArray.Count == 0)
                {
                    //ErrorMessage em = new ErrorMessage("No data found!");
                    //em.Show();
                    MessageBox.Show("No data found!");
                }
                else
                {
                    dataGridViewSessions.Rows.Clear();

                    foreach (ParalleDTO paralleDTO in parallelsArray)
                    {
                        dataGridViewSessions.Rows.Add(paralleDTO.Id, paralleDTO.Par1_id, paralleDTO.Par2_id, paralleDTO.Par3_id);
                    }
                }
            }
            else if (comboBoxSearch.Text == "Session 3 ID")
            {
                typeGG = "par3_id";
                List<ParalleDTO> parallelsArray = parallelService.searchParallel(txtSearchKey.Text, typeGG);
                if (parallelsArray.Count == 0)
                {
                    //ErrorMessage em = new ErrorMessage("No data found!");
                    //em.Show();
                    MessageBox.Show("No data found!");
                }
                else
                {
                    dataGridViewSessions.Rows.Clear();

                    foreach (ParalleDTO paralleDTO in parallelsArray)
                    {
                        dataGridViewSessions.Rows.Add(paralleDTO.Id, paralleDTO.Par1_id, paralleDTO.Par2_id, paralleDTO.Par3_id);
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
