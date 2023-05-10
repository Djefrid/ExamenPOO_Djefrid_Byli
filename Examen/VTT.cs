using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class VTT : VehiculeMotorise
    {
        public Roues Roues { get; set; }

        public VTT(string nomVehicule, string marque, int prix, Moteur moteurs) : base(nomVehicule, marque, prix, moteurs)
        {
            Roues = new Roues();
        }

        public VTT(string nomVehicule, string marque, int prix, Moteur moteurs, Roues roues) : base(nomVehicule, marque, prix, moteurs)
        {
            Roues = roues;
        }

        public override string ToString()
        {
            string infos = $"info vehicule\n Nom : {NomVehicule} Marque : {Marque} prix : {Prix}\nInformation sur le moteur\n Marque : {Moteurs.Marque} ";
            infos += $"refroidissemnt : {Moteurs.TypeRefroidissement}\nInfos roue \n{Roues}\n";

            return infos;
        }

    }
}
