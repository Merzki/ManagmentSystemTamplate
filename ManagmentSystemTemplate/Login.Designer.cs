namespace ManagmentSystemTemplate
{
    partial class Login
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
            panel1 = new Panel();
            label_exit = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBox_name = new TextBox();
            textBox_pass = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button_login = new Button();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label_exit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 63);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label_exit
            // 
            label_exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_exit.AutoSize = true;
            label_exit.FlatStyle = FlatStyle.Flat;
            label_exit.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label_exit.ForeColor = Color.White;
            label_exit.Location = new Point(920, 2);
            label_exit.Name = "label_exit";
            label_exit.Size = new Size(30, 29);
            label_exit.TabIndex = 8;
            label_exit.Text = "X";
            label_exit.Click += label_exit_Click;
            label_exit.MouseEnter += label_exit_MouseEnter;
            label_exit.MouseLeave += label_exit_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.White;
            label2.Location = new Point(104, 23);
            label2.Name = "label2";
            label2.Size = new Size(292, 29);
            label2.TabIndex = 1;
            label2.Text = "Shark Managment System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 2);
            label1.Name = "label1";
            label1.Size = new Size(98, 55);
            label1.TabIndex = 0;
            label1.Text = "SM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(387, 350);
            label3.Name = "label3";
            label3.Size = new Size(176, 39);
            label3.TabIndex = 2;
            label3.Text = "Lets Start";
            // 
            // textBox_name
            // 
            textBox_name.Font = new Font("Microsoft Sans Serif", 14.25F);
            textBox_name.Location = new Point(257, 492);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(431, 29);
            textBox_name.TabIndex = 3;
            // 
            // textBox_pass
            // 
            textBox_pass.Font = new Font("Microsoft Sans Serif", 14.25F);
            textBox_pass.Location = new Point(257, 550);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.Size = new Size(431, 29);
            textBox_pass.TabIndex = 4;
            textBox_pass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(258, 470);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 5;
            label4.Text = "User Name : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(258, 528);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 6;
            label5.Text = "Password : ";
            // 
            // button_login
            // 
            button_login.BackColor = Color.Black;
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button_login.ForeColor = Color.White;
            button_login.Location = new Point(258, 600);
            button_login.Name = "button_login";
            button_login.Size = new Size(430, 46);
            button_login.TabIndex = 7;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.Location = new Point(290, 218);
            label7.Name = "label7";
            label7.Size = new Size(370, 73);
            label7.TabIndex = 8;
            label7.Text = "WELCOME";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 750);
            Controls.Add(label7);
            Controls.Add(button_login);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox_pass);
            Controls.Add(textBox_name);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBox_name;
        private TextBox textBox_pass;
        private Label label4;
        private Label label5;
        private Button button_login;
        private Label label_exit;
        private Label label7;
    }
}