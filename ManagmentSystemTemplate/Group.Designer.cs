namespace ManagmentSystemTemplate
{
    partial class Group
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
            panel1 = new Panel();
            panel2 = new Panel();
            panelReg = new Panel();
            label7 = new Label();
            DataGridView_group = new Guna.UI2.WinForms.Guna2DataGridView();
            button_add = new Button();
            button_clear = new Button();
            textBox_GDescription = new TextBox();
            label5 = new Label();
            Lname = new Label();
            textBox_GName = new TextBox();
            Fname = new Label();
            textBox_GHour = new TextBox();
            panel1.SuspendLayout();
            panelReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_group).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panelReg);
            panel1.Controls.Add(DataGridView_group);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 410);
            panel1.TabIndex = 37;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Location = new Point(12, 386);
            panel2.Name = "panel2";
            panel2.Size = new Size(1116, 14);
            panel2.TabIndex = 23;
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
            label7.Location = new Point(510, 20);
            label7.Name = "label7";
            label7.Size = new Size(116, 24);
            label7.TabIndex = 0;
            label7.Text = "New Group";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DataGridView_group
            // 
            DataGridView_group.AllowUserToAddRows = false;
            DataGridView_group.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView_group.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_group.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_group.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_group.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_group.ColumnHeadersHeight = 24;
            DataGridView_group.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_group.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_group.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_group.Location = new Point(12, 71);
            DataGridView_group.Name = "DataGridView_group";
            DataGridView_group.RowHeadersVisible = false;
            DataGridView_group.RowTemplate.Height = 80;
            DataGridView_group.Size = new Size(1116, 309);
            DataGridView_group.TabIndex = 21;
            DataGridView_group.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_group.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_group.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_group.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_group.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_group.ThemeStyle.BackColor = Color.WhiteSmoke;
            DataGridView_group.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_group.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_group.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_group.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 12F);
            DataGridView_group.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_group.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_group.ThemeStyle.HeaderStyle.Height = 24;
            DataGridView_group.ThemeStyle.ReadOnly = false;
            DataGridView_group.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_group.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_group.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F);
            DataGridView_group.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_group.ThemeStyle.RowsStyle.Height = 80;
            DataGridView_group.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_group.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.FromArgb(0, 71, 160);
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(1006, 633);
            button_add.Name = "button_add";
            button_add.Size = new Size(122, 48);
            button_add.TabIndex = 36;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(878, 633);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(122, 48);
            button_clear.TabIndex = 35;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // textBox_GDescription
            // 
            textBox_GDescription.Location = new Point(56, 605);
            textBox_GDescription.Multiline = true;
            textBox_GDescription.Name = "textBox_GDescription";
            textBox_GDescription.Size = new Size(548, 68);
            textBox_GDescription.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(56, 582);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 29;
            label5.Text = "Description : ";
            // 
            // Lname
            // 
            Lname.AutoSize = true;
            Lname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Lname.ForeColor = Color.FromArgb(0, 71, 160);
            Lname.Location = new Point(56, 496);
            Lname.Name = "Lname";
            Lname.Size = new Size(58, 20);
            Lname.TabIndex = 22;
            Lname.Text = "Hour :";
            // 
            // textBox_GName
            // 
            textBox_GName.Location = new Point(56, 446);
            textBox_GName.Name = "textBox_GName";
            textBox_GName.Size = new Size(368, 26);
            textBox_GName.TabIndex = 21;
            // 
            // Fname
            // 
            Fname.AutoSize = true;
            Fname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Fname.ForeColor = Color.FromArgb(0, 71, 160);
            Fname.Location = new Point(56, 418);
            Fname.Name = "Fname";
            Fname.Size = new Size(120, 20);
            Fname.TabIndex = 20;
            Fname.Text = "Group Name :";
            // 
            // textBox_GHour
            // 
            textBox_GHour.Location = new Point(56, 536);
            textBox_GHour.Name = "textBox_GHour";
            textBox_GHour.Size = new Size(167, 26);
            textBox_GHour.TabIndex = 38;
            // 
            // Group
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 690);
            Controls.Add(textBox_GHour);
            Controls.Add(panel1);
            Controls.Add(button_add);
            Controls.Add(button_clear);
            Controls.Add(textBox_GDescription);
            Controls.Add(label5);
            Controls.Add(Lname);
            Controls.Add(textBox_GName);
            Controls.Add(Fname);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "Group";
            Text = "Group";
            Load += Group_Load;
            panel1.ResumeLayout(false);
            panelReg.ResumeLayout(false);
            panelReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_group).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelReg;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_group;
        private Button button_add;
        private Button button_clear;
        private Button button_upload;
        private PictureBox pictureBox_user;
        private TextBox textBox_GDescription;
        private Label label5;
        private RadioButton femaleButton;
        private RadioButton maleButton;
        private Label label4;
        private DateTimePicker dateOfBirthPicker;
        private Label label3;
        private TextBox textBox_Lname;
        private Label Lname;
        private TextBox textBox_GName;
        private Label Fname;
        private TextBox textBox_GHour;
    }
}