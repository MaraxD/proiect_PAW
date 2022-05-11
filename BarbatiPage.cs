﻿using seminar9.Repositories;
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
        private IEquipRepository _equipRepository;
        public BarbatiPage()
        {
            InitializeComponent();
            _equipRepository = new EquipRepository();
            equipDataGrid1.DataSource = _equipRepository.GetBARBATI();

            equipDataGrid1.AutoGenerateColumns = false; //ce face

            equipDataGrid1.ColumnCount = 3;

            //butoane
            var addToCart = new DataGridViewButtonColumn();
            addToCart.Text = "Add to cart";
            addToCart.UseColumnTextForButtonValue = true; //ce face lol
            //addToCart.CellClick+=





        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var home = new UserPage();
            home.Show();
            Hide();
        }
    }
}