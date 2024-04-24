using System;
using System.Windows.Forms;
using Tickets.Utilities;

namespace Tickets.Interfaces
{
    public partial class Index : Form
    {
        public Index(String username)
        {
            InitializeComponent();
            LoadUsername(username);
            this.FormClosing += MainForm_FormClosing;
        }

        private void LoadUsername(String username)
        {
            greetingsLbl.Text = "Hola " + username;
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

        private void button1_Click(object sender, EventArgs e)
        {
            ListTickets listTickets = new ListTickets();
            listTickets.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateTicket createTicket = new CreateTicket();
            createTicket.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateReport createReport = new CreateReport();
            createReport.Show();
            this.Hide();

        }
    }
}
