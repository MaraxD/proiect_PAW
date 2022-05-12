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
    public partial class FemeiPage : Form
    {
        private IEquipRepository _equipRepository;
        public FemeiPage()
        {
            InitializeComponent();
            _equipRepository = new EquipRepository();
            equipDataGrid2.DataSource = _equipRepository.GetFEMEI();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var home = new UserPage();
            home.Show();
            Hide();
        }
    }
}
