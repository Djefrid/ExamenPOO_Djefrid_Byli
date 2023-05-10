using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Roues
    {
        public string Marque { get; set; }
        public int Grandeur { get; set; }

        public Roues()
        {
            Marque = "injunia";
            Grandeur = 52;
        }

        public Roues(string marque, int grandeur)
        {
            Marque = marque;
            Grandeur = grandeur;
        }

        public override string ToString()
        {
            return $" Marque : {Marque} Grandeur {Grandeur}";
        }
    }
}
