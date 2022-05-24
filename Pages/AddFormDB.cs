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
            List<string> categories = new List<string>() { "Woman", "Men", "Kids" };
            comboBox1.DataSource = categories;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AddFormIsValid())
            {
                var newEquip = new Equipment();
                newEquip.Id = Guid.NewGuid();
                newEquip.Description = descTXT.Text;
                newEquip.Price = Convert.ToDouble(priceTXT.Text);
                newEquip.Color = colorTXT.Text;
                if (comboBox1.SelectedItem.Equals("Woman"))
                {
                    newEquip.Category = Convert.ToString(comboBox1.SelectedItem);
                    FemeiDatabase.Equipments.Add(newEquip);
                    Hide();
                }
                else if (comboBox1.SelectedItem.Equals("Men"))
                {
                    newEquip.Category = Convert.ToString(comboBox1.SelectedItem);
                    BarbatiDatabase.Equipments.Add(newEquip);
                    Hide();
                }
                else if (comboBox1.SelectedItem.Equals("Kids"))
                {
                    newEquip.Category = Convert.ToString(comboBox1.SelectedItem);
                    CopiiDatabase.Equipments.Add(newEquip);
                    Hide();
                }

                DBAdmin.dbEquip.Add(newEquip);
                Hide();
            }
            else
            {
                MessageBox.Show("Not all the text boxes are filled in, try again");
            }


        }

        private bool AddFormIsValid()
        {
            if (string.IsNullOrEmpty(descTXT.Text))
                return false;
            if (string.IsNullOrEmpty(priceTXT.Text))
                return false;
            if (string.IsNullOrEmpty(colorTXT.Text))
                return false;
            return true;
        }

        private void descriptionTextBox_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descTXT.Text))
            {
                descTXT.Focus();
                errorProvider.SetError(descTXT, "You should at least add a description.");
            }
            else
            {
                errorProvider.SetError(descTXT, string.Empty);
            }
        }

        private void priceTextBox_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priceTXT.Text))
            {
                priceTXT.Focus();
                errorProvider.SetError(priceTXT, "You should at least add a price.");
            }
            else
            {
                errorProvider.SetError(priceTXT, string.Empty);
            }
        }

        private void colorTextBox_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(colorTXT.Text))
            {
                colorTXT.Focus();
                errorProvider.SetError(colorTXT, "You should at least add a color");
            }
            else
            {
                errorProvider.SetError(colorTXT, string.Empty);
            }
        }

        
    }
}
