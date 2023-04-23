using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelPin___Eksamensprojekt.ForretningsLogik
{
    public class Kunde
    {
        public int kundeNr { get; set; }
        public string kundeNavn { get; set; }
        public int pinKode { get; set; }
        public int afdelingsNr { get; set; }

        public Kunde(string kundeNavn, int pinKode, int afdelingsNr)
        {
            this.kundeNr = kundeNr;
            this.kundeNavn = kundeNavn;
            this.pinKode = pinKode;
            this.afdelingsNr = afdelingsNr;
        }

        public Kunde(int kundeNr, string kundeNavn, int pinKode, int afdelingsNr)
        {
            this.kundeNr = kundeNr;
            this.kundeNavn = kundeNavn;
            this.pinKode = pinKode;
            this.afdelingsNr = afdelingsNr;
        }

        public override string ToString()
        {
            return this.kundeNavn;
        }

    }
}
