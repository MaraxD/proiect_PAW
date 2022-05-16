﻿using seminar9.Database;
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
            dataGridView1.DataSource = BarbatiPage.equipmentsM;


            //intreaba l pe prof daca e posibil asa ceva
            /*dataGridView1.DataSource = FemeiPage.equipmentsW;
            dataGridView1.DataSource = CopiiPage.equipmentsC;*/

            sumValTotala();
        }

        private void delete_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dataGridView1.Columns["delete"].Index)
            {
                var equip = dataGridView1.CurrentRow.DataBoundItem as Equipment;
                BarbatiPage.equipmentsM.Remove(equip);
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

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (numeText.Text == " " ||
                prenumeText.Text == " " ||
                (onlineRB.Checked == false && rambursRB.Checked == false) || textBox3.Text == " ")
            {
                MessageBox.Show("cateva campuri au ramas necompletate!!");
            }
            else
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
                    stuff.equipDescription = equips.Description;
                }

                stuff.TotalValue = sumValTotala();

                SalesDatabase.boughtE.Add(stuff); //le am adaugat in baza de date, trebuie sa le afisezi si in formul din AdminPage
                MessageBox.Show("Comanda ta este in curs de procesare");
                Hide();
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var back = new UserPage();
            back.Show();
            Hide();
        }

    }
}
