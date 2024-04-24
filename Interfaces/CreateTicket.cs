using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Tickets.Interfaces
{
    public partial class CreateTicket : Form
    {

        private readonly string connection = ConfigurationManager.ConnectionStrings["MSSQLLocalDB"].ConnectionString;

        public CreateTicket()
        {
            InitializeComponent();
            LoadEmployees();
            ticketDatePicker.Value = DateTime.Now;
            this.FormClosing += MainForm_FormClosing;

        }

        private void LoadEmployees()
        {
            string query = "SELECT Id, FirstName, LastName " +
                           "FROM Employees";

            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        employeeListDataGridView.Rows.Add(reader["Id"], reader["FirstName"], reader["LastName"]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los empleados: " + ex.Message);
                }
            }
        }

        private void SaveTicket()
        {
            DateTime date = DateTime.Now;
            DataGridViewRow selectedRow = employeeListDataGridView.SelectedRows[0];
            int idEmployee = int.Parse(selectedRow.Cells[0].Value.ToString());

            if (int.TryParse(idTicketTxtBox.Text, out int idTicket))
            {
                if (ExistId(idTicket))
                {
                    MessageBox.Show("Este numero de vale ya existe en la base de datos, ingresa uno diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Valor del numero de vale no compatible (Ingrese un valor numerico).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO Tickets (Id, Date, EmployeeId) VALUES (@Id, @Date, @EmployeeId)";

            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLLocalDB"].ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Id", idTicket);
                    sqlCommand.Parameters.AddWithValue("@Date", date);
                    sqlCommand.Parameters.AddWithValue("@EmployeeId", idEmployee);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }

            MessageBox.Show("El registro ha sido guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            idTicketTxtBox.Text = "";
        }

        private void registerEmployeeBtn_Click(object sender, EventArgs e)
        {
            RegisterEmployee registerEmployee = new RegisterEmployee();
            registerEmployee.Show();
            this.Hide();
        }

        private void saveTicketBtn_Click(object sender, EventArgs e)
        {
            SaveTicket();
        }

        private bool ExistId(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLLocalDB"].ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM Tickets WHERE Id = @Id";
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

        private void searchEmployeeTxtBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchEmployeeTxtBox.Text.ToLower();

            foreach (DataGridViewRow row in employeeListDataGridView.Rows)
            {
                if (!row.IsNewRow && !row.Cells.Cast<DataGridViewCell>().Any(c => c.IsInEditMode))
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                        {
                            row.Visible = true;
                            break; 
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            Index index = new Index("");
            index.Show();
            this.Hide();
        }
    }
}
