using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Tickets.Utilities;

namespace Tickets.Interfaces
{
    public partial class CreateReport : Form
    {

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MSSQLLocalDB"].ConnectionString;

        public CreateReport()
        {
            InitializeComponent();
            LoadEmployees();
            this.FormClosing += MainForm_FormClosing;
            optionsCB.SelectedItem = "Generar reporte historico";
        }

        private void LoadEmployees()
        {
            string query = "SELECT Id, FirstName, LastName " +
                           "FROM Employees";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        dgvEmployees.Rows.Add(reader["Id"], reader["FirstName"], reader["LastName"]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los empleados: " + ex.Message);
                }
            }
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchTxtBox.Text.ToLower();

            foreach (DataGridViewRow row in dgvEmployees.Rows)
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

        private void createReportBtn_Click(object sender, EventArgs e)
        {
            string query;

            if (dgvEmployees.Enabled && (dateTimePicker1.Enabled && dateTimePicker2.Enabled))
            {
                DataGridViewRow selectedRow = dgvEmployees.SelectedRows[0];
                int idEmployee = int.Parse(selectedRow.Cells[0].Value.ToString());
                DateTime initialDate = dateTimePicker1.Value.Date;
                DateTime finalDate = dateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1);


                query = "SELECT Tickets.Id, Tickets.Date, Tickets.EmployeeId, Employees.FirstName + Employees.Lastname AS EmployeeName " +
                         "FROM Tickets " +
                         "JOIN Employees ON Tickets.EmployeeId = Employees.Id " +
                         "WHERE ";

                if (idEmployee != 0)
                {
                    query += "Tickets.EmployeeId = @EmployeeId ";
                }

                if (initialDate != DateTime.MinValue && finalDate != DateTime.MinValue)
                {
                    if (idEmployee != 0)
                    {
                        query += "AND ";
                    }
                    query += "Tickets.Date BETWEEN @InitialDate AND @FinalDate";
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", idEmployee);
                        command.Parameters.AddWithValue("@InitialDate", initialDate);
                        command.Parameters.AddWithValue("@FinalDate", finalDate);

                        GeneratePDFReport(connection, command, "Reporte de acuerdo a fechas y empleado");
                    }
                }
            }
            else if (!dgvEmployees.Enabled && (dateTimePicker1.Enabled && dateTimePicker2.Enabled))
            {
                DateTime initialDate = dateTimePicker1.Value.Date;
                DateTime finalDate = dateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1);
                query = "SELECT Tickets.Id, Tickets.Date, Tickets.EmployeeId, Employees.FirstName + Employees.Lastname AS EmployeeName " +
                         "FROM Tickets " +
                         "JOIN Employees ON Tickets.EmployeeId = Employees.Id " +
                         "WHERE ";

                if (initialDate != DateTime.MinValue && finalDate != DateTime.MinValue)
                {
                    query += "Tickets.Date BETWEEN @InitialDate AND @FinalDate";
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InitialDate", initialDate);
                        command.Parameters.AddWithValue("@FinalDate", finalDate);

                        GeneratePDFReport(connection, command, "Reporte de acuerdo a fechas");
                    }
                }
            }
            else if (dgvEmployees.Enabled && (!dateTimePicker1.Enabled && !dateTimePicker2.Enabled))
            {
                DataGridViewRow selectedRow = dgvEmployees.SelectedRows[0];
                int idEmployee = int.Parse(selectedRow.Cells[0].Value.ToString());

                query = "SELECT Tickets.Id, Tickets.Date, Tickets.EmployeeId, Employees.FirstName + Employees.Lastname AS EmployeeName " +
                         "FROM Tickets " +
                         "JOIN Employees ON Tickets.EmployeeId = Employees.Id " +
                         "WHERE ";

                if (idEmployee != 0)
                {
                    query += "Tickets.EmployeeId = @EmployeeId ";
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", idEmployee);

                        GeneratePDFReport(connection, command, "Reporte de empleado");
                    }
                }
            }
            else
            {
                query = "SELECT Tickets.Id, Tickets.Date, Tickets.EmployeeId, Employees.FirstName + Employees.Lastname AS EmployeeName " +
                        "FROM Tickets " +
                        "JOIN Employees ON Tickets.EmployeeId = Employees.Id ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        GeneratePDFReport(connection, command, "Reporte historico");
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

        private int GetTicketsCount(SqlDataReader reader)
        {
            int count = 0;

            while (reader.Read())
            {
                count++;
            }

            return count;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Index index = new Index("");
            index.Show();
            this.Hide();
        }

        private void optionsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = optionsCB.SelectedItem.ToString();

            switch (option)
            {
                case "Generar reporte historico":
                    dateTimePicker1.Value = new DateTime(2000, 01, 01);
                    dateTimePicker2.Value = new DateTime(2000, 01, 01);
                    dgvEmployees.ClearSelection();

                    dgvEmployees.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    dateTimePicker2.Enabled = false;
                    break;
                case "Generar reporte de acuerdo a fechas seleccionadas":
                    dgvEmployees.ClearSelection();
                    dgvEmployees.Enabled = false;

                    dateTimePicker1.Enabled = true;
                    dateTimePicker2.Enabled = true;
                    dateTimePicker1.Value = DateTime.Today;
                    dateTimePicker2.Value = DateTime.Today;
                    break;
                case "Generar reporte de acuerdo a usuario y fechas seleccionadas":
                    dgvEmployees.Enabled = true;

                    dateTimePicker1.Enabled = true;
                    dateTimePicker2.Enabled = true;
                    dateTimePicker1.Value = DateTime.Today;
                    dateTimePicker2.Value = DateTime.Today;
                    break;
                case "Generar reporte de acuerdo a usuario seleccionado":
                    dateTimePicker1.Value = new DateTime(2000, 01, 01);
                    dateTimePicker2.Value = new DateTime(2000, 01, 01);

                    dgvEmployees.Enabled = true;

                    dateTimePicker1.Enabled = false;
                    dateTimePicker2.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void GeneratePDFReport(SqlConnection connection, SqlCommand command, string PDFTitle)
        {
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                int row = 0;

                string[,] data = new string[GetTicketsCount(reader), 4];

                reader.Close();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    data[row, 0] = reader["Id"].ToString();
                    data[row, 1] = reader["EmployeeId"].ToString();
                    data[row, 2] = reader["EmployeeName"].ToString();
                    data[row, 3] = reader["Date"].ToString();
                    row++;
                }
                reader.Close();
                PDFGenerator pDFGenerator = new PDFGenerator();
                pDFGenerator.GenerateReport(data, PDFTitle);

                MessageBox.Show("El reporte ha sido creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recuperar los registros: " + ex.Message);
            }
        }
    }
}