using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    enum TypeRefroidissements
    {
        Air,
        Liquide
    }

    internal class Moteur
    {
        public string Marque { get; set; }
        public int Force { get; set; }
        public TypeRefroidissements TypeRefroidissement { get; set;}

        public Moteur()
        {
            Marque = "Yamaha";
            Force = 50;
            TypeRefroidissement = TypeRefroidissements.Air;
        }

        public Moteur(string marque, int force, TypeRefroidissements typeRefroidissement)
        {
            Marque = marque;
            Force = force;
            TypeRefroidissement = typeRefroidissement;
        }
    }
}
