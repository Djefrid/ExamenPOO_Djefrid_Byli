using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    enum TypeMotoMarines
    {
        jet_ski,
        Sea_Doo,
    }

    internal class MotoMarine : VehiculeMotorise
    {
        public TypeMotoMarines TypeMotoMarine { get; set; }

        public MotoMarine(string nomVehicule, string marque, int prix, Moteur moteurs, TypeMotoMarines TypeMotoMarine = TypeMotoMarines.Sea_Doo) : base(nomVehicule, marque, prix, moteurs) 
        {
        }

        public override string ToString()
        {
            string infos = $"info vehicule\n Nom : {NomVehicule} Marque : {Marque} prix : {Prix}$\nInformation sur le moteur\n Marque : {Moteurs.Marque} ";
            infos += $"refroidissemnt : {Moteurs.TypeRefroidissement} \n";

            return infos;
        }
    }
}
