using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tickets.Interfaces
{
    public partial class RegisterEmployee : Form
    {
        public RegisterEmployee()
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
        }

        private void SaveEmployee()
        {
            int id;
            string firstName = firstNameTxtBox.Text.Trim();
            string lastName = lastNameTxtBox.Text.Trim();

            if (int.TryParse(idEmployeeTxtBox.Text, out id))
            {
                if (ExistEmployee(id))
                {
                    MessageBox.Show("Este numero de empleado ya existe en la base de datos, ingresa uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Valor del numero de empleado no compatible (Ingrese un valor numerico).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO Employees (Id, FirstName, LastName) VALUES (@Id, @FirstName, @LastName)";

            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLLocalDB"].ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    sqlCommand.Parameters.AddWithValue("@FirstName", firstName);
                    sqlCommand.Parameters.AddWithValue("@LastName", lastName);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }

            MessageBox.Show("El registro ha sido guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CreateTicket createTicket = new CreateTicket();
            createTicket.Show();
            this.Hide();
        }

        private void saveEmployeeBtn_Click(object sender, EventArgs e)
        {
            SaveEmployee();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            CreateTicket createTicket = new CreateTicket();
            createTicket.Show();
            this.Hide();
        }

        private bool ExistEmployee(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLLocalDB"].ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM Employees WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
