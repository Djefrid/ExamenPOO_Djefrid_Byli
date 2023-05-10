using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Concessionnaire
    {
        public string Nom { get; set; }
        public List<VehiculeMotorise> VehiculeMotorises { get; set; }
        public double MontantArgent { get; set; }

        public Concessionnaire()
        {
            Nom = "Honda";
            VehiculeMotorises = new List<VehiculeMotorise>();
            RemplirInventaire();
            MontantArgent = 10000;
        }

        public void AddVehicule(VehiculeMotorise vehicule)
        {
            VehiculeMotorises.Add(vehicule);
        }

        public void VendreVehicule(VehiculeMotorise vehicule)
        {

        }

        public string GetInventaire()
        {
            string infos = "";

            if (VehiculeMotorises != null)
            {
                for (int i = 0; i < VehiculeMotorises.Count; i++)
                {
                    infos += VehiculeMotorises[i] + "\n";
                }
            }
            return infos;
        }

        private void RemplirInventaire()
        {
            //
            VehiculeMotorises.Add(new MotoMarine("Spark", "BRP", 12000, new Moteur()));
            VehiculeMotorises.Add(new MotoMarine("Spark", "BRP", 14000, new Moteur()));

            VehiculeMotorises.Add(new MotoMarine("GP1800R", "Yamaha", 11000, new Moteur()));
            VehiculeMotorises.Add(new MotoMarine("GTX", "BRP", 15000, new Moteur("Rotax", 230, TypeRefroidissements.Air)));

            //VTT
            VehiculeMotorises.Add(new VTT("XP 1000", "POlaris", 32000, new Moteur()));
            VehiculeMotorises.Add(new VTT("Ride command", "POlaris", 15000, new Moteur("Evo", 570, TypeRefroidissements.Liquide)));
            VehiculeMotorises.Add(new VTT("Foreman 500", "Honda", 10000, new Moteur()));
        }

        public override string ToString()
        {
            string infos = $"nom Consessionaire : {Nom} montant {MontantArgent} \n\n";

            return infos;
        }



    }
}
