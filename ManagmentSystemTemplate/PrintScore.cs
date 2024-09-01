using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using System.Reflection;

namespace ManagmentSystemTemplate
{
    public partial class PrintScore : Form
    {
        ScoreClass score = new ScoreClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintScore()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_scor.DataSource = score.getList(new MySqlCommand("SELECT score.Id,user.FirstName,user.LastName,score.GroupName,score.Score,score.Description FROM user INNER JOIN score ON score.Id = user.Id WHERE CONCAT(user.FirstName,user.LastName,score.GroupName) LIKE %" + textBox_search.Text + "%"));
        }

        public void showScore()
        {
            DataGridView_scor.DataSource = score.getList(new MySqlCommand("SELECT score.Id,user.FirstName,user.LastName,score.GroupName,score.Score,score.Description FROM user INNER JOIN score ON score.Id = user.Id"));
        }

        private void PrintScore_Load(object sender, EventArgs e)
        {
            showScore();
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "Score list";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "footext";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_scor);
        }
    }
}
