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
    public partial class FlightSelection : Form
    {
        private int nextStep; // 0 - оформление билета, 1 - редактирование
        SqlConnection myConnection;

        string connectString = "Data Source = (local); Initial Catalog = cashbox;" +
                               "Integrated Security=true;";

        public FlightSelection(int nextStep)
        {
            InitializeComponent();
            this.nextStep = nextStep;
            Globals.CURRENT_PASSAGE = "-1";
            LoadData();
        }

        private void LoadData(string Name = "")
        {
            myConnection = new SqlConnection(connectString);
            myConnection.Open();

            SqlCommand command = new SqlCommand("PrintFlightsByName", myConnection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = FS_textBox.Text;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            da.Fill(dt);

            FS_dataGridView.DataSource = dt;

            myConnection.Close();
        }

        private void PS_searchButton_Click(object sender, EventArgs e)
        {
            string item = FS_textBox.Text;
            LoadData(item);
        }

        private void PS_resetButton_Click(object sender, EventArgs e)
        {
            FS_textBox.Clear();
            LoadData();
        }

        private void PS_nextButton_Click(object sender, EventArgs e)
        {
            if (FS_dataGridView.SelectedRows != null && FS_dataGridView.SelectedCells.Count == 8)
            {
                int selectedrowindex = FS_dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = FS_dataGridView.Rows[selectedrowindex];
                Globals.CURRENT_PASSAGE = Convert.ToString(selectedRow.Cells["Passage"].Value);

                selectedrowindex = FS_dataGridView.SelectedCells[0].RowIndex;
                selectedRow = FS_dataGridView.Rows[selectedrowindex];
                Globals.CURRENT_FLIGHTTITLE = Convert.ToString(selectedRow.Cells["Title"].Value);

                if (nextStep == 0)
                {
                    this.Hide();
                    var form2 = new TicketRegistration();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
                else if (nextStep == 1)
                {
                    this.Hide();
                    var form2 = new FlightEditing();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
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