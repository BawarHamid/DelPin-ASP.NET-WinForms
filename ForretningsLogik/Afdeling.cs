using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelPin___Eksamensprojekt.ForretningsLogik
{
    public class Afdeling
    {
        public int afdelingsNr { get; set; }

        public string afdelingsNavn { get; set; }

        public int postNr { get; set; }

        public Afdeling(string afdelingsNavn, int postNr)
        {
            this.afdelingsNavn = afdelingsNavn;
            this.postNr = postNr;
        }

        public Afdeling(int afdelingsNr, string afdelingsNavn, int postNr)
        {
            this.afdelingsNr = afdelingsNr;
            this.afdelingsNavn = afdelingsNavn;
            this.postNr = postNr;
        }

        public override string ToString()
        {
            return this.afdelingsNavn;
        }



    }
}
