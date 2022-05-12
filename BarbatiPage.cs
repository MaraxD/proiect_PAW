﻿using seminar9.Database;
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
    public partial class BarbatiPage : Form
    {
        private readonly IEquipRepository _equipRepository;
        
        public BarbatiPage()
        {
            InitializeComponent();
            _equipRepository = new EquipRepository();


            equipDataGrid1.AutoGenerateColumns = false; //ce face

            equipDataGrid1.ColumnCount = 3;

            //butoane
            var addToCart = new DataGridViewButtonColumn();
            addToCart.HeaderText = " ";
            addToCart.Text = "Add to cart";
            addToCart.Name = "addToCart";
            addToCart.UseColumnTextForButtonValue = true; 
            equipDataGrid1.Columns.Add(addToCart);


            equipDataGrid1.CellClick += cellClick;
            equipDataGrid1.DataSource = _equipRepository.GetBARBATI();

        }

        public static List<Equipment> equipmentsM = new List<Equipment>();

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == equipDataGrid1.Columns["addToCart"].Index)
            {
                //inainte sa se adauge in the cart trebuie sa stim id ul
                var equip = equipDataGrid1.CurrentRow.DataBoundItem as Equipment;
                var bought=new Equipment();
                bought.Description = equip.Description;
                bought.Price = equip.Price;
                bought.Color = equip.Color;
                equipmentsM.Add(bought); //se aduga in lista asta de elem cumparate si dupa ar trebui sa fie afisate datele despre el 
                                        //in tabela aia din CheckOut
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var home = new UserPage();
            home.Show();
            Hide();
        }
    }
}
