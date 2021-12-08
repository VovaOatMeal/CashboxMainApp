using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashboxMainApp
{
    public static class Globals
    {
        public static String CURRENT_PASSENGERID = "-1";
        public static String CURRENT_PASSAGE = "-1";
        public static String CURRENT_FLIGHTTITLE = "-1";
        public static RegisteredTicket REGISTERED_TICKET = new RegisteredTicket();
    }

    public class RegisteredTicket
    {
        public int PassengerID;
        public int Passage;
        public String FlightTitle;
        public int Till;
        public int Class;
        public int Chair;
        public int Price;
        public String Registrar;
    }
}
