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
    public partial class Group : Form
    {
        GroupClass group = new GroupClass();
        public Group()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_GName.Text) || string.IsNullOrWhiteSpace(textBox_GHour.Text))
            {
                MessageBox.Show("All fields must be filled in", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (group.insertGroup(gName, ghr, desc))
                    {
                        showData();
                        button_clear.PerformClick();
                        MessageBox.Show("New group inserted", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Group not inserted", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_GName.Clear();
            textBox_GHour.Clear();
            textBox_GDescription.Clear();
        }

        private void Group_Load(object sender, EventArgs e)
        {
            showData();
        }
        private void showData()
        {
            DataGridView_group.DataSource = group.getGroup(new MySqlCommand("SELECT * FROM `groupp`"));

        }
    }
}
