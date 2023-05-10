using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class VehiculeMotorise
    {
        public string NomVehicule { get; set; }
        public string Marque { get; set; }
        public int Prix { get; set; }
        public Moteur Moteurs { get; set; }

        public VehiculeMotorise(string nomVehicule, string marque, int prix, Moteur moteurs)
        {
            NomVehicule = nomVehicule;
            Marque = marque;
            Prix = prix;
            Moteurs = moteurs;
        }

        //public static bool operator >(Moteur moteurs1, Moteur moteurs2)
        //{
        //    return moteurs1.Force > moteurs2.Force;
        //}
        //public static bool operator <(Moteur moteurs1, Moteur moteurs2)
        //{
        //    return moteurs1.Force < moteurs2.Force;
        //}
    }
}
