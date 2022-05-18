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
        public DBAdmin()
        {
            InitializeComponent();
            _equiprepository = new EquipRepository();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView3.AutoGenerateColumns = false;

            dataGridView1.ColumnCount = 3;
            dataGridView2.ColumnCount = 3;
            dataGridView3.ColumnCount = 3;


            AddColumn(0, "Description", "Description");
            AddColumn(1, "Price", "Price");
            AddColumn(2, "Color", "Color");

            var edit = new DataGridViewButtonColumn();
            edit.Text = "Edit";
            edit.HeaderText = " ";
            edit.Name = "edit";
            edit.UseColumnTextForButtonValue = true;

            var edit2 = new DataGridViewButtonColumn();
            edit2.Text = "Edit";
            edit2.HeaderText = " ";
            edit2.Name = "edit2";
            edit2.UseColumnTextForButtonValue = true;

            var edit3 = new DataGridViewButtonColumn();
            edit3.Text = "Edit";
            edit3.HeaderText = " ";
            edit3.Name = "edit3";
            edit3.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(edit);
            dataGridView2.Columns.Add(edit2);
            dataGridView3.Columns.Add(edit3);

            dataGridView1.CellClick += cellClick;
            dataGridView2.CellClick += cellClick;
            dataGridView3.CellClick += cellClick;

            dataGridView1.DataSource = FemeiDatabase.Equipments;
            dataGridView2.DataSource= BarbatiDatabase.Equipments;
            dataGridView3.DataSource= CopiiDatabase.Equipments;
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //femei
            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
            {
                var equip = dataGridView1.CurrentRow.DataBoundItem as Equipment;

                var edit = new EditFormDB(equip.Id);
                edit.ShowDialog();
                MessageBox.Show("the edit was succesful");
                if (equip.Category.Equals("Men"))
                {
                    /*BarbatiPage.
                    var tabela = new BarbatiPage();
                    tabela.Show();*/
                }

            }


            /*//barbati
            if (e.ColumnIndex == dataGridView2.Columns["edit"].Index)
            {
               
            }


            //copii
            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
            {
                
            }*/
        }

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
