using seminar9.Repositories;
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
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void addPlaneButton_Click(object sender, EventArgs e)
        {
            var addPlaneForm = new Main();
            addPlaneForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var exit = new Main();
            exit.Show();
            Hide();
        }

        private void wStripMenuItem_Click(object sender, EventArgs e)
        {
            var women = new FemeiPage();
            women.Show();
            Hide();
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var men = new BarbatiPage();
            men.Show();
            Hide();
        }

        private void cStripMenuItem_Click(object sender, EventArgs e)
        {
            var kids = new CopiiPage();
            kids.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var checkOut = new CheckOut();
            checkOut.Show();
            Hide();
        }


        //abuzarea extension methods impiedica testarea codului
    }
}
