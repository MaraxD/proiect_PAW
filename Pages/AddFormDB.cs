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

namespace seminar9.Pages
{
    public partial class AddFormDB : Form
    {
        public AddFormDB()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newEquip = new Equipment();
            newEquip.Id = Guid.NewGuid();
            newEquip.Description = descTXT.Text;
            newEquip.Price = Convert.ToDouble(priceTXT.Text);
            newEquip.Color = colorTXT.Text;
            newEquip.Category = categTXT.Text;

            if (newEquip.Category.Equals("Woman"))
            {
                FemeiDatabase.Equipments.Add(newEquip);
                Hide();
            }
            else if (newEquip.Category.Equals("Men"))
            {
                BarbatiDatabase.Equipments.Add(newEquip);
                Hide();
            }
            else if (newEquip.Category.Equals("Kids"))
            {
                CopiiDatabase.Equipments.Add(newEquip);
                Hide();
            }
            DBAdmin.dbEquip.Add(newEquip);
            Hide();
            
        }
    }
}
