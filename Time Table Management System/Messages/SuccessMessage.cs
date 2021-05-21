using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table_Management_System.Messages
{
    public partial class SuccessMessage : Form
    {
        public SuccessMessage(String successMsg)
        {
            InitializeComponent();
            labelSuccessMessage.Text = successMsg;
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
