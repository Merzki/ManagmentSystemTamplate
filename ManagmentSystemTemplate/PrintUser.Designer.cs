namespace ManagmentSystemTemplate
{
    partial class PrintUser
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
            button_print = new Button();
            femaleButton = new RadioButton();
            maleButton = new RadioButton();
            label4 = new Label();
            DataGridView_user = new Guna.UI2.WinForms.Guna2DataGridView();
            allButton = new RadioButton();
            label1 = new Label();
            comboBox_group = new ComboBox();
            button_search = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_user).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Location = new Point(12, 530);
            panel2.Name = "panel2";
            panel2.Size = new Size(1116, 14);
            panel2.TabIndex = 50;
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
            panel1.TabIndex = 49;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label7.Location = new Point(529, 20);
            label7.Name = "label7";
            label7.Size = new Size(101, 24);
            label7.TabIndex = 0;
            label7.Text = "Print User";
            // 
            // button_print
            // 
            button_print.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_print.BackColor = Color.FromArgb(0, 71, 160);
            button_print.FlatStyle = FlatStyle.Flat;
            button_print.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_print.ForeColor = Color.White;
            button_print.Location = new Point(1006, 630);
            button_print.Name = "button_print";
            button_print.Size = new Size(122, 48);
            button_print.TabIndex = 48;
            button_print.Text = "Print";
            button_print.UseVisualStyleBackColor = false;
            button_print.Click += button_print_Click;
            // 
            // femaleButton
            // 
            femaleButton.AutoSize = true;
            femaleButton.Font = new Font("Microsoft Sans Serif", 12F);
            femaleButton.ForeColor = Color.FromArgb(0, 71, 160);
            femaleButton.Location = new Point(183, 589);
            femaleButton.Name = "femaleButton";
            femaleButton.Size = new Size(80, 24);
            femaleButton.TabIndex = 47;
            femaleButton.Text = "Female";
            femaleButton.UseVisualStyleBackColor = true;
            // 
            // maleButton
            // 
            maleButton.AutoSize = true;
            maleButton.Font = new Font("Microsoft Sans Serif", 12F);
            maleButton.ForeColor = Color.FromArgb(0, 71, 160);
            maleButton.Location = new Point(269, 589);
            maleButton.Name = "maleButton";
            maleButton.Size = new Size(61, 24);
            maleButton.TabIndex = 46;
            maleButton.Text = "Male";
            maleButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(48, 589);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 45;
            label4.Text = "Gender :";
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
            DataGridView_user.Location = new Point(12, 130);
            DataGridView_user.Name = "DataGridView_user";
            DataGridView_user.RowHeadersVisible = false;
            DataGridView_user.RowTemplate.Height = 80;
            DataGridView_user.Size = new Size(1116, 394);
            DataGridView_user.TabIndex = 44;
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
            // allButton
            // 
            allButton.AutoSize = true;
            allButton.Checked = true;
            allButton.Font = new Font("Microsoft Sans Serif", 12F);
            allButton.ForeColor = Color.FromArgb(0, 71, 160);
            allButton.Location = new Point(133, 589);
            allButton.Name = "allButton";
            allButton.Size = new Size(44, 24);
            allButton.TabIndex = 53;
            allButton.TabStop = true;
            allButton.Text = "All";
            allButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(655, 89);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 54;
            label1.Text = "Select Group :";
            // 
            // comboBox_group
            // 
            comboBox_group.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox_group.FormattingEnabled = true;
            comboBox_group.Location = new Point(786, 88);
            comboBox_group.Name = "comboBox_group";
            comboBox_group.Size = new Size(208, 23);
            comboBox_group.TabIndex = 55;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.FromArgb(0, 71, 160);
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(1006, 73);
            button_search.Name = "button_search";
            button_search.Size = new Size(122, 48);
            button_search.TabIndex = 56;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // PrintUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 690);
            Controls.Add(button_search);
            Controls.Add(comboBox_group);
            Controls.Add(label1);
            Controls.Add(allButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button_print);
            Controls.Add(femaleButton);
            Controls.Add(maleButton);
            Controls.Add(label4);
            Controls.Add(DataGridView_user);
            Name = "PrintUser";
            Text = "ToPrint";
            Load += ToPrint_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_user).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label7;
        private Button button_print;
        private RadioButton femaleButton;
        private RadioButton maleButton;
        private Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_user;
        private RadioButton allButton;
        private Label label1;
        private ComboBox comboBox_group;
        private Button button_search;
    }
}