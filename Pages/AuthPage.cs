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
    public partial class AuthPage : Form
    {
        public AuthPage()
        {
            InitializeComponent();
            InitializeMyControl();
        }

        private void InitializeMyControl()
        {
            // Set to no text.
            passwordTextBox.Text = "";
            // The password character is an asterisk.
            passwordTextBox.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            passwordTextBox.MaxLength = 14;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "MaraOlaru" && passwordTextBox.Text == "1234")
            {
                var enter = new AdminPage();
                enter.Show();
                Hide();
            }
            else if(usernameTextBox.Text != "MaraOlaru" && passwordTextBox.Text != "1234")
            {
                MessageBox.Show("Parola sau username ul sunt gresite");
                usernameTextBox.Text = null;
                passwordTextBox.Text = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var back = new Main();
            back.Show();
            Hide();
        }

        private void username_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                usernameTextBox.Focus();
                errorProvider1.SetError(usernameTextBox, "Trebuie introdus un nume!");
            }
            else
            {
                errorProvider1.SetError(usernameTextBox, string.Empty);
            }
        }

        private void password_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                passwordTextBox.Focus();
                errorProvider1.SetError(passwordTextBox, "Trebuie introdus un nume!");
            }
            else
            {
                errorProvider1.SetError(passwordTextBox, string.Empty);
            }
        }
    }
}
