using seminar9.Database;
using seminar9.Entities;
using seminar9.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminar9
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            //salesDataView.AutoGenerateColumns = false;

           
            salesDataView.AutoGenerateColumns = false;
            salesDataView.ColumnCount = 4;

            if (SalesDatabase.boughtE.Count != 0)
            {
                emptyLabel.Hide();
                AddColumn(0, "FullName", "Full Name");
                AddColumn(1, "equipDescription", "Description");
                AddColumn(2, "PaymentMethod", "Payment Method");
                AddColumn(3, "TotalValue", "Total Value");
            }
            else
            {
                emptyLabel.Show();
            }


            salesDataView.DataSource = SalesDatabase.boughtE; //initial, baza mea de date e goala

        }

        private void AddColumn(int index, string property, string header)
        {
            salesDataView.Columns[index].HeaderText = header;
            salesDataView.Columns[index].DataPropertyName = property;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var exit = new Main();
            exit.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var adminDB = new DBAdmin();
            adminDB.Show();

        }
    }
}
