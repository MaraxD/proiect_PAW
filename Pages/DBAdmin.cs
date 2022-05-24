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

            dataGridView1.ColumnCount = 4;


            AddColumn(0, "Description", "Description");
            AddColumn(1, "Price", "Price");
            AddColumn(2, "Color", "Color");
            AddColumn(3, "Category", "Category");

            var edit = new DataGridViewButtonColumn();
            edit.Text = "Edit";
            edit.HeaderText = " ";
            edit.Name = "edit";
            edit.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(edit);

            dataGridView1.CellClick += cellClick;

            
            foreach(var add in BarbatiDatabase.Equipments)
            {
                dbEquip.Add(add);
            }
            foreach (var add in FemeiDatabase.Equipments)
            {
                dbEquip.Add(add);
            }
            foreach (var add in CopiiDatabase.Equipments)
            {
                dbEquip.Add(add);
            }

            dataGridView1.DataSource = dbEquip;


        }
        
        public static List<Equipment> dbEquip = new List<Equipment>();

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index)
            {
                var equip = dataGridView1.CurrentRow.DataBoundItem as Equipment;

                var edit = new EditFormDB(equip.Id);
                edit.Show();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dbEquip;
                dataGridView1.Refresh();
            }


            
        }

        private void AddColumn(int index, string property, string header)
        {
            dataGridView1.Columns[index].HeaderText = header;
            dataGridView1.Columns[index].DataPropertyName = property;
            
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            var check = new VerificationEdit();
            check.Show();
            Hide();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dbEquip;
            dataGridView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var add = new AddFormDB();
            add.ShowDialog();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dbEquip;
            dataGridView1.Refresh();

        }
    }
}
