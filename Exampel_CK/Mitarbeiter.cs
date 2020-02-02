using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exampel_CK
{
    class Mitarbeiter
    {
        private string name;
        private double bruttogehalt;

        public Mitarbeiter(string pName, double pBruttoGehalt)
        {
            name = pName;
            bruttogehalt = pBruttoGehalt;
        }

        public void AlleMaDatenAusgeben()
        {
            Console.WriteLine(name + ", " +bruttogehalt+ " Euro");
        }

    }
}
