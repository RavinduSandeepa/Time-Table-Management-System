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
    public partial class ErrorMessage : Form
    {
        public ErrorMessage(String errorMessage)
        {
            InitializeComponent();
            labelSErrorMessage.Text = errorMessage;
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
