using seminar9.Database;
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
    public partial class StoresPage : Form
    {
        public StoresPage()
        {
            InitializeComponent();
            storesDataGrid.AutoGenerateColumns = false; 
            storesDataGrid.ColumnCount = 4;

            AddColumn(0, "City", "Oras");
            AddColumn(1, "Location", "Adresa");
            AddColumn(2, "PhoneNumber", "telefon"); //bro dc nu apar
            AddColumn(3, "Program", "Program");

            storesDataGrid.DataSource = StoresDatabase.stores;

        }

        private void AddColumn(int id, string property, string header)
        {
            storesDataGrid.Columns[id].HeaderText = header;
            storesDataGrid.Columns[id].DataPropertyName = property;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var home = new UserPage();
            home.Show();
            Hide();
        }
    }
}
