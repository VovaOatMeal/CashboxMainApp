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
    public partial class PassengerSelection : Form
    {

        SqlConnection myConnection;
        string connectString = "Data Source = (local); Initial Catalog = cashbox;" +
                               "Integrated Security=true;";

        public PassengerSelection()
        {
            InitializeComponent();
            Globals.CURRENT_PASSENGERID = "-1";
            LoadData();
        }

        private void LoadData()
        {
            myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string query = "SELECT * FROM PassengerMainInfo_View";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }
            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                PS_dataGridView.Rows.Add(s);
        }

        private void PS_searchButton_Click(object sender, EventArgs e)
        {
            string item = PS_textBox.Text;

            myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string query = "SELECT * FROM PassengerMainInfo_View WHERE [Passenger ID] = '" + item + "'";
            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }
            reader.Close();
            myConnection.Close();

            PS_dataGridView.Rows.Clear();

            foreach (string[] s in data)
                PS_dataGridView.Rows.Add(s);
        }

        private void PS_resetButton_Click(object sender, EventArgs e)
        {
            PS_dataGridView.Rows.Clear();
            PS_textBox.Clear();
            LoadData();
        }

        private void PS_nextButton_Click(object sender, EventArgs e)
        {
            
            if (PS_dataGridView.SelectedRows != null && PS_dataGridView.SelectedCells.Count == 4)
            {
                int selectedrowindex = PS_dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = PS_dataGridView.Rows[selectedrowindex];  
                Globals.CURRENT_PASSENGERID = Convert.ToString(selectedRow.Cells["PassengerID"].Value);  

                this.Hide();
                var form2 = new FlightSelection(0);
                form2.Closed += (s, args) => this.Close(); 
                form2.Show();
            }
            else
            {
                MessageBox.Show("Выберите пассажира");
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
