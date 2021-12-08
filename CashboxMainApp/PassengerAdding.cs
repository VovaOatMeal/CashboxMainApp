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
    public partial class PassengerAdding : Form
    {
        SqlConnection myConnection;

        string connectString = "Data Source = (local); Initial Catalog = cashbox;" +
                               "Integrated Security=true;";

        string sqlPassportDateFormat = "yyyy-MM-dd";

        public PassengerAdding()
        {
            InitializeComponent();
        }

        private void FlightEditing_Load(object sender, EventArgs e)
        {
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
                "insert into Passenger_form (First_name, Second_name, Last_name, Phone, Email, Passport, PassportDate, Region)" +
                " values ('" + PA_firstNameTextBox.Text +
                "', '" + PA_secondNameTextBox.Text +
                "', '" + PA_lastNameTextBox.Text +
                "', " + PA_phoneTextBox.Text +
                ", '" + PA_emailTextBox.Text +
                "', '" + PA_passportTextBox.Text +
                "', '" + PA_passportDateTimePicker.Value.ToString(sqlPassportDateFormat) +
                "', '" + PA_regionTextBox.Text + "')";
            SqlCommand command = new SqlCommand(query, myConnection);

            int result = command.ExecuteNonQuery();
            myConnection.Close();

            MessageBox.Show(this, "Готово!");

            this.Hide();
            var form2 = new MainForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

    }
}