using seminar9.Database;
using seminar9.Entities;
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
            salesDataView.DataSource = SalesDatabase.boughtE; //initial, baza mea de date e goala
            
        }

     

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var exit = new Main();
            exit.Show();
            Hide();
        }
    }
}
