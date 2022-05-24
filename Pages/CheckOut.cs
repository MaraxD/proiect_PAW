using seminar9.Database;
using seminar9.Entities;
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
    public partial class CheckOut : Form
    {
        private readonly IEquipRepository _equipRepository;
        public CheckOut()
        {
            InitializeComponent();
            _equipRepository = new EquipRepository();
            //afisez chestiile cumparate in dataGridul de pe pagina asta
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 3;

            AddColumn(0, "description", "Descriere");
            AddColumn(1, "price", "Pret");
            AddColumn(2, "color", "Culoare");

            //butonul de delete
            var delete = new DataGridViewButtonColumn();
            delete.HeaderText = " ";
            delete.Text = "Delete";
            delete.Name = "delete";
            delete.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(delete);


            dataGridView1.CellClick += delete_cellClick;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _equipRepository.GetBought();

            sumValTotala();
        }

        private void delete_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dataGridView1.Columns["delete"].Index)
            {
                var equip = dataGridView1.CurrentRow.DataBoundItem as Equipment;
                _equipRepository.GetBought().Remove(equip);
            }
            sumValTotala();
            dataGridView1.Refresh();

        }

        private void AddColumn(int index, string property, string header)
        {
            dataGridView1.Columns[index].HeaderText = header;
            dataGridView1.Columns[index].DataPropertyName = property;
        }


        private double sumValTotala()
        {
            double sumTotal = 0;
            foreach (var equip in dataGridView1.DataSource as BindingList<Equipment>)
            {
                sumTotal += equip.Price;
            }
            valTotalaLabel.Text = Convert.ToString(sumTotal);
            return Convert.ToDouble(valTotalaLabel.Text);
        }

        public List<string> descrp = new List<string>();

        /* public override string ToString()
         {
             foreach (var ceva in dataGridView1.DataSource as BindingList<Equipment>)
             {
                 return "{0}, ",ceva.Description;
             }
             return 0;

         }*/

        private bool FormIsValid()
        {
            if (string.IsNullOrEmpty(numeText.Text))
                return false;
            if (string.IsNullOrEmpty(prenumeText.Text))
                return false;
            if (string.IsNullOrEmpty(textBox3.Text))
                return false;
            if (!(rambursRB.Checked || onlineRB.Checked))
                return false;
            return true;
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void numeTextBox_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numeText.Text))
            {
                numeText.Focus();
                error.SetError(numeText, "Trebuie introdus un nume!");
            }
            else
            {
                error.SetError(numeText, string.Empty);
            }
        }

        private void prenumeTextBox_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(prenumeText.Text))
            {
                prenumeText.Focus();
                error.SetError(prenumeText, "Trebuie introdus un prenume!");
            }
            else
            {
                error.SetError(prenumeText, string.Empty);
            }
        }

        private void plataRadioBtn_validating(object sender, CancelEventArgs e)
        {
            if (!(rambursRB.Checked == false || onlineRB.Checked == false))
            {
                paymentLabel.Focus();
                error.SetError(paymentLabel, "Trebuie introdus un prenume!");
            }
            else
            {
                error.SetError(paymentLabel, string.Empty);
            }
        }

        private void adresaTextBox_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Focus();
                error.SetError(textBox3, "Trebuie introdusa o adresa");
            }
            else
            {
                error.SetError(textBox3, string.Empty);
            }
        }


        private void buyButton_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                var stuff = new Sales();
                stuff.IdSale = Guid.NewGuid();
                stuff.FullName = numeText.Text + " " + prenumeText.Text;
                if (onlineRB.Checked == true)
                {
                    stuff.PaymentMethod = onlineRB.Text;
                }
                else
                {
                    stuff.PaymentMethod = rambursRB.Text;
                }

                foreach (var equips in dataGridView1.DataSource as BindingList<Equipment>)
                {
                    descrp.Add(equips.Description);
                }
                stuff.equipDescription = descrp.ToString();

                stuff.TotalValue = sumValTotala();

                SalesDatabase.boughtE.Add(stuff); //le am adaugat in baza de date, trebuie sa le afisezi si in formul din AdminPage
                MessageBox.Show("You order is being processed!");
                Hide();
            }
            else
            {
                MessageBox.Show("Some data might be missing, check the form and try again.");
            }



        }

        
    }
}
