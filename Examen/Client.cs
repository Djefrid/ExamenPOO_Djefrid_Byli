using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Client
    {
        public string Nom { get; set; }
        public int MontantArgent { get; set; }
        static Random Rand = new Random();

        public Client() 
        {
            Nom = Factory.FabriquerNom();
            MontantArgent = Rand.Next(5000,50000);
        }

        public override string ToString()
        {
            return $"nom : {Nom} montant {MontantArgent}";
        }
    }
}
