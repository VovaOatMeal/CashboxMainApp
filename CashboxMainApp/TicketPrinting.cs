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
using Word = Microsoft.Office.Interop.Word;


namespace CashboxMainApp
{
    public partial class TicketPrinting : Form
    {
        SqlConnection myConnection;

        string connectString = "Data Source = (local); Initial Catalog = cashbox;" +
                               "Integrated Security=true;";

        public TicketPrinting(string Text = "Оформлено!")
        {
            InitializeComponent();
            labelDone.Text = Text;
        }

        private void PrintTicket_Load(object sender, EventArgs e)
        {
            myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string query = "select * from Ticket_form " +
                           "where TicketId = (SELECT IDENT_CURRENT('Ticket_form'));";
            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            da.Fill(dt);

            PT_dataGridView.DataSource = dt;
            myConnection.Close();
        }

        private void PT_printButton_Click(object sender, EventArgs e)
        {
            if (PT_dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Последний оформленный билет отсутствует. Сначала оформите билет!");
                return;
            }

            string PassengerName = "";
            string FlightDate = "";
            string FlightArrival = "";
            string AirlinerName= "";

            myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string query = "select * from PrintLastPassengerInfo_View";
            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                PassengerName = reader[0].ToString();
            }

            reader.Close();

            query = "select * from PrintFlightDates_View";
            command = new SqlCommand(query, myConnection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                FlightDate = reader.GetValue(0).ToString();
                FlightArrival = reader.GetValue(1).ToString();
            }

            reader.Close();

            query = "select * from PrintAirlinerNameOfLastTicket_View";
            command = new SqlCommand(query, myConnection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                AirlinerName = reader.GetValue(0).ToString();
            }

            reader.Close();
            myConnection.Close();

            Word.Application app = new Word.Application();

            Word.Document doc = null;

            doc = app.Documents.Open(@"D:\Study\Data Storage Technology\3 курс 1 сем\РГР\Приложение\PrintedTicket.rtf");
            doc.Activate();

            Word.Range wRange;
            Word.Bookmarks wBookmarks = doc.Bookmarks;
            Word.Bookmark mark;

            mark = wBookmarks["ticketID"];
            wRange = mark.Range;
            wRange.Text = PT_dataGridView.CurrentRow.Cells[4].Value.ToString();

            mark = wBookmarks["registrationDate"];
            wRange = mark.Range;
            wRange.Text = DateTime.Now.ToString("G");

            mark = wBookmarks["passengerName"];
            wRange = mark.Range;
            wRange.Text = PassengerName;

            mark = wBookmarks["flightTitle"];
            wRange = mark.Range;
            wRange.Text = PT_dataGridView.CurrentRow.Cells[2].Value.ToString();
            
            mark = wBookmarks["passage"];
            wRange = mark.Range;
            wRange.Text = PT_dataGridView.CurrentRow.Cells[1].Value.ToString();

            mark = wBookmarks["departure"];
            wRange = mark.Range;
            wRange.Text = FlightDate;

            mark = wBookmarks["arrival"];
            wRange = mark.Range;
            wRange.Text = FlightArrival; 
            
            mark = wBookmarks["airlinerName"];
            wRange = mark.Range;
            wRange.Text = AirlinerName;

            mark = wBookmarks["class"];
            wRange = mark.Range;
            int currentClass = (int) PT_dataGridView.CurrentRow.Cells[8].Value;
            if (currentClass == 0)
            {
                wRange.Text = "Эконом";
            }

            else if (currentClass == 1)
            {
                wRange.Text = "Бизнес";
            }

            else if (currentClass == 2)
            {
                wRange.Text = "Первый";
            }

            mark = wBookmarks["chair"];
            wRange = mark.Range;
            wRange.Text = PT_dataGridView.CurrentRow.Cells[5].Value.ToString();

            mark = wBookmarks["price"];
            wRange = mark.Range;
            wRange.Text = PT_dataGridView.CurrentRow.Cells[6].Value.ToString();

            mark = wBookmarks["till"];
            wRange = mark.Range;
            wRange.Text = PT_dataGridView.CurrentRow.Cells[3].Value.ToString();

            mark = wBookmarks["registrar"];
            wRange = mark.Range;
            wRange.Text = PT_dataGridView.CurrentRow.Cells[7].Value.ToString();

            app.Visible = true;
        }

        private void PT_goHomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new MainForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}