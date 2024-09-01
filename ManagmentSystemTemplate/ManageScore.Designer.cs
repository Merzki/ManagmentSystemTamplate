namespace ManagmentSystemTemplate
{
    partial class ManageScore
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
            button_clear = new Button();
            DataGridView_scor = new Guna.UI2.WinForms.Guna2DataGridView();
            label7 = new Label();
            textBox_search = new TextBox();
            button_search = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            panelReg = new Panel();
            button_update = new Button();
            button_delete = new Button();
            label1 = new Label();
            comboBox_group = new ComboBox();
            textBox_score = new TextBox();
            textBox_GDescription = new TextBox();
            label5 = new Label();
            Lname = new Label();
            textBox_userId = new TextBox();
            Fname = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView_scor).BeginInit();
            panel1.SuspendLayout();
            panelReg.SuspendLayout();
            SuspendLayout();
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(750, 630);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(122, 48);
            button_clear.TabIndex = 62;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // DataGridView_scor
            // 
            DataGridView_scor.AllowUserToAddRows = false;
            DataGridView_scor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridView_scor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView_scor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_scor.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_scor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_scor.ColumnHeadersHeight = 24;
            DataGridView_scor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_scor.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_scor.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_scor.Location = new Point(12, 122);
            DataGridView_scor.Name = "DataGridView_scor";
            DataGridView_scor.RowHeadersVisible = false;
            DataGridView_scor.RowTemplate.Height = 80;
            DataGridView_scor.Size = new Size(1116, 309);
            DataGridView_scor.TabIndex = 21;
            DataGridView_scor.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView_scor.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView_scor.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView_scor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView_scor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView_scor.ThemeStyle.BackColor = Color.WhiteSmoke;
            DataGridView_scor.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_scor.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridView_scor.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView_scor.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 12F);
            DataGridView_scor.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridView_scor.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView_scor.ThemeStyle.HeaderStyle.Height = 24;
            DataGridView_scor.ThemeStyle.ReadOnly = false;
            DataGridView_scor.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView_scor.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView_scor.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 12F);
            DataGridView_scor.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_scor.ThemeStyle.RowsStyle.Height = 80;
            DataGridView_scor.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView_scor.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView_scor.Click += DataGridView_scor_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label7.Location = new Point(496, 20);
            label7.Name = "label7";
            label7.Size = new Size(146, 24);
            label7.TabIndex = 0;
            label7.Text = "Manage Score";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(786, 79);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(200, 26);
            textBox_search.TabIndex = 52;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.Orange;
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(1006, 68);
            button_search.Name = "button_search";
            button_search.Size = new Size(122, 48);
            button_search.TabIndex = 51;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Location = new Point(12, 437);
            panel2.Name = "panel2";
            panel2.Size = new Size(1116, 14);
            panel2.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox_search);
            panel1.Controls.Add(button_search);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panelReg);
            panel1.Controls.Add(DataGridView_scor);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 454);
            panel1.TabIndex = 58;
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
            // button_update
            // 
            button_update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_update.BackColor = Color.OrangeRed;
            button_update.FlatStyle = FlatStyle.Flat;
            button_update.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_update.ForeColor = Color.White;
            button_update.Location = new Point(878, 630);
            button_update.Name = "button_update";
            button_update.Size = new Size(122, 48);
            button_update.TabIndex = 56;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.Red;
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(1006, 630);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(122, 48);
            button_delete.TabIndex = 57;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(15, 521);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 70;
            label1.Text = "Select Group :";
            // 
            // comboBox_group
            // 
            comboBox_group.FormattingEnabled = true;
            comboBox_group.Location = new Point(149, 518);
            comboBox_group.Name = "comboBox_group";
            comboBox_group.Size = new Size(548, 28);
            comboBox_group.TabIndex = 69;
            // 
            // textBox_score
            // 
            textBox_score.Location = new Point(149, 567);
            textBox_score.Name = "textBox_score";
            textBox_score.Size = new Size(167, 26);
            textBox_score.TabIndex = 68;
            // 
            // textBox_GDescription
            // 
            textBox_GDescription.Location = new Point(149, 610);
            textBox_GDescription.Multiline = true;
            textBox_GDescription.Name = "textBox_GDescription";
            textBox_GDescription.Size = new Size(548, 68);
            textBox_GDescription.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(30, 613);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 66;
            label5.Text = "Description :";
            // 
            // Lname
            // 
            Lname.AutoSize = true;
            Lname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Lname.ForeColor = Color.FromArgb(0, 71, 160);
            Lname.Location = new Point(74, 573);
            Lname.Name = "Lname";
            Lname.Size = new Size(66, 20);
            Lname.TabIndex = 65;
            Lname.Text = "Score :";
            // 
            // textBox_userId
            // 
            textBox_userId.Location = new Point(149, 467);
            textBox_userId.Name = "textBox_userId";
            textBox_userId.ReadOnly = true;
            textBox_userId.Size = new Size(60, 26);
            textBox_userId.TabIndex = 64;
            // 
            // Fname
            // 
            Fname.AutoSize = true;
            Fname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Fname.ForeColor = Color.FromArgb(0, 71, 160);
            Fname.Location = new Point(102, 470);
            Fname.Name = "Fname";
            Fname.Size = new Size(38, 20);
            Fname.TabIndex = 63;
            Fname.Text = "ID :";
            // 
            // ManageScore
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 690);
            Controls.Add(label1);
            Controls.Add(comboBox_group);
            Controls.Add(textBox_score);
            Controls.Add(textBox_GDescription);
            Controls.Add(label5);
            Controls.Add(Lname);
            Controls.Add(textBox_userId);
            Controls.Add(Fname);
            Controls.Add(button_clear);
            Controls.Add(panel1);
            Controls.Add(button_update);
            Controls.Add(button_delete);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "ManageScore";
            Text = "ManageScore";
            Load += ManageScore_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView_scor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelReg.ResumeLayout(false);
            panelReg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_clear;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_scor;
        private Label label1;
        private ComboBox comboBox_group;
        private TextBox textBox_score;
        private TextBox textBox_GDescription;
        private Label label5;
        private Label Lname;
        private TextBox textBox_userId;
        private Label Fname;
        private Label label7;
        private TextBox textBox_search;
        private Button button_search;
        private Panel panel2;
        private Panel panel1;
        private Panel panelReg;
        private Button button_update;
        private Button button_delete;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_score;
    }
}