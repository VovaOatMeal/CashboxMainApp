using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashboxMainApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void deleteTicketButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new TicketDeleting();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void addTicketButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new PassengerSelection();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void printLastTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new TicketPrinting("Оформленный билет");
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void deleteFlightButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FlightDeleting();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void editFlightButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FlightSelection(1);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void addPassengerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new PassengerAdding();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}