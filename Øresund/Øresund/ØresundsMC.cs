using System;
using System.Collections.Generic;
using System.Text;
using BilletOpg;

namespace Øresund
{
    public class ØresundsMC : MC
    {
        public ØresundsMC(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
        {
        }

        public override decimal Pris()
        {
            if (Brobizz)
            {
                return 73;
            }
            
            return 210;
        }

        public override string Køretøj()
        {
            return "Øresund MC";
        }
    }
}
