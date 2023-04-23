using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelPin___Eksamensprojekt.ForretningsLogik
{
    public class Booking
    {
        public int bookingsNr { get; set; }

        public DateTime startsDato { get; set; }

        public DateTime slutDato { get; set; }

        public int ressourceNr { get; set; }

        public int ordreNr { get; set; }

        public Booking(DateTime startsDato, DateTime slutDato, int ressourceNr, int ordreNr)
        {
            this.startsDato = startsDato;
            this.slutDato = slutDato;
            this.ressourceNr = ressourceNr;
            this.ordreNr = ordreNr;
        }

        public Booking(int bookingsNr, DateTime startsDato, DateTime slutDato, int ressourceNr, int ordreNr)
        {
            this.bookingsNr = bookingsNr;
            this.startsDato = startsDato;
            this.slutDato = slutDato;
            this.ressourceNr = ressourceNr;
            this.ordreNr = ordreNr;
        }
    }
}
