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
            dataGridView1.DataSource = FemeiPage.equipmentsW; 
            dataGridView1.DataSource = CopiiPage.equipmentsC; 
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
            List<Equipment> equipBought = new List<Equipment>();
            foreach(DataGridViewRow drow in dataGridView1.Rows)
            {
                Equipment equip = new Equipment();
                foreach(DataGridViewCell dc in drow.Cells)
                {
                    equipBought.Add((Equipment)dc.Value);
                    
                }
                
            }
            stuff.Equipments = equipBought; //lista cu echipamentele cumparate
            
            SalesDatabase.boughtE.Add(stuff); //le am adaugat in baza de date, trebuie sa le afisezi si in formul din AdminPage
            MessageBox.Show("Comanda ta este in curs de procesare"); /*Hide();*/
            Hide();
        }
    }
}
