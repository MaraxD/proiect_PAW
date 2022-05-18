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
    public partial class EditFormDB : Form
    {
        private readonly IEquipRepository _equiprepository;
        private readonly Guid _id;
        public EditFormDB(Guid id)
        {
            InitializeComponent();
            _equiprepository = new EquipRepository();

            var equip = _equiprepository.GetByIdB(id);
            descTXT.Text = equip.Description;
            priceTXT.Text = Convert.ToString(equip.Price);
            colorTXT.Text = equip.Color;

            _id = id;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            var editEquip = _equiprepository.GetByIdB(_id);
            editEquip.Description = descTXT.Text;
            editEquip.Price = Convert.ToDouble(priceTXT.Text);
            editEquip.Color = colorTXT.Text;
            Hide();


        }
    }
}
