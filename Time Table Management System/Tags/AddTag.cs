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

namespace Time_Table_Management_System.Tags
{
    public partial class AddTag : Form
    {
        public AddTag()
        {
            InitializeComponent();
        }

        private void AddTag_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            subName.Text = "";
            subCode.Text = "";
            comboBoxRelatedTag.SelectedIndex = -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (subName.Text == String.Empty)
            {
                subName.Focus();
                errorTag.SetError(subName, "Please Enter Subject Name");
            }
            else if (subCode.Text == String.Empty)
            {
                subCode.Focus();
                errorTag.SetError(subCode, "Please Enter Subject Code");
            }
            else if (comboBoxRelatedTag.SelectedIndex == -1)
            {
                comboBoxRelatedTag.Focus();
                errorTag.SetError(comboBoxRelatedTag, "Please Select Related Tag");
            }
            else
            {
                Tag tag = new Tag();
                ITagService tagService = new TagService();

                // Set Data
                tag.SubjectName = subName.Text.Trim();
                tag.SubjectCode = subCode.Text.Trim();
                switch (comboBoxRelatedTag.SelectedIndex)
                {
                    case 0:
                        tag.RelatedTag = "Lecture";
                        break;
                    case 1:
                        tag.RelatedTag = "Tutorial";
                        break;
                    case 2:
                        tag.RelatedTag = "Lab";
                        break;
                }
                //Insert Data
                if (tagService.addTag(tag))
                {
                    //MessageBox.Show(tag.Tag);
                    //SuccessMessage sc = new SuccessMessage("Tags Added Successfully !");
                    //sc.Show();
                    MessageBox.Show("Tags Added Successfully !");
                    subName.Text = "";
                    subCode.Text = "";
                    comboBoxRelatedTag.SelectedIndex = -1;

                }
                else
                {
                    //ErrorMessage ec = new ErrorMessage("Oops, Somthing went wrong!");
                    //ec.Show();
                    MessageBox.Show("Oops, Somthing went wrong!");
                    subName.Text = "";
                    subCode.Text = "";
                    comboBoxRelatedTag.SelectedIndex = -1;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
