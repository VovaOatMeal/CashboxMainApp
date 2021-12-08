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
    public partial class TicketRegistration : Form
    {
        SqlConnection myConnection;

        string connectString = "Data Source = (local); Initial Catalog = cashbox;" +
                               "Integrated Security=true;";

        private int initPrice;
        private int finalPrice;
        private int chosenClass;

        public TicketRegistration()
        {
            InitializeComponent();
        }

        private void TicketRegistration_Load(object sender, EventArgs e)
        {
            TR_passengerTextBox.Text = Globals.CURRENT_PASSENGERID;
            TR_passageTextBox.Text = Globals.CURRENT_PASSAGE;
            TR_flightTitleTextBox.Text = Globals.CURRENT_FLIGHTTITLE;

            myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string query = "select Till from Cashboxes";
            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                TR_tillComboBox.Items.Add(reader[0].ToString());
            }

            reader.Close();

            query = "select Price from Flight_form where Passage = " + Globals.CURRENT_PASSAGE;
            command = new SqlCommand(query, myConnection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                initPrice = Convert.ToInt16(reader[0].ToString());
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

        private void TR_classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TR_classComboBox.SelectedItem.ToString() == "Эконом")
            {
                chosenClass = 0;

                TR_chairComboBox.Items.Clear();
                for (int i = 1; i <= 30; i++)
                {
                    TR_chairComboBox.Items.Add(i);
                }

                finalPrice = initPrice;
                TR_priceTextBox.Text = Convert.ToString(finalPrice);
            }

            else if (TR_classComboBox.SelectedItem.ToString() == "Бизнес")
            {
                chosenClass = 1;

                TR_chairComboBox.Items.Clear();
                for (int i = 31; i <= 80; i++)
                {
                    TR_chairComboBox.Items.Add(i);
                }

                finalPrice = (int) (initPrice * 1.3);
                TR_priceTextBox.Text = Convert.ToString(finalPrice);
            }

            else if (TR_classComboBox.SelectedItem.ToString() == "Первый")
            {
                chosenClass = 2;

                TR_chairComboBox.Items.Clear();
                for (int i = 81; i <= 150; i++)
                {
                    TR_chairComboBox.Items.Add(i);
                }

                finalPrice = (int) (initPrice * 1.6);
                TR_priceTextBox.Text = Convert.ToString(finalPrice);
            }
        }

        private void TR_submitButton_Click(object sender, EventArgs e)
        {
            Globals.REGISTERED_TICKET.PassengerID = Int32.Parse(Globals.CURRENT_PASSENGERID);
            Globals.REGISTERED_TICKET.Passage = Int32.Parse(Globals.CURRENT_PASSAGE);
            Globals.REGISTERED_TICKET.FlightTitle = Globals.CURRENT_FLIGHTTITLE;
            Globals.REGISTERED_TICKET.Till = Int32.Parse(TR_tillComboBox.SelectedItem.ToString());
            Globals.REGISTERED_TICKET.Class = chosenClass;
            Globals.REGISTERED_TICKET.Chair = Int32.Parse(TR_chairComboBox.SelectedItem.ToString());
            Globals.REGISTERED_TICKET.Price = finalPrice;
            Globals.REGISTERED_TICKET.Registrar = TR_registrarTextBox.Text;

            myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string query =
                "insert into Ticket_Form (Passenger, Passage, FlightTitle, Till, Class, Chair, Price, Registrar) " +
                "values (" + Globals.REGISTERED_TICKET.PassengerID + ", " +
                Globals.REGISTERED_TICKET.Passage + ", '" +
                Globals.REGISTERED_TICKET.FlightTitle + "', " +
                Globals.REGISTERED_TICKET.Till + ", " +
                Globals.REGISTERED_TICKET.Class + ", " +
                Globals.REGISTERED_TICKET.Chair + ", " +
                Globals.REGISTERED_TICKET.Price + ", '" +
                Globals.REGISTERED_TICKET.Registrar + "')";
            SqlCommand command = new SqlCommand(query, myConnection);

            int result = command.ExecuteNonQuery();
            myConnection.Close();

            //MessageBox.Show(result.ToString());

            this.Hide();
            var form2 = new TicketPrinting();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }
    }
}