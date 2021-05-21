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

namespace Time_Table_Management_System.Allocations
{
    public partial class ManageNotavailables : Form
    {

        private Notavailable selectedNotavailable = null;
        private INotavailableService notavailableservice = new NotavailableService();
        private bool executedFirstTime;

        public ManageNotavailables()
        {

            InitializeComponent();
            executedFirstTime = true;
            populateData();
        }

        public void populateData()
        {
            List<Notavailable> notavailablesArray = notavailableservice.getAllNotavailables();
            dataGridViewNotAvailable.Rows.Clear();

            foreach (Notavailable notavailable in notavailablesArray)
            {
                dataGridViewNotAvailable.Rows.Add(notavailable.Id, notavailable.Duration, notavailable.Lec_name, notavailable.Group_code, notavailable.Subgroup_code, notavailable.Session_Id);

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
            if (notavailableservice.deleteNotavailable(selectedNotavailable.Id))
            {
                //SuccessMessage sm = new SuccessMessage("Not Available Time killed Successfully");
                //sm.Show();
                MessageBox.Show("Not Available Time killed Successfully");
                dataGridViewNotAvailable.Rows.Clear();
                populateData();

            }
            else
            {
                //ErrorMessage em = new ErrorMessage("Oops, Somthing went wrong..");
                //em.Show();
                MessageBox.Show("Oops, Somthing went wrong..");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateData();
            selectedNotavailable = new Notavailable();
            btnDelete.Enabled = false;
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
                int selectedIndex = dataGridViewNotAvailable.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if (dataGridViewNotAvailable.SelectedRows[0].Cells[0].Value != null)
                    {
                        int id = int.Parse(dataGridViewNotAvailable.SelectedRows[0].Cells[0].Value.ToString());
                        selectedNotavailable = new Notavailable();
                        selectedNotavailable = notavailableservice.GetNotavailable(id);

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
    }
}
