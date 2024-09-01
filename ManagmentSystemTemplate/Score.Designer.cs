namespace ManagmentSystemTemplate
{
    partial class Score
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
            textBox_score = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panelReg = new Panel();
            button_sScore = new Button();
            button_sUser = new Button();
            DataGridView_user = new Guna.UI2.WinForms.Guna2DataGridView();
            button_add = new Button();
            button_clear = new Button();
            textBox_GDescription = new TextBox();
            label5 = new Label();
            Lname = new Label();
            textBox_userId = new TextBox();
            Fname = new Label();
            comboBox_group = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panelReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_user).BeginInit();
            SuspendLayout();
            // 
            // textBox_score
            // 
            textBox_score.Location = new Point(153, 563);
            textBox_score.Name = "textBox_score";
            textBox_score.Size = new Size(167, 26);
            textBox_score.TabIndex = 47;
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
            panel1.TabIndex = 46;
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
            panelReg.Controls.Add(button_sScore);
            panelReg.Controls.Add(button_sUser);
            panelReg.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            panelReg.ForeColor = Color.White;
            panelReg.Location = new Point(0, 0);
            panelReg.Name = "panelReg";
            panelReg.Size = new Size(1140, 65);
            panelReg.TabIndex = 22;
            // 
            // button_sScore
            // 
            button_sScore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_sScore.BackColor = Color.White;
            button_sScore.FlatStyle = FlatStyle.Flat;
            button_sScore.ForeColor = Color.FromArgb(0, 71, 160);
            button_sScore.Location = new Point(996, 12);
            button_sScore.Name = "button_sScore";
            button_sScore.Size = new Size(132, 39);
            button_sScore.TabIndex = 1;
            button_sScore.Text = "Show Score";
            button_sScore.UseVisualStyleBackColor = false;
            button_sScore.Click += button_sScore_Click;
            // 
            // button_sUser
            // 
            button_sUser.BackColor = Color.White;
            button_sUser.FlatStyle = FlatStyle.Flat;
            button_sUser.ForeColor = Color.FromArgb(0, 71, 160);
            button_sUser.Location = new Point(12, 12);
            button_sUser.Name = "button_sUser";
            button_sUser.Size = new Size(132, 39);
            button_sUser.TabIndex = 0;
            button_sUser.Text = "Show User";
            button_sUser.UseVisualStyleBackColor = false;
            button_sUser.Click += button_sUser_Click;
            // 
            // DataGridView_user
            // 
            DataGridView_user.AllowUserToAddRows = false;
            DataGridView_user.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView_user.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_user.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            DataGridView_user.Click += DataGridView_user_Click;
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.FromArgb(0, 71, 160);
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(1006, 638);
            button_add.Name = "button_add";
            button_add.Size = new Size(122, 48);
            button_add.TabIndex = 45;
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
            button_clear.Location = new Point(878, 638);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(122, 48);
            button_clear.TabIndex = 44;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // textBox_GDescription
            // 
            textBox_GDescription.Location = new Point(153, 610);
            textBox_GDescription.Multiline = true;
            textBox_GDescription.Name = "textBox_GDescription";
            textBox_GDescription.Size = new Size(548, 68);
            textBox_GDescription.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(34, 613);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 42;
            label5.Text = "Description :";
            // 
            // Lname
            // 
            Lname.AutoSize = true;
            Lname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Lname.ForeColor = Color.FromArgb(0, 71, 160);
            Lname.Location = new Point(78, 569);
            Lname.Name = "Lname";
            Lname.Size = new Size(66, 20);
            Lname.TabIndex = 41;
            Lname.Text = "Score :";
            // 
            // textBox_userId
            // 
            textBox_userId.Location = new Point(153, 457);
            textBox_userId.Name = "textBox_userId";
            textBox_userId.Size = new Size(167, 26);
            textBox_userId.TabIndex = 40;
            // 
            // Fname
            // 
            Fname.AutoSize = true;
            Fname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Fname.ForeColor = Color.FromArgb(0, 71, 160);
            Fname.Location = new Point(63, 460);
            Fname.Name = "Fname";
            Fname.Size = new Size(81, 20);
            Fname.TabIndex = 39;
            Fname.Text = "User ID :";
            // 
            // comboBox_group
            // 
            comboBox_group.FormattingEnabled = true;
            comboBox_group.Location = new Point(153, 509);
            comboBox_group.Name = "comboBox_group";
            comboBox_group.Size = new Size(548, 28);
            comboBox_group.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(19, 512);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 49;
            label1.Text = "Select Group :";
            // 
            // Score
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 690);
            Controls.Add(label1);
            Controls.Add(comboBox_group);
            Controls.Add(textBox_score);
            Controls.Add(panel1);
            Controls.Add(button_add);
            Controls.Add(button_clear);
            Controls.Add(textBox_GDescription);
            Controls.Add(label5);
            Controls.Add(Lname);
            Controls.Add(textBox_userId);
            Controls.Add(Fname);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "Score";
            Text = "Score";
            Load += Score_Load;
            panel1.ResumeLayout(false);
            panelReg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView_user).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_score;
        private Panel panel1;
        private Panel panel2;
        private Panel panelReg;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_user;
        private Button button_add;
        private Button button_clear;
        private TextBox textBox_GDescription;
        private Label label5;
        private Label Lname;
        private TextBox textBox_userId;
        private Label Fname;
        private ComboBox comboBox_group;
        private Label label1;
        private Button button_sScore;
        private Button button_sUser;
    }
}