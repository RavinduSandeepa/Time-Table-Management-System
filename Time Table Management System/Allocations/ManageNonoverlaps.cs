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
    public partial class ManageNonoverlaps : Form
    {
        private Nonoverlap selectedNonoverlap = null;
        private INonoverlapService nonoverlapService = new NonoverlapService();
        private bool executedFirstTime;
        public ManageNonoverlaps()
        {
            InitializeComponent();
            executedFirstTime = true;
            populateData();
        }
        public void populateData()
        {
            List<Nonoverlap> nonoverlapsArray = nonoverlapService.getAllNonoverlaps ();
            dataGridViewSessions.Rows.Clear();

            foreach (Nonoverlap nonoverlap in nonoverlapsArray)
            {
                dataGridViewSessions.Rows.Add(nonoverlap.Id, nonoverlap.Non1_id, nonoverlap.Non2_id, nonoverlap.Non3_id, nonoverlap.Non4_id);

            }

        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nonoverlapService.deleteNonoverlap(selectedNonoverlap.Id))
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
                        selectedNonoverlap = new Nonoverlap();
                        selectedNonoverlap = nonoverlapService.GetNonoverlap(id);

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateData();
            selectedNonoverlap = new Nonoverlap();
            btnDelete.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String typeGG = null;
            if (comboBoxSearch.Text == "Session 1 ID")
            {
                typeGG = "non1_id";
                List<Nonoverlap> nonoverlapsArray = nonoverlapService.searchNonoverlap(txtSearchKey.Text.Trim(), typeGG);
                if (nonoverlapsArray.Count == 0)
                {
                    //ErrorMessage em = new ErrorMessage("No data found!");
                    //em.Show();
                    MessageBox.Show("No data found!");
                }
                else
                {
                    dataGridViewSessions.Rows.Clear();

                    foreach (Nonoverlap nonoverlap in nonoverlapsArray)
                    {
                        dataGridViewSessions.Rows.Add(nonoverlap.Id, nonoverlap.Non1_id, nonoverlap.Non2_id, nonoverlap.Non3_id, nonoverlap.Non4_id);
                    }
                }


            }
            else if (comboBoxSearch.Text == "Session 2 ID")
            {
                typeGG = "non2_id";
                List<Nonoverlap> nonoverlapsArray = nonoverlapService.searchNonoverlap(txtSearchKey.Text.Trim(), typeGG);
                if (nonoverlapsArray.Count == 0)
                {
                    //ErrorMessage em = new ErrorMessage("No data found!");
                    //em.Show();
                    MessageBox.Show("No data found!");
                }
                else
                {
                    dataGridViewSessions.Rows.Clear();

                    foreach (Nonoverlap nonoverlap in nonoverlapsArray)
                    {
                        dataGridViewSessions.Rows.Add(nonoverlap.Id, nonoverlap.Non1_id, nonoverlap.Non2_id, nonoverlap.Non3_id, nonoverlap.Non4_id);
                    }
                }
            }
            else if (comboBoxSearch.Text == "Session 3 ID")
            {
                typeGG = "non3_id";
                List<Nonoverlap> nonoverlapsArray = nonoverlapService.searchNonoverlap(txtSearchKey.Text.Trim(), typeGG);
                if (nonoverlapsArray.Count == 0)
                {
                    //ErrorMessage em = new ErrorMessage("No data found!");
                    //em.Show();
                    MessageBox.Show("No data found!");
                }
                else
                {
                    dataGridViewSessions.Rows.Clear();

                    foreach (Nonoverlap nonoverlap in nonoverlapsArray)
                    {
                        dataGridViewSessions.Rows.Add(nonoverlap.Id, nonoverlap.Non1_id, nonoverlap.Non2_id, nonoverlap.Non3_id, nonoverlap.Non4_id);
                    }
                }
            }
            else if (comboBoxSearch.Text == "Session 4 ID")
            {
                typeGG = "non4_id";
                List<Nonoverlap> nonoverlapsArray = nonoverlapService.searchNonoverlap(txtSearchKey.Text.Trim(), typeGG);
                if (nonoverlapsArray.Count == 0)
                {
                    //ErrorMessage em = new ErrorMessage("No data found!");
                    //em.Show();
                    MessageBox.Show("No data found!");
                }
                else
                {
                    dataGridViewSessions.Rows.Clear();

                    foreach (Nonoverlap nonoverlap in nonoverlapsArray)
                    {
                        dataGridViewSessions.Rows.Add(nonoverlap.Id, nonoverlap.Non1_id, nonoverlap.Non2_id, nonoverlap.Non3_id, nonoverlap.Non4_id);
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
