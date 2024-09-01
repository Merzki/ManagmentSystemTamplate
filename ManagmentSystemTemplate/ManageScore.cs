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
    public partial class ManageScore : Form
    {
        GroupClass group = new GroupClass();
        ScoreClass score = new ScoreClass();
        public ManageScore()
        {
            InitializeComponent();
        }

        private void ManageScore_Load(object sender, EventArgs e)
        {
            comboBox_group.DataSource = group.getGroup(new MySqlCommand("SELECT * FROM `groupp`"));
            comboBox_group.DisplayMember = "GroupName";
            comboBox_group.ValueMember = "GroupName";

            showScore();
        }

        public void showScore()
        {
            DataGridView_scor.DataSource = score.getList(new MySqlCommand("SELECT score.Id,user.FirstName,user.LastName,score.GroupName,score.Score,score.Description FROM user INNER JOIN score ON score.Id = user.Id"));
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_userId.Text) || string.IsNullOrWhiteSpace(textBox_score.Text))
            {
                MessageBox.Show("User ID and Score fields are required.", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(textBox_userId.Text, out int id) && double.TryParse(textBox_score.Text, out double scr))
                {
                    string gName = comboBox_group.Text;
                    string desc = textBox_GDescription.Text;

                    if (score.updateScore(id, gName, scr, desc))
                    {
                        showScore();
                        button_clear.PerformClick();
                        MessageBox.Show("Score updated", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Score not updated", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values for User ID and Score.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_userId.Clear();
            textBox_score.Clear();
            textBox_GDescription.Clear();
            textBox_search.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_userId.Text == "")
            {
                MessageBox.Show("Field Error - we need user id", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_userId.Text);
                if (MessageBox.Show("Are u sure u wanna remove this score?", "Delete Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (score.deleteScore(id))
                    {
                        showScore();
                        MessageBox.Show("Score deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                }
            }
        }

        private void DataGridView_scor_Click(object sender, EventArgs e)
        {
            textBox_userId.Text = DataGridView_scor.CurrentRow.Cells[0].Value.ToString();
            comboBox_group.Text = DataGridView_scor.CurrentRow.Cells[3].Value.ToString();
            textBox_score.Text = DataGridView_scor.CurrentRow.Cells[4].Value.ToString();
            textBox_GDescription.Text = DataGridView_scor.CurrentRow.Cells[5].Value.ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_scor.DataSource = score.getList(new MySqlCommand("SELECT score.Id, user.FirstName, user.LastName, score.GroupName, score.Score, score.Description FROM user INNER JOIN score ON score.Id = user.Id WHERE CONCAT(user.FirstName, user.LastName, score.GroupName) LIKE '%" + textBox_search.Text + "%'"));
            button_clear.PerformClick();
        }
    }
}
