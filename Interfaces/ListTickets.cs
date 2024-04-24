using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Tickets.Interfaces
{
    public partial class ListTickets : Form
    {

        private readonly string connection = ConfigurationManager.ConnectionStrings["MSSQLLocalDB"].ConnectionString;

        public ListTickets()
        {
            InitializeComponent();
            DisplayTickets();
            this.FormClosing += MainForm_FormClosing;
        }

        private void DisplayTickets()
        {
            string query = "SELECT Tickets.Id, Tickets.Date, Tickets.EmployeeId, Employees.FirstName + Employees.Lastname AS EmployeeName " +
                           "FROM Tickets " +
                           "JOIN Employees ON Tickets.EmployeeId = Employees.Id";
            ;

            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        ticketsDataGridView.Rows.Add(reader["Id"], reader["EmployeeId"], reader["EmployeeName"], reader["Date"]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los vales: " + ex.Message);
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
            Index index = new Index("Hola");
            index.Show();
            this.Hide();
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = searchTxtBox.Text.ToLower();

            foreach (DataGridViewRow row in ticketsDataGridView.Rows)
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
    }
}
