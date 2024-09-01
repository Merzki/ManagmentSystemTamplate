namespace ManagmentSystemTemplate
{
    partial class ManageUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            panel1 = new Panel();
            label7 = new Label();
            button_delete = new Button();
            button_update = new Button();
            textBox_Phone = new TextBox();
            Phone = new Label();
            button_upload = new Button();
            pictureBox_user = new PictureBox();
            textBox_Address = new TextBox();
            label5 = new Label();
            femaleButton = new RadioButton();
            maleButton = new RadioButton();
            label4 = new Label();
            dateOfBirthPicker = new DateTimePicker();
            label3 = new Label();
            textBox_Lname = new TextBox();
            Lname = new Label();
            DataGridView_user = new Guna.UI2.WinForms.Guna2DataGridView();
            textBox_Fname = new TextBox();
            Fname = new Label();
            button_clear = new Button();
            button_search = new Button();
            textBox_search = new TextBox();
            textBox_id = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_user).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Location = new Point(12, 417);
            panel2.Name = "panel2";
            panel2.Size = new Size(1116, 14);
            panel2.TabIndex = 40;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 65);
            panel1.TabIndex = 39;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label7.Location = new Point(517, 20);
            label7.Name = "label7";
            label7.Size = new Size(134, 24);
            label7.TabIndex = 0;
            label7.Text = "Manage User";
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.Red;
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(1006, 633);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(122, 48);
            button_delete.TabIndex = 38;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_update.BackColor = Color.OrangeRed;
            button_update.FlatStyle = FlatStyle.Flat;
            button_update.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(878, 633);
            button_update.Name = "button_update";
            button_update.Size = new Size(122, 48);
            button_update.TabIndex = 37;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // textBox_Phone
            // 
            textBox_Phone.Location = new Point(723, 447);
            textBox_Phone.Name = "textBox_Phone";
            textBox_Phone.Size = new Size(167, 26);
            textBox_Phone.TabIndex = 36;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Phone.ForeColor = Color.FromArgb(0, 71, 160);
            Phone.Location = new Point(642, 450);
            Phone.Name = "Phone";
            Phone.Size = new Size(75, 20);
            Phone.TabIndex = 35;
            Phone.Text = "Phone : ";
            // 
            // button_upload
            // 
            button_upload.BackColor = Color.Green;
            button_upload.FlatStyle = FlatStyle.Flat;
            button_upload.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(1006, 574);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(122, 48);
            button_upload.TabIndex = 34;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click;
            // 
            // pictureBox_user
            // 
            pictureBox_user.BackColor = Color.Silver;
            pictureBox_user.Location = new Point(1006, 438);
            pictureBox_user.Name = "pictureBox_user";
            pictureBox_user.Size = new Size(122, 118);
            pictureBox_user.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_user.TabIndex = 33;
            pictureBox_user.TabStop = false;
            // 
            // textBox_Address
            // 
            textBox_Address.Location = new Point(169, 573);
            textBox_Address.Multiline = true;
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(525, 48);
            textBox_Address.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(73, 573);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 31;
            label5.Text = "Address : ";
            // 
            // femaleButton
            // 
            femaleButton.AutoSize = true;
            femaleButton.Font = new Font("Microsoft Sans Serif", 12F);
            femaleButton.ForeColor = Color.FromArgb(0, 71, 160);
            femaleButton.Location = new Point(678, 512);
            femaleButton.Name = "femaleButton";
            femaleButton.Size = new Size(80, 24);
            femaleButton.TabIndex = 30;
            femaleButton.Text = "Female";
            femaleButton.UseVisualStyleBackColor = true;
            // 
            // maleButton
            // 
            maleButton.AutoSize = true;
            maleButton.Checked = true;
            maleButton.Font = new Font("Microsoft Sans Serif", 12F);
            maleButton.ForeColor = Color.FromArgb(0, 71, 160);
            maleButton.Location = new Point(611, 512);
            maleButton.Name = "maleButton";
            maleButton.Size = new Size(61, 24);
            maleButton.TabIndex = 29;
            maleButton.TabStop = true;
            maleButton.Text = "Male";
            maleButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(517, 514);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 28;
            label4.Text = "Gender :";
            // 
            // dateOfBirthPicker
            // 
            dateOfBirthPicker.Location = new Point(169, 508);
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.Size = new Size(289, 26);
            dateOfBirthPicker.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(43, 511);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 26;
            label3.Text = "Date of birth :";
            // 
            // textBox_Lname
            // 
            textBox_Lname.Location = new Point(464, 447);
            textBox_Lname.Name = "textBox_Lname";
            textBox_Lname.Size = new Size(167, 26);
            textBox_Lname.TabIndex = 25;
            // 
            // Lname
            // 
            Lname.AutoSize = true;
            Lname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Lname.ForeColor = Color.FromArgb(0, 71, 160);
            Lname.Location = new Point(355, 450);
            Lname.Name = "Lname";
            Lname.Size = new Size(103, 20);
            Lname.TabIndex = 24;
            Lname.Text = "Last name :";
            // 
            // DataGridView_user
            // 
            DataGridView_user.AllowUserToAddRows = false;
            DataGridView_user.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView_user.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_user.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_user.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_user.ColumnHeadersHeight = 24;
            DataGridView_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_user.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_user.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_user.Location = new Point(12, 125);
            DataGridView_user.Name = "DataGridView_user";
            DataGridView_user.RowHeadersVisible = false;
            DataGridView_user.RowTemplate.Height = 80;
            DataGridView_user.Size = new Size(1116, 303);
            DataGridView_user.TabIndex = 23;
            DataGridView_user.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_user.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_user.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_user.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_user.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_user.ThemeStyle.BackColor = Color.WhiteSmoke;
            DataGridView_user.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_user.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_user.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_user.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 12F);
            DataGridView_user.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_user.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_user.ThemeStyle.HeaderStyle.Height = 24;
            DataGridView_user.ThemeStyle.ReadOnly = false;
            DataGridView_user.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_user.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_user.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F);
            DataGridView_user.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_user.ThemeStyle.RowsStyle.Height = 80;
            DataGridView_user.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_user.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_user.Click += DataGridView_user_Click_1;
            // 
            // textBox_Fname
            // 
            textBox_Fname.Location = new Point(169, 447);
            textBox_Fname.Name = "textBox_Fname";
            textBox_Fname.Size = new Size(167, 26);
            textBox_Fname.TabIndex = 22;
            // 
            // Fname
            // 
            Fname.AutoSize = true;
            Fname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Fname.ForeColor = Color.FromArgb(0, 71, 160);
            Fname.Location = new Point(59, 450);
            Fname.Name = "Fname";
            Fname.Size = new Size(104, 20);
            Fname.TabIndex = 21;
            Fname.Text = "First name :";
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(750, 633);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(122, 48);
            button_clear.TabIndex = 41;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.Orange;
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(1006, 71);
            button_search.Name = "button_search";
            button_search.Size = new Size(122, 48);
            button_search.TabIndex = 42;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(786, 82);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(200, 26);
            textBox_search.TabIndex = 43;
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(761, 570);
            textBox_id.Name = "textBox_id";
            textBox_id.ReadOnly = true;
            textBox_id.Size = new Size(55, 26);
            textBox_id.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(723, 573);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 44;
            label1.Text = "ID : ";
            // 
            // ManageUser
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 690);
            Controls.Add(textBox_id);
            Controls.Add(label1);
            Controls.Add(textBox_search);
            Controls.Add(button_search);
            Controls.Add(button_clear);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(textBox_Phone);
            Controls.Add(Phone);
            Controls.Add(button_upload);
            Controls.Add(pictureBox_user);
            Controls.Add(textBox_Address);
            Controls.Add(label5);
            Controls.Add(femaleButton);
            Controls.Add(maleButton);
            Controls.Add(label4);
            Controls.Add(dateOfBirthPicker);
            Controls.Add(label3);
            Controls.Add(textBox_Lname);
            Controls.Add(Lname);
            Controls.Add(DataGridView_user);
            Controls.Add(textBox_Fname);
            Controls.Add(Fname);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "ManageUser";
            Text = "ManageUser";
            Load += ManageUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_user).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_user).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label7;
        private Button button_delete;
        private Button button_update;
        private TextBox textBox_Phone;
        private Label Phone;
        private Button button_upload;
        private PictureBox pictureBox_user;
        private TextBox textBox_Address;
        private Label label5;
        private RadioButton femaleButton;
        private RadioButton maleButton;
        private Label label4;
        private DateTimePicker dateOfBirthPicker;
        private Label label3;
        private TextBox textBox_Lname;
        private Label Lname;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_user;
        private TextBox textBox_Fname;
        private Label Fname;
        private Button button_clear;
        private Button button_search;
        private TextBox textBox_search;
        private TextBox textBox_id;
        private Label label1;
    }
}