using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exampel_CK
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mitarbeiter> mitarbeiter_list = new List<Mitarbeiter>();
            mitarbeiter_list.Add(new Mitarbeiter("Hans", 1500.89));
            mitarbeiter_list.Add(new Mitarbeiter("Max", 750.55));
            mitarbeiter_list.Add(new Mitarbeiter("Doro", 450.00));
            Mitarbeiter_Ausgeben(mitarbeiter_list);
            Console.ReadLine();
        }

        private static void Mitarbeiter_Ausgeben(List<Mitarbeiter> list)
        {
            foreach(Mitarbeiter m in list)
            {
                m.AlleMaDatenAusgeben();
            }
        }
    }
}
