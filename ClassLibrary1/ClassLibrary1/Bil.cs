using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Bil : Køretøj
    {
        public string Nummerplade;
        public DateTime Dato;

        public int Pris()
        {
            return 240;
        }

        public string KøretøjType()
        {
            return "Bil";
        }
    }
}
