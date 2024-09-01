using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagmentSystemTemplate
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        int startPoint = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            ProgressIndicator.Start();
            if(startPoint > 35)
            {
                Login login = new Login();
                ProgressIndicator.Stop();
                timer.Stop();
                this.Hide();
                login.Show();
            }
        }
    }
}
