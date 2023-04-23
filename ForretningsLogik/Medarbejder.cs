using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelPin___Eksamensprojekt.ForretningsLogik
{
    public class Medarbejder
    {
        public string Navn { get; set; }
        public int Pinkode { get; set; }

        public Medarbejder(string Navn, int Pinkode)
        {
            this.Navn = Navn;
            this.Pinkode = Pinkode;
        }

    }
}
