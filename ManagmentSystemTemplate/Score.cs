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
    public partial class Score : Form
    {
        GroupClass group = new GroupClass();
        UserClass user = new UserClass();
        ScoreClass score = new ScoreClass();
        public Score()
        {
            InitializeComponent();
        }

        private void showScore()
        {
            DataGridView_user.DataSource = score.getList(new MySqlCommand("SELECT score.Id,user.FirstName,user.LastName,score.GroupName,score.Score,score.Description FROM user INNER JOIN score ON score.Id = user.Id"));
        }

        private void Score_Load(object sender, EventArgs e)
        {
            comboBox_group.DataSource = group.getGroup(new MySqlCommand("SELECT * FROM `groupp`"));
            comboBox_group.DisplayMember = "GroupName";
            comboBox_group.ValueMember = "GroupName";

            DataGridView_user.DataSource = user.getList(new MySqlCommand("SELECT `Id`, `FirstName`, `LastName` FROM `user`"));
        }

        private void button_add_Click(object sender, EventArgs e)
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

                    if (!score.checkScore(id, gName))
                    {
                        if (score.insertScore(id, gName, scr, desc))
                        {
                            showScore();
                            button_clear.PerformClick();
                            MessageBox.Show("New score inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Score not inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The score for this group already exists", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values for User ID and Score", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_userId.Clear();
            textBox_score.Clear();
            comboBox_group.SelectedIndex = 0;
            textBox_GDescription.Clear();
        }

        private void DataGridView_user_Click(object sender, EventArgs e)
        {
            textBox_userId.Text = DataGridView_user.CurrentRow.Cells[0].Value.ToString();
        }

        private void button_sUser_Click(object sender, EventArgs e)
        {
            DataGridView_user.DataSource = user.getList(new MySqlCommand("SELECT `Id`, `FirstName`, `LastName` FROM `user`"));
        }

        private void button_sScore_Click(object sender, EventArgs e)
        {
            showScore();
        }
    }
}
