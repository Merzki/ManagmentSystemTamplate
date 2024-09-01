namespace ManagmentSystemTemplate
{
    partial class ManageGroup
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
            textBox_GHour = new TextBox();
            panel1 = new Panel();
            textBox_search = new TextBox();
            button_search = new Button();
            panel2 = new Panel();
            panelReg = new Panel();
            label7 = new Label();
            DataGridView_group = new Guna.UI2.WinForms.Guna2DataGridView();
            button_delete = new Button();
            button_update = new Button();
            textBox_GDescription = new TextBox();
            label5 = new Label();
            Lname = new Label();
            textBox_GName = new TextBox();
            Fname = new Label();
            textBox_id = new TextBox();
            label1 = new Label();
            button_clear = new Button();
            panel1.SuspendLayout();
            panelReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_group).BeginInit();
            SuspendLayout();
            // 
            // textBox_GHour
            // 
            textBox_GHour.Location = new Point(56, 551);
            textBox_GHour.Name = "textBox_GHour";
            textBox_GHour.Size = new Size(167, 26);
            textBox_GHour.TabIndex = 47;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox_search);
            panel1.Controls.Add(button_search);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panelReg);
            panel1.Controls.Add(DataGridView_group);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 454);
            panel1.TabIndex = 46;
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(786, 82);
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
            button_search.Location = new Point(1006, 71);
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
            label7.Location = new Point(512, 20);
            label7.Name = "label7";
            label7.Size = new Size(149, 24);
            label7.TabIndex = 0;
            label7.Text = "Manage Group";
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
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_group.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_group.ColumnHeadersHeight = 24;
            DataGridView_group.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_group.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_group.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_group.Location = new Point(12, 122);
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
            DataGridView_group.Click += DataGridView_group_Click;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.Red;
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(1006, 638);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(122, 48);
            button_delete.TabIndex = 45;
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
            button_update.Location = new Point(878, 638);
            button_update.Name = "button_update";
            button_update.Size = new Size(122, 48);
            button_update.TabIndex = 44;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = false;
            button_update.Click += button_update_Click;
            // 
            // textBox_GDescription
            // 
            textBox_GDescription.Location = new Point(56, 610);
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
            label5.Location = new Point(56, 587);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 42;
            label5.Text = "Description : ";
            // 
            // Lname
            // 
            Lname.AutoSize = true;
            Lname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Lname.ForeColor = Color.FromArgb(0, 71, 160);
            Lname.Location = new Point(56, 511);
            Lname.Name = "Lname";
            Lname.Size = new Size(58, 20);
            Lname.TabIndex = 41;
            Lname.Text = "Hour :";
            // 
            // textBox_GName
            // 
            textBox_GName.Location = new Point(56, 480);
            textBox_GName.Name = "textBox_GName";
            textBox_GName.Size = new Size(368, 26);
            textBox_GName.TabIndex = 40;
            // 
            // Fname
            // 
            Fname.AutoSize = true;
            Fname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            Fname.ForeColor = Color.FromArgb(0, 71, 160);
            Fname.Location = new Point(56, 457);
            Fname.Name = "Fname";
            Fname.Size = new Size(120, 20);
            Fname.TabIndex = 39;
            Fname.Text = "Group Name :";
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(253, 551);
            textBox_id.Name = "textBox_id";
            textBox_id.ReadOnly = true;
            textBox_id.Size = new Size(49, 26);
            textBox_id.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(253, 511);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 48;
            label1.Text = "Group Id :";
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(750, 638);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(122, 48);
            button_clear.TabIndex = 50;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // ManageGroup
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 690);
            Controls.Add(button_clear);
            Controls.Add(textBox_id);
            Controls.Add(label1);
            Controls.Add(textBox_GHour);
            Controls.Add(panel1);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(textBox_GDescription);
            Controls.Add(label5);
            Controls.Add(Lname);
            Controls.Add(textBox_GName);
            Controls.Add(Fname);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "ManageGroup";
            Text = "ManageGroupcs";
            Load += ManageGroupcs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelReg.ResumeLayout(false);
            panelReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_group).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_GHour;
        private Panel panel1;
        private Panel panel2;
        private Panel panelReg;
        private Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_group;
        private Button button_delete;
        private Button button_update;
        private TextBox textBox_GDescription;
        private Label label5;
        private Label Lname;
        private TextBox textBox_GName;
        private Label Fname;
        private TextBox textBox_id;
        private Label label1;
        private Button button_clear;
        private TextBox textBox_search;
        private Button button_search;
    }
}