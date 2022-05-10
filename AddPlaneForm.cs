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
    public partial class AddPlaneForm : Form
    {
        public AddPlaneForm()
        {
            InitializeComponent();
        }

        private void planeSaveButton_Click(object sender, EventArgs e)
        {
            var plane = new Plane();
            plane.Name = nameTextBox.Text;
            plane.Type = typeTextBox.Text;
            plane.Seats = Convert.ToInt32(seatsTextBox.Text);

            
        }
    }
}
