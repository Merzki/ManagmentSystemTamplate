using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagmentSystemTemplate
{
    public partial class ManageGroup : Form
    {
        GroupClass group = new GroupClass();
        public ManageGroup()
        {
            InitializeComponent();
        }

        private void ManageGroupcs_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            DataGridView_group.DataSource = group.getGroup(new MySqlCommand("SELECT * FROM `groupp`"));

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_GName.Clear();
            textBox_GHour.Clear();
            textBox_GDescription.Clear();
            textBox_id.Clear();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_GName.Text) ||
                string.IsNullOrWhiteSpace(textBox_GHour.Text) ||
                string.IsNullOrWhiteSpace(textBox_id.Text))
            {
                MessageBox.Show("All fields must be filled in", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBox_id.Text, out int id))
            {
                MessageBox.Show("Please enter a valid numeric ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBox_GHour.Text, out int ghr))
            {
                MessageBox.Show("Please enter a valid number of group hours", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string gName = textBox_GName.Text;
                string desc = textBox_GDescription.Text;

                try
                {
                    if (group.updateGroup(id, gName, ghr, desc))
                    {
                        showData();
                        button_clear.PerformClick();
                        MessageBox.Show("Group updated", "Update Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Group not updated", "Update Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
            {
                MessageBox.Show("Field Error - we need group id", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_id.Text);
                if (MessageBox.Show("Are u sure u wanna remove this group?", "Delete Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (group.deleteGroup(id))
                    {
                        showData();
                        MessageBox.Show("Group deleted", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                }
            }
        }

        private void DataGridView_group_Click(object sender, EventArgs e)
        {
            textBox_id.Text = DataGridView_group.CurrentRow.Cells[0].Value.ToString();
            textBox_GName.Text = DataGridView_group.CurrentRow.Cells[1].Value.ToString();
            textBox_GHour.Text = DataGridView_group.CurrentRow.Cells[2].Value.ToString();
            textBox_GDescription.Text = DataGridView_group.CurrentRow.Cells[3].Value.ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_group.DataSource = group.searchGroupList(textBox_search.Text);
            textBox_search.Clear();
            DataGridView_group.RowTemplate.Height = 80;
        }
    }
}
