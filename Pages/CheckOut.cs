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

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numeText.Text))
            {
                e.Cancel = true;
                numeText.Focus();
                errorName.SetError(numeText, "Name should not be left blank!");
            }else if (string.IsNullOrWhiteSpace(prenumeText.Text))
            {
                e.Cancel = true;
                prenumeText.Focus();
                errorPrenume.SetError(prenumeText, "Prenume should not be left blank!");
            }else if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorAdress.SetError(textBox3, "Adress should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorName.SetError(numeText, "");
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(numeText.Text, "Demo App - Message!");
                return;
            }
            
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
                    stuff.equipDescription = equips.Description;
                }

                stuff.TotalValue = sumValTotala();

                SalesDatabase.boughtE.Add(stuff); //le am adaugat in baza de date, trebuie sa le afisezi si in formul din AdminPage
                MessageBox.Show("Comanda ta este in curs de procesare");
                Hide();
                
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
