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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
            //afisez chestiile cumparate in dataGridul de pe pagina asta
            dataGridView1.DataSource = BarbatiPage.equipmentsM;

            //intreaba l pe prof daca e posibil asa ceva
            /*dataGridView1.DataSource = FemeiPage.equipmentsW;
            dataGridView1.DataSource = CopiiPage.equipmentsC;*/

            sumValTotala();
        }


        private void sumValTotala()
        {
            double sumTotal = 0;
            foreach (var equip in dataGridView1.DataSource as List<Equipment>)
            {
                sumTotal += equip.Price;
            }
            valTotalaLabel.Text = Convert.ToString(sumTotal);
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            var stuff = new Sales();
            stuff.IdSale = Guid.NewGuid();
            stuff.Name = numeText.Text;
            stuff.Surname = prenumeText.Text;
            if (onlineCheckBox.Checked)
            {
                stuff.PaymentMethod = "Online";
            }
            else
            {
                stuff.PaymentMethod = "Ramburs";
            }


            //cum fac chestia asta
            foreach (var equips in dataGridView1.DataSource as List<Equipment>)
            {
                stuff.Equipments.Description = equips.Description;
                stuff.Equipments.Color = equips.Color;
                stuff.Equipments.Price = equips.Price;
            }

            SalesDatabase.boughtE.Add(stuff); //le am adaugat in baza de date, trebuie sa le afisezi si in formul din AdminPage
            MessageBox.Show("Comanda ta este in curs de procesare"); /*Hide();*/
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var back = new UserPage();
            back.Show();
            Hide();
        }
    }
}
