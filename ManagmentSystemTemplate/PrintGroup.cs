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
using MySql.Data.MySqlClient;

namespace ManagmentSystemTemplate
{
    public partial class PrintGroup : Form
    {
        GroupClass group = new GroupClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintGroup()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_group.DataSource = group.searchGroupList(textBox_search.Text);
            textBox_search.Clear();
            DataGridView_group.RowTemplate.Height = 80;
        }

        private void GroupPrint_Load(object sender, EventArgs e)
        {
            DataGridView_group.DataSource = group.getGroup(new MySqlCommand("SELECT * FROM `groupp`"));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "Group list";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "footext";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_group);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
