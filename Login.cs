using System;
using System.Windows.Forms;
using Tickets.Auth;
using Tickets.Interfaces;

namespace Tickets
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
        }

        private void LoginLogic()
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (AuthenticationManager.AuthenticateUser(username, password))
            {
                MessageBox.Show("Inicio de sesión exitoso");

                this.Hide();
                Index index = new Index(username);
                index.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Por favor, inténtalo de nuevo.");
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginLogic();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginLogic();
                loginButton.PerformClick();
            }
        }

        private void usernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginLogic();
                loginButton.PerformClick();
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginLogic();
                loginButton.PerformClick();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("¿Seguro que quieres salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

    }
}