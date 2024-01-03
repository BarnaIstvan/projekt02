using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    internal class Alkatreszek
    {
        public string Tipus { get; set; }
        public string Nev { get; set; }
        public string Parameter { get; set; }
        public int Ar { get; set; }
        

        public Alkatreszek(string tipus, string nev, string paramater, int ar)
        {
            Tipus = tipus;
            Nev = nev;
            Parameter = paramater;
            Ar = ar;
            
        }
    }
}
