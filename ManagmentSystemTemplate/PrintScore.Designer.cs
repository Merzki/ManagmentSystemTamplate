namespace ManagmentSystemTemplate
{
    partial class PrintScore
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
            button_search = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label7 = new Label();
            textBox_search = new TextBox();
            button_print = new Button();
            DataGridView_scor = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_scor).BeginInit();
            SuspendLayout();
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.FromArgb(0, 71, 160);
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(1006, 82);
            button_search.Name = "button_search";
            button_search.Size = new Size(122, 48);
            button_search.TabIndex = 73;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Location = new Point(12, 539);
            panel2.Name = "panel2";
            panel2.Size = new Size(1116, 14);
            panel2.TabIndex = 72;
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
            panel1.TabIndex = 71;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label7.Location = new Point(512, 20);
            label7.Name = "label7";
            label7.Size = new Size(113, 24);
            label7.TabIndex = 0;
            label7.Text = "Score Print";
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(813, 93);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(187, 26);
            textBox_search.TabIndex = 74;
            // 
            // button_print
            // 
            button_print.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_print.BackColor = Color.FromArgb(0, 71, 160);
            button_print.FlatStyle = FlatStyle.Flat;
            button_print.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button_print.ForeColor = Color.White;
            button_print.Location = new Point(1006, 639);
            button_print.Name = "button_print";
            button_print.Size = new Size(122, 48);
            button_print.TabIndex = 70;
            button_print.Text = "Print";
            button_print.UseVisualStyleBackColor = false;
            button_print.Click += button_print_Click;
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
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView_scor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView_scor.ColumnHeadersHeight = 24;
            DataGridView_scor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView_scor.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView_scor.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView_scor.Location = new Point(12, 139);
            DataGridView_scor.Name = "DataGridView_scor";
            DataGridView_scor.RowHeadersVisible = false;
            DataGridView_scor.RowTemplate.Height = 80;
            DataGridView_scor.Size = new Size(1116, 394);
            DataGridView_scor.TabIndex = 69;
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
            // 
            // PrintScore
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 690);
            Controls.Add(button_search);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox_search);
            Controls.Add(button_print);
            Controls.Add(DataGridView_scor);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4);
            Name = "PrintScore";
            Text = "PrintScore";
            Load += PrintScore_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_scor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_search;
        private Panel panel2;
        private Panel panel1;
        private Label label7;
        private TextBox textBox_search;
        private Button button_print;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_scor;
    }
}