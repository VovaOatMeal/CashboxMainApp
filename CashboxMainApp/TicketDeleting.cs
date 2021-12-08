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
    public partial class TicketDeleting : Form
    {

        SqlConnection myConnection;
        string connectString = "Data Source = (local); Initial Catalog = cashbox;" +
                               "Integrated Security=true;";

        public TicketDeleting()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string query = "SELECT * FROM Ticket_form";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            da.Fill(dt);

            TD_dataGridView.DataSource = dt;
            
            myConnection.Close();

        }

        private void PS_searchButton_Click(object sender, EventArgs e)
        {
            string item = TD_textBox.Text;

            myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string query = "SELECT * FROM Ticket_form WHERE TicketId = '" + item + "'";
            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            da.Fill(dt);

            TD_dataGridView.Rows.Clear();
            TD_dataGridView.DataSource = dt;
            myConnection.Close();
            
        }

        private void PS_resetButton_Click(object sender, EventArgs e)
        {
            TD_dataGridView.Rows.Clear();
            TD_textBox.Clear();
            LoadData();
        }

        private void TD_deleteTicketButton_Click(object sender, EventArgs e)
        {
            
            if (TD_dataGridView.SelectedRows != null && TD_dataGridView.SelectedCells.Count == 9)
            {
                int selectedrowindex = TD_dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = TD_dataGridView.Rows[selectedrowindex];  

                string message = "Будет удален выбранный билет. Продолжить?";
                string caption = "Удаление билета";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(this, message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    myConnection = new SqlConnection(connectString);
                    myConnection.Open();

                    string query = "delete from Ticket_form WHERE TicketId = " + Convert.ToInt16(selectedRow.Cells["TicketId"].Value);
                    SqlCommand command = new SqlCommand(query, myConnection);
                    command.ExecuteNonQuery();

                    TD_dataGridView.DataSource = null;
                    myConnection.Close();
                    LoadData();
                }

                
                
            }
            else
            {
                MessageBox.Show("Выберите билет");
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
