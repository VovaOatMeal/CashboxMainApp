using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashboxMainApp
{
    public partial class FlightDeleting : Form
    {
        SqlConnection myConnection;

        string connectString = "Data Source = (local); Initial Catalog = cashbox;" +
                               "Integrated Security=true;";

        public FlightDeleting()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string Name = "")
        {
            myConnection = new SqlConnection(connectString);
            myConnection.Open();

            SqlCommand command = new SqlCommand("PrintFlightsByName", myConnection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = FD_textBox.Text;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            da.Fill(dt);

            FD_dataGridView.DataSource = dt;

            myConnection.Close();
        }

        private void PS_searchButton_Click(object sender, EventArgs e)
        {
            string item = FD_textBox.Text;
            LoadData(item);
        }

        private void PS_resetButton_Click(object sender, EventArgs e)
        {
            FD_dataGridView.Rows.Clear();
            FD_textBox.Clear();
            LoadData();
        }

        private void TD_deleteTicketButton_Click(object sender, EventArgs e)
        {
            if (FD_dataGridView.SelectedRows != null && FD_dataGridView.SelectedCells.Count == 8)
            {
                int selectedrowindex = FD_dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = FD_dataGridView.Rows[selectedrowindex];

                string message = "Будет удален выбранный рейс, а также все купленные на него билеты. Продолжить?";
                string caption = "Удаление рейса";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(this, message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    myConnection = new SqlConnection(connectString);
                    myConnection.Open();

                    string query = "delete from Flight_form WHERE Passage = " +
                                   Convert.ToInt16(selectedRow.Cells["Passage"].Value);
                    SqlCommand command = new SqlCommand(query, myConnection);
                    command.ExecuteNonQuery();

                    FD_dataGridView.DataSource = null;
                    myConnection.Close();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите рейс");
            }
        }

        private void PS_goHomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new MainForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}