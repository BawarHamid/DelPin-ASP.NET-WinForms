using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelPin___Eksamensprojekt.ForretningsLogik
{
    public class Maskine
    {
        public int ressourceNr { get; set; }
        public string maskineNavn { get; set; }
        public double pris { get; set; }
        public int afdelingsNr { get; set; }

        public Maskine(string maskineNavn, double pris, int afdelingsNr)
        {
            this.maskineNavn = maskineNavn;
            this.pris = pris;
            this.afdelingsNr = afdelingsNr;
        }

        public Maskine(int ressourceNr, string maskineNavn, double pris, int afdelingsNr)
        {
            this.ressourceNr = ressourceNr;
            this.maskineNavn = maskineNavn;
            this.pris = pris;
            this.afdelingsNr = afdelingsNr;
        }

        public override string ToString()
        {
            return this.maskineNavn;
        } 
    }
}
