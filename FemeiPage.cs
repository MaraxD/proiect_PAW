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
    public partial class FemeiPage : Form
    {
        private IEquipRepository _equipRepository;
        public FemeiPage()
        {
            InitializeComponent();
            _equipRepository = new EquipRepository();

            equipDataGrid2.AutoGenerateColumns = false; //ce face

            equipDataGrid2.ColumnCount = 3;

            //butoane
            var addToCart = new DataGridViewButtonColumn();
            addToCart.Text = "Add to cart";
            addToCart.Name = "addToCart";
            addToCart.UseColumnTextForButtonValue = true; //ce face lol
            equipDataGrid2.Columns.Add(addToCart);


            equipDataGrid2.CellClick += cellClick;

            equipDataGrid2.DataSource = _equipRepository.GetFEMEI();


        }

        public static List<Equipment> equipmentsW = new List<Equipment>();

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == equipDataGrid2.Columns["addToCart"].Index)
            {
                //inainte sa se adauge in the cart trebuie sa stim id ul
                var equip = equipDataGrid2.CurrentRow.DataBoundItem as Equipment;
                var bought = new Equipment();
                bought.Description = equip.Description;
                bought.Price = equip.Price;
                bought.Color = equip.Color;
                equipmentsW.Add(bought); //se aduga in lista asta de elem cumparate si dupa ar trebui sa fie afisate datele despre el 
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
