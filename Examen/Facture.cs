using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Facture
    {
        public Client Client { get; set; }
        public string Date { get; set; }
        public VehiculeMotorise Vehicule { get; set; }
        public double TPS { get; set; }
        public double TVQ { get; set; }

        public Facture(string date, Client client, VehiculeMotorise vehicule)
        {
            Date = date;
            Client = client;
            Vehicule = vehicule;
            TPS = vehicule.Prix * 0.05;
            TVQ = vehicule.Prix * 0.1;
        }

        public override string ToString()
        {
            return $"**********INFORMATION FACTURE**********\n\n Date : {Date} \nCLIENT INFOS {Client} \n INFOS VEICULE \n{Vehicule}";
        }
    }
}
