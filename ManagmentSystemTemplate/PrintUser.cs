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

namespace ManagmentSystemTemplate
{
    public partial class PrintUser : Form
    {
        UserClass user = new UserClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintUser()
        {
            InitializeComponent();
        }

        private void ToPrint_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM `user`"));
        }

        public void showData(MySqlCommand command)
        {
            DataGridView_user.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            DataGridView_user.DataSource = user.getList(command);
            imageColumn = (DataGridViewImageColumn)DataGridView_user.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string selectQuery;
            if (allButton.Checked)
            {
                selectQuery = "SELECT * FROM `user` ";
            }
            else if (maleButton.Checked)
            {
                selectQuery = "SELECT * FROM `user` WHERE `Gender` = 'Male'";
            }
            else
            {
                selectQuery = "SELECT * FROM `user` WHERE `Gender` = 'Female'";
            }

            showData(new MySqlCommand(selectQuery));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "User list";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "footext";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_user);
        }
    }
}
