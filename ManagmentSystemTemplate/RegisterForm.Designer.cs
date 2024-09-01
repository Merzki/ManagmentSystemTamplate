namespace ManagmentSystemTemplate
{
    partial class RegisterForm
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
            Fname = new Label();
            textBox_Fname = new TextBox();
            textBox_Lname = new TextBox();
            Lname = new Label();
            label3 = new Label();
            dateOfBirthPicker = new DateTimePicker();
            label4 = new Label();
            maleButton = new RadioButton();
            femaleButton = new RadioButton();
            label5 = new Label();
            textBox_Address = new TextBox();
            pictureBox_user = new PictureBox();
            button_upload = new Button();
            textBox_Phone = new TextBox();
            Phone = new Label();
            button_clear = new Button();
            button_add = new Button();
            DataGridView_user = new Guna.UI2.WinForms.Guna2DataGridView();
            panelReg = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox_user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_user).BeginInit();
            panelReg.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Fname
            // 
            Fname.AutoSize = true;
            Fname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Fname.ForeColor = Color.FromArgb(0, 71, 160);
            Fname.Location = new Point(93, 413);
            Fname.Name = "Fname";
            Fname.Size = new Size(104, 20);
            Fname.TabIndex = 1;
            Fname.Text = "First name :";
            // 
            // textBox_Fname
            // 
            textBox_Fname.Location = new Point(203, 410);
            textBox_Fname.Name = "textBox_Fname";
            textBox_Fname.Size = new Size(167, 26);
            textBox_Fname.TabIndex = 2;
            // 
            // textBox_Lname
            // 
            textBox_Lname.Location = new Point(498, 410);
            textBox_Lname.Name = "textBox_Lname";
            textBox_Lname.Size = new Size(167, 26);
            textBox_Lname.TabIndex = 5;
            // 
            // Lname
            // 
            Lname.AutoSize = true;
            Lname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Lname.ForeColor = Color.FromArgb(0, 71, 160);
            Lname.Location = new Point(389, 413);
            Lname.Name = "Lname";
            Lname.Size = new Size(103, 20);
            Lname.TabIndex = 4;
            Lname.Text = "Last name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(77, 484);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 6;
            label3.Text = "Date of birth :";
            // 
            // dateOfBirthPicker
            // 
            dateOfBirthPicker.Location = new Point(203, 481);
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.Size = new Size(289, 26);
            dateOfBirthPicker.TabIndex = 7;
            dateOfBirthPicker.ValueChanged += dateOfBirthPicker_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(649, 484);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 8;
            label4.Text = "Gender :";
            // 
            // maleButton
            // 
            maleButton.AutoSize = true;
            maleButton.Checked = true;
            maleButton.Font = new Font("Microsoft Sans Serif", 12F);
            maleButton.ForeColor = Color.FromArgb(0, 71, 160);
            maleButton.Location = new Point(743, 482);
            maleButton.Name = "maleButton";
            maleButton.Size = new Size(61, 24);
            maleButton.TabIndex = 9;
            maleButton.TabStop = true;
            maleButton.Text = "Male";
            maleButton.UseVisualStyleBackColor = true;
            maleButton.CheckedChanged += maleButton_CheckedChanged;
            // 
            // femaleButton
            // 
            femaleButton.AutoSize = true;
            femaleButton.Font = new Font("Microsoft Sans Serif", 12F);
            femaleButton.ForeColor = Color.FromArgb(0, 71, 160);
            femaleButton.Location = new Point(810, 482);
            femaleButton.Name = "femaleButton";
            femaleButton.Size = new Size(80, 24);
            femaleButton.TabIndex = 10;
            femaleButton.Text = "Female";
            femaleButton.UseVisualStyleBackColor = true;
            femaleButton.CheckedChanged += femaleButton_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(107, 546);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 11;
            label5.Text = "Address : ";
            // 
            // textBox_Address
            // 
            textBox_Address.Location = new Point(203, 546);
            textBox_Address.Multiline = true;
            textBox_Address.Name = "textBox_Address";
            textBox_Address.Size = new Size(660, 48);
            textBox_Address.TabIndex = 12;
            textBox_Address.TextChanged += textBox_Address_TextChanged;
            // 
            // pictureBox_user
            // 
            pictureBox_user.BackColor = Color.Silver;
            pictureBox_user.Location = new Point(1006, 399);
            pictureBox_user.Name = "pictureBox_user";
            pictureBox_user.Size = new Size(122, 118);
            pictureBox_user.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_user.TabIndex = 13;
            pictureBox_user.TabStop = false;
            // 
            // button_upload
            // 
            button_upload.BackColor = Color.Green;
            button_upload.FlatStyle = FlatStyle.Flat;
            button_upload.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(1006, 535);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(122, 48);
            button_upload.TabIndex = 14;
            button_upload.Text = "Upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click;
            // 
            // textBox_Phone
            // 
            textBox_Phone.Location = new Point(757, 410);
            textBox_Phone.Name = "textBox_Phone";
            textBox_Phone.Size = new Size(167, 26);
            textBox_Phone.TabIndex = 16;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Phone.ForeColor = Color.FromArgb(0, 71, 160);
            Phone.Location = new Point(676, 413);
            Phone.Name = "Phone";
            Phone.Size = new Size(75, 20);
            Phone.TabIndex = 15;
            Phone.Text = "Phone : ";
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(878, 623);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(122, 48);
            button_clear.TabIndex = 17;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.FromArgb(0, 71, 160);
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(1006, 623);
            button_add.Name = "button_add";
            button_add.Size = new Size(122, 48);
            button_add.TabIndex = 18;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
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
            DataGridView_user.Location = new Point(12, 71);
            DataGridView_user.Name = "DataGridView_user";
            DataGridView_user.RowHeadersVisible = false;
            DataGridView_user.RowTemplate.Height = 80;
            DataGridView_user.Size = new Size(1116, 309);
            DataGridView_user.TabIndex = 21;
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
            // 
            // panelReg
            // 
            panelReg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelReg.BackColor = Color.FromArgb(0, 71, 160);
            panelReg.Controls.Add(label7);
            panelReg.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            panelReg.ForeColor = Color.White;
            panelReg.Location = new Point(0, 0);
            panelReg.Name = "panelReg";
            panelReg.Size = new Size(1140, 65);
            panelReg.TabIndex = 22;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label7.Location = new Point(510, 21);
            label7.Name = "label7";
            label7.Size = new Size(120, 24);
            label7.TabIndex = 0;
            label7.Text = "Registration";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Location = new Point(12, 379);
            panel2.Name = "panel2";
            panel2.Size = new Size(1116, 14);
            panel2.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panelReg);
            panel1.Controls.Add(DataGridView_user);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 410);
            panel1.TabIndex = 19;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1140, 690);
            Controls.Add(panel1);
            Controls.Add(button_add);
            Controls.Add(button_clear);
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
            Controls.Add(textBox_Fname);
            Controls.Add(Fname);
            Font = new Font("Microsoft Sans Serif", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_user).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_user).EndInit();
            panelReg.ResumeLayout(false);
            panelReg.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Fname;
        private TextBox textBox_Fname;
        private TextBox textBox_Lname;
        private Label Lname;
        private Label label3;
        private DateTimePicker dateOfBirthPicker;
        private Label label4;
        private RadioButton maleButton;
        private RadioButton femaleButton;
        private Label label5;
        private TextBox textBox_Address;
        private PictureBox pictureBox_user;
        private Button button_upload;
        private TextBox textBox_Phone;
        private Label Phone;
        private Button button_clear;
        private Button button_add;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_user;
        private Panel panelReg;
        private Label label7;
        private Panel panel2;
        private Panel panel1;
    }
}