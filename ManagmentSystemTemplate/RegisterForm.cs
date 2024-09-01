using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagmentSystemTemplate
{
    public partial class RegisterForm : Form
    {
        UserClass user = new UserClass();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void femaleButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maleButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateOfBirthPicker_ValueChanged(object sender, EventArgs e)
        {

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

        private void button_add_Click(object sender, EventArgs e)
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
            else if (!verify())
            {
                MessageBox.Show("All fields must be filled in, and phone number must be valid", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox_user.Image.Save(ms, pictureBox_user.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    if (user.insertUser(fname, lname, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("New User Added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User not added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        bool verify()
        {
            if (string.IsNullOrWhiteSpace(textBox_Fname.Text) ||
                string.IsNullOrWhiteSpace(textBox_Lname.Text) ||
                string.IsNullOrWhiteSpace(textBox_Phone.Text) ||
                string.IsNullOrWhiteSpace(textBox_Address.Text) ||
                pictureBox_user.Image == null)
            {
                return false;
            }

            return IsValidPhoneNumber(textBox_Phone.Text);
        }

        bool IsValidPhoneNumber(string phone)
        {
            return phone.All(char.IsDigit) && phone.Length >= 10 && phone.Length <= 15;
        }


        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_Fname.Clear();
            textBox_Lname.Clear();
            textBox_Phone.Clear();
            textBox_Address.Clear();
            maleButton.Checked = true;
            dateOfBirthPicker.Value = DateTime.Now;
            pictureBox_user.Image = null;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
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

        private void textBox_Address_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
