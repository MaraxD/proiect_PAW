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

namespace seminar9.Pages
{
    public partial class DBAdmin : Form
    {
        private readonly IEquipRepository _equiprepository;
        private readonly Guid _id;
        public DBAdmin()
        {
            InitializeComponent();
            _equiprepository = new EquipRepository();

            AddColumn(0, "Description", "Description");
            AddColumn(1, "Price", "Price");
            AddColumn(2, "Color", "Color");

            var edit = new DataGridViewButtonColumn();
            edit.Text = "Edit";
            edit.HeaderText = " ";
            edit.Name = "edit";
            edit.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(edit);
            dataGridView2.Columns.Add(edit);
            dataGridView3.Columns.Add(edit);

            dataGridView1.CellClick += cellClick;
            dataGridView2.CellClick += cellClick;
            dataGridView3.CellClick += cellClick;

            dataGridView1.DataSource = FemeiDatabase.Equipments;
            dataGridView2.DataSource= BarbatiDatabase.Equipments;
            dataGridView3.DataSource= CopiiDatabase.Equipments;
        }

        /*private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
            {
                var ticket = _equiprepository.GetById(_id);
                ticket.Seat = Convert.ToInt32(seatTXT.Text);
                ticket.Price = Convert.ToDouble(priceTXT.Text);
                if (regularRB.Checked == true)
                {
                    ticket.TicketType = "Regular";
                }
                else
                {
                    ticket.TicketType = "VIP";
                }
                //inainte sa se adauge in the cart trebuie sa stim id ul
                var equip = dataGridView1.CurrentRow.DataBoundItem as Equipment;
                var bought = new Equipment();
                bought.Description = equip.Description;
                bought.Price = equip.Price;
                bought.Color = equip.Color;
                equipmentsM.Add(bought); //se aduga in lista asta de elem cumparate si dupa ar trebui sa fie afisate datele despre el 
                                         //in tabela aia din CheckOut
            }
        }*/

        private void AddColumn(int index, string property, string header)
        {
            dataGridView1.Columns[index].HeaderText = header;
            dataGridView2.Columns[index].HeaderText = header;
            dataGridView3.Columns[index].HeaderText = header;

            dataGridView1.Columns[index].DataPropertyName = property;
            dataGridView2.Columns[index].DataPropertyName = property;
            dataGridView3.Columns[index].DataPropertyName = property;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
