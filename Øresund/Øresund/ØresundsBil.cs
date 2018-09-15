using System;
using BilletOpg;

namespace Øresund
{
    public class ØresundsBil : Bil
    {
        public ØresundsBil(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
        {
        }

        public override decimal Pris()
        {
            if (Brobizz)
            {
                return 161;
            }
            
            return 410;
        }

        public override string Køretøj()
        {
            return "Øresund Bil";
        }
    }
}
