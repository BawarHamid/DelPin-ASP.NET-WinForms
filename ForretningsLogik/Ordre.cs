using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelPin___Eksamensprojekt.ForretningsLogik
{
    public class Ordre
    {
        public int ordreNr { get; set; }
        public int kundeNr { get; set; }

        public Ordre(int kundeNr)
        {
            this.kundeNr = kundeNr;
        }

        public Ordre(int ordreNr, int kundeNr)
        {
            this.ordreNr = ordreNr;
            this.kundeNr = kundeNr;
        }
    }
}
