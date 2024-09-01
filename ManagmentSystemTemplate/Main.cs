namespace ManagmentSystemTemplate
{
    public partial class MainForm : Form
    {
        UserClass user = new UserClass();
        public MainForm()
        {
            InitializeComponent();
            customizedDesign();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userCount();
        }

        private void userCount()
        {
            label_total.Text = "Total Users: " + user.totalUser();
            label_male.Text = "Male : " + user.maleUser();
            label_female.Text = "Female : " + user.femaleUser();
        }

        private void customizedDesign()
        {
            panel_usrsubmenu.Visible = false;
            panel_groupsubmenu.Visible = false;
            panel_scoresubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel_usrsubmenu.Visible == true)
                panel_usrsubmenu.Visible = false;
            if (panel_groupsubmenu.Visible == true)
                panel_groupsubmenu.Visible = false;
            if (panel_scoresubmenu.Visible == true)
                panel_scoresubmenu.Visible = false;
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void button_usr_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_usrsubmenu);
        }

        #region     UsrSubMenu
        private void button_registration_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            hideSubMenu();
        }

        private void button_manageUsr_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageUser());
            hideSubMenu();
        }

        private void button_usrPrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintUser());
            hideSubMenu();
        }

        #endregion UsrSubMenu
        private void button_group_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_groupsubmenu);
        }

        #region GroupSubMenu
        private void button_newGroup_Click(object sender, EventArgs e)
        {
            openChildForm(new Group());
            hideSubMenu();
        }

        private void button_manageGroup_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageGroup());
            hideSubMenu();
        }

        private void button_groupPrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintGroup());
            hideSubMenu();
        }

        #endregion GroupSubMenu
        private void button_score_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_scoresubmenu);
        }

        #region ScoreSubMenu
        private void button_newScore_Click(object sender, EventArgs e)
        {
            openChildForm(new Score());
            hideSubMenu();
        }

        private void button_manageScore_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageScore());
            hideSubMenu();
        }

        private void button_scorePrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintScore());
            hideSubMenu();
        }

        #endregion ScoreSubMenu

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
            userCount();
        }
    }
}
