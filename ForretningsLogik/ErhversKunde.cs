using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelPin___Eksamensprojekt.ForretningsLogik
{
    public class ErhvervsKunde : Kunde
    {
        public ErhvervsKunde(int KundeNr, string KundeNavn, int PinKode, int afdelingsNr) : base(KundeNr, KundeNavn, PinKode, afdelingsNr)
        {
        }
    }
}
