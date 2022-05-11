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
        private IEquipRepository _equipRepository; //nu am get si nici set; nu am instantiat o 

        public UserPage()
        {
            InitializeComponent();
            //instantierea variab private
            _equipRepository = new EquipRepository();
            equipDataGrid1.DataSource = _equipRepository.GetBARBATI();
            equipDataGrid2.DataSource = _equipRepository.GetFEMEI();
            equipDataGrid3.DataSource = _equipRepository.GetCOPII();
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


        //abuzarea extension methods impiedica testarea codului
    }
}
