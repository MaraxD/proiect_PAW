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
            _equiprepository = new EquipRepository();
            InitializeComponent();

            //daca a fost selectat ceva din tabela de femei pentru editare
            if (_equiprepository.GetByIdF(id)!=null)
            {
                var equip = _equiprepository.GetByIdF(id);
                descTXT.Text = equip.Description;
                priceTXT.Text = Convert.ToString(equip.Price);
                colorTXT.Text = equip.Color;

                _id = id;
            }
            else if (_equiprepository.GetByIdB(id) != null)
            {
                var equip = _equiprepository.GetByIdB(id);
                descTXT.Text = equip.Description;
                priceTXT.Text = Convert.ToString(equip.Price);
                colorTXT.Text = equip.Color;

                _id = id;
            }
            else if (_equiprepository.GetByIdC(id) != null)
            {
                var equip = _equiprepository.GetByIdC(id);
                descTXT.Text = equip.Description;
                priceTXT.Text = Convert.ToString(equip.Price);
                colorTXT.Text = equip.Color;

                _id = id;
            }

        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (_equiprepository.GetByIdF(_id) != null)
            {
                var editEquip = _equiprepository.GetByIdF(_id);
                editEquip.Description = descTXT.Text;
                editEquip.Price = Convert.ToDouble(priceTXT.Text);
                editEquip.Color = colorTXT.Text;
                MessageBox.Show("the edit was succsesful");
                Hide();


            }else if (_equiprepository.GetByIdB(_id) != null)
            {
                var editEquip = _equiprepository.GetByIdB(_id);
                editEquip.Description = descTXT.Text;
                editEquip.Price = Convert.ToDouble(priceTXT.Text);
                editEquip.Color = colorTXT.Text;
                MessageBox.Show("the edit was succsesful");
                Hide();

            }else if (_equiprepository.GetByIdC(_id) != null)
            {
                var editEquip = _equiprepository.GetByIdC(_id);
                editEquip.Description = descTXT.Text;
                editEquip.Price = Convert.ToDouble(priceTXT.Text);
                editEquip.Color = colorTXT.Text;
                MessageBox.Show("the edit was succsesful");
                Hide();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
