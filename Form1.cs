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
    public partial class Form1 : Form
    {
        private IPlaneRepository _planeRepository; //nu am get si nici set; nu am instantiat o 

        public Form1()
        {
            InitializeComponent();
            //instantierea variab private
            _planeRepository = new PlaneRepository();
            planesDataGrid.DataSource = _planeRepository.GetALL();
        }

        private void addPlaneButton_Click(object sender, EventArgs e)
        {
            var addPlaneForm = new AddPlaneForm();
            addPlaneForm.Show();

            
        }

        //abuzarea extension methods impiedica testarea codului
    }
}
