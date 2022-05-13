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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void planeSaveButton_Click(object sender, EventArgs e)
        {
            var plane = new Equipment();
            /*plane.Name = nameTextBox.Text;
            plane.Type = typeTextBox.Text;
            plane.Seats = Convert.ToInt32(seatsTextBox.Text);*/

            
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            var user = new UserPage();
            user.Show();
            Hide();
        }

        private void adminButton_Click_1(object sender, EventArgs e)
        {
            var user = new AuthPage();
            user.Show();
            Hide();
        }
    }
}
