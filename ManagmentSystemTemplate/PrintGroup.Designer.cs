namespace ManagmentSystemTemplate
{
    partial class PrintGroup
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            button_search = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label7 = new Label();
            button_print = new Button();
            DataGridView_group = new Guna.UI2.WinForms.Guna2DataGridView();
            textBox_search = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_group).BeginInit();
            SuspendLayout();
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.FromArgb(0, 71, 160);
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(1006, 79);
            button_search.Name = "button_search";
            button_search.Size = new Size(122, 48);
            button_search.TabIndex = 67;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Location = new Point(12, 536);
            panel2.Name = "panel2";
            panel2.Size = new Size(1116, 14);
            panel2.TabIndex = 63;
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
            panel1.TabIndex = 62;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label7.Location = new Point(529, 20);
            label7.Name = "label7";
            label7.Size = new Size(116, 24);
            label7.TabIndex = 0;
            label7.Text = "Group Print";
            // 
            // button_print
            // 
            button_print.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_print.BackColor = Color.FromArgb(0, 71, 160);
            button_print.FlatStyle = FlatStyle.Flat;
            button_print.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_print.ForeColor = Color.White;
            button_print.Location = new Point(1006, 636);
            button_print.Name = "button_print";
            button_print.Size = new Size(122, 48);
            button_print.TabIndex = 61;
            button_print.Text = "Print";
            button_print.UseVisualStyleBackColor = false;
            button_print.Click += button_print_Click;
            // 
            // DataGridView_group
            // 
            DataGridView_group.AllowUserToAddRows = false;
            DataGridView_group.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = Color.White;
            DataGridView_group.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            DataGridView_group.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView_group.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            DataGridView_group.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            DataGridView_group.ColumnHeadersHeight = 24;
            DataGridView_group.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            DataGridView_group.DefaultCellStyle = dataGridViewCellStyle15;
            DataGridView_group.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_group.Location = new Point(12, 136);
            DataGridView_group.Name = "DataGridView_group";
            DataGridView_group.RowHeadersVisible = false;
            DataGridView_group.RowTemplate.Height = 80;
            DataGridView_group.Size = new Size(1116, 394);
            DataGridView_group.TabIndex = 57;
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
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(813, 90);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(187, 26);
            textBox_search.TabIndex = 68;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // GroupPrint
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 690);
            Controls.Add(textBox_search);
            Controls.Add(button_search);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button_print);
            Controls.Add(DataGridView_group);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "GroupPrint";
            Text = "GroupPrint";
            Load += GroupPrint_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_group).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_search;
        private Panel panel2;
        private Panel panel1;
        private Label label7;
        private Button button_print;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_group;
        private TextBox textBox_search;
    }
}