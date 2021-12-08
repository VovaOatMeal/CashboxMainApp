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
    public partial class FlightEditing : Form
    {
        SqlConnection myConnection;

        string connectString = "Data Source = (local); Initial Catalog = cashbox;" +
                               "Integrated Security=true;";

        string sqlFormat = "yyyy-MM-dd HH:mm:ss.000";

        public FlightEditing()
        {
            InitializeComponent();
        }

        private void FlightEditing_Load(object sender, EventArgs e)
        {
            myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string query = "select Airliner from Airliner_form";
            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                FE_airlinerComboBox.Items.Add(reader[0].ToString());
            }

            reader.Close();

            query = "select * from Flight_form where Passage = " + Globals.CURRENT_PASSAGE;
            command = new SqlCommand(query, myConnection);
            reader = command.ExecuteReader();

            FE_departDateTimePicker.Format = DateTimePickerFormat.Custom;
            FE_departDateTimePicker.CustomFormat = sqlFormat;
            
            FE_arrivalDateTimePicker.Format = DateTimePickerFormat.Custom;
            FE_arrivalDateTimePicker.CustomFormat = sqlFormat;
            while (reader.Read())
            {
                FE_titleTextBox.Text = reader.GetValue(1).ToString();
                FE_departDateTimePicker.Value = (DateTime) reader.GetValue(2);
                FE_arrivalDateTimePicker.Value = (DateTime) reader.GetValue(3);
                FE_seatsComboBox.SelectedIndex = reader.GetValue(4).ToString() == "True" ? 0 : 1;
                FE_placesTextBox.ReadOnly = FE_seatsComboBox.SelectedIndex != 0;
                FE_placesTextBox.Text = reader.GetValue(5).ToString();
                FE_airlinerComboBox.SelectedItem = reader.GetValue(6).ToString();
                FE_priceTextBox.Text = reader.GetValue(7).ToString();
            }

            reader.Close();
            myConnection.Close();
        }

        private void TR_goHomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new MainForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void TR_submitButton_Click(object sender, EventArgs e)
        {

            myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string query =
                "update Flight_form set " +
                "Title = '" + FE_titleTextBox.Text +
                "', Date = '" + FE_departDateTimePicker.Value.ToString(sqlFormat) +
                "', Arrival = '" + FE_arrivalDateTimePicker.Value.ToString(sqlFormat) +
                "', Seats = " + (FE_seatsComboBox.SelectedItem.ToString() == "Есть" ? 1 : 0) +
                (String.IsNullOrEmpty(FE_placesTextBox.Text) ? "" : ("Places = '" + FE_placesTextBox.Text.ToString()) + "'") +
                ", Airliner = " + FE_airlinerComboBox.SelectedItem.ToString() +
                ", Price = " + FE_priceTextBox.Text +
                " where Passage = " + Globals.CURRENT_PASSAGE;
            SqlCommand command = new SqlCommand(query, myConnection);

            int result = command.ExecuteNonQuery();
            myConnection.Close();

            MessageBox.Show(this, "Готово!");

            this.Hide();
            var form2 = new MainForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void FE_seatsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FE_placesTextBox.ReadOnly = FE_seatsComboBox.SelectedIndex != 0;
        }
    }
}