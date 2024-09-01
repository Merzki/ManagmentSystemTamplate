using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ManageUser : Form
    {
        UserClass user = new UserClass();
        public ManageUser()
        {
            InitializeComponent();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            DataGridView_user.DataSource = user.getUserList();
            DataGridView_user.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_user.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
            {
                MessageBox.Show("Field Error - we need user id", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_id.Text);
                if (MessageBox.Show("Are u sure u wanna remove this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (user.deleteUser(id))
                    {
                        showTable();
                        MessageBox.Show("User deleted", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_id.Text) ||
                string.IsNullOrWhiteSpace(textBox_Fname.Text) ||
                string.IsNullOrWhiteSpace(textBox_Lname.Text) ||
                string.IsNullOrWhiteSpace(textBox_Phone.Text) ||
                string.IsNullOrWhiteSpace(textBox_Address.Text) ||
                pictureBox_user.Image == null)
            {
                MessageBox.Show("All fields must be filled in", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(textBox_id.Text, out int id))
            {
                MessageBox.Show("Please enter a valid numeric ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!IsValidPhoneNumber(textBox_Phone.Text))
            {
                MessageBox.Show("Please enter a valid phone number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string fname = textBox_Fname.Text;
                string lname = textBox_Lname.Text;
                DateTime bdate = dateOfBirthPicker.Value;
                string phone = textBox_Phone.Text;
                string address = textBox_Address.Text;
                string gender = maleButton.Checked ? "Male" : "Female";

                int born_year = dateOfBirthPicker.Value.Year;
                int this_year = DateTime.Now.Year;

                if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                {
                    MessageBox.Show("User age must be between 10 and 100", "Invalid BirthDate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox_user.Image.Save(ms, pictureBox_user.Image.RawFormat);
                        byte[] img = ms.ToArray();

                        if (user.updateUser(id, fname, lname, bdate, gender, phone, address, img))
                        {
                            showTable();
                            MessageBox.Show("User Updated", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("User not updated", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool IsValidPhoneNumber(string phone)
        {
            return phone.All(char.IsDigit) && phone.Length >= 10 && phone.Length <= 15;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_Phone.Clear();
            textBox_Address.Clear();
            maleButton.Checked = true;
            dateOfBirthPicker.Value = DateTime.Now;
            pictureBox_user.Image = null;
        }

        private void DataGridView_user_Click_1(object sender, EventArgs e)
        {
            textBox_id.Text = DataGridView_user.CurrentRow.Cells[0].Value.ToString();
            textBox_Fname.Text = DataGridView_user.CurrentRow.Cells[1].Value.ToString();
            textBox_Lname.Text = DataGridView_user.CurrentRow.Cells[2].Value.ToString();
            dateOfBirthPicker.Value = (DateTime)DataGridView_user.CurrentRow.Cells[3].Value;
            if (DataGridView_user.CurrentRow.Cells[4].Value.ToString() == "Male")
                maleButton.Checked = true;

            textBox_Phone.Text = DataGridView_user.CurrentRow.Cells[5].Value.ToString();
            textBox_Address.Text = DataGridView_user.CurrentRow.Cells[6].Value.ToString();
            byte[] img = (byte[])DataGridView_user.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_user.Image = Image.FromStream(ms);

        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif) |*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_user.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_user.DataSource = user.searchUserList(textBox_search.Text);
            textBox_search.Clear();
            DataGridView_user.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_user.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
    }
}
