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

namespace Time_Table_Management_System.Tags
{
    public partial class ManageTags : Form

    {
        private bool executedFirstTime;
        private Tag selectedTag;
        private ITagService tagService;
        public ManageTags()
        {
            InitializeComponent();
            executedFirstTime = true;
            tagService = new TagService();
            populateData();
        }

        private void populateData()
        {
            ITagService tagService = new TagService();
            List<Tag> tagsArray = tagService.getAllTags();

            foreach (Tag tag in tagsArray)
            {
                dataGridView1.Rows.Add(tag.Id,tag.SubjectName, tag.SubjectCode, tag.RelatedTag);
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                    {
                        int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        selectedTag = tagService.GetTag(id);

                        #region Set data to Fields
                        subName.Text = selectedTag.SubjectName;
                        subCode.Text = selectedTag.SubjectCode;
                        switch (selectedTag.RelatedTag)
                        {
                            case "Lecture":
                                comboBoxRelatedTag.SelectedIndex = 0;
                                break;
                            case "Lab":
                                comboBoxRelatedTag.SelectedIndex = 1;
                                break;
                            case "Practicle":
                                comboBoxRelatedTag.SelectedIndex = 2;
                                break;

                        }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void subName_TextChanged(object sender, EventArgs e)
        {

        }

        private void subCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRelatedTag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (subName.Text == String.Empty)
            {
                subName.Focus();
                errorManageTags.SetError(subName, "Please Enter Subject Name");
            }
            else if (subCode.Text == String.Empty)
            {
                subCode.Focus();
                errorManageTags.SetError(subCode, "Please Enter Subject Code");
            }
            else if (comboBoxRelatedTag.SelectedIndex == -1)
            {
                comboBoxRelatedTag.Focus();
                errorManageTags.SetError(comboBoxRelatedTag, "Please Select Related Tag");
            }
            else
            {
                Tag tag = new Tag();

                #region Set Data to Object
                // Set Data to model
                tag.SubjectName = subName.Text.Trim();
                tag.SubjectCode = subCode.Text.Trim();
                tag.RelatedTag = comboBoxRelatedTag.SelectedItem.ToString();
                #endregion

                //Insert Data
                if (tagService.updateTag(selectedTag.Id,tag))
                {
                    //SuccessMessage sc = new SuccessMessage("Tag Updated Successfully !");
                    //sc.Show();
                    MessageBox.Show("Tag Updated Successfully !");
                    dataGridView1.Rows.Clear();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tagService.deleteTagr(selectedTag.Id))
            {
                //SuccessMessage sm = new SuccessMessage("Tag killed Successfully");
                //sm.Show();
                MessageBox.Show("Tag killed Successfully");
                dataGridView1.Rows.Clear();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            subName.Text = String.Empty;
            subCode.Text = String.Empty;
            comboBoxRelatedTag.SelectedIndex = -1;
            comboBoxRelatedTag.Enabled = true;

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
