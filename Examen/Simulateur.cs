using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Simulateur
    {
        public Concessionnaire MonConcessionnaire { get; set; }
        public List<Client> Clients { get; set; }
        public List<Facture> Factures { get; set; }
        static Random Rand = new Random();

        public Simulateur()
        {
            Clients = new List<Client> ();
            Factures = new List<Facture> ();
            MonConcessionnaire = new Concessionnaire();
        }

        public void Simuler()
        {
            Console.WriteLine("\n\nDebut simulation\n\n");

            foreach (Client item in genererListeClient())
            {
                Console.WriteLine(item);
            }

            //for (int i = 0; i < Clients.Count; i++)
            //{

            //}

            simulerTransaction(genererListeClient());
            for (int i = 0; i < Factures.Count; i++) 
            {
                Facture fact = Factures[i];
                Console.WriteLine(fact);
            }
            Console.WriteLine(MonConcessionnaire);
        }

        public void simulerTransaction(List<Client> clients)
        {
            for (int i = 0; i< clients.Count;i++)
            {
                if (clients[i].MontantArgent >= MonConcessionnaire.VehiculeMotorises[i].Prix)
                {
                    Factures.Add(new Facture($"{Rand.Next(2022, 2023)}-{Rand.Next(1, 12)}-{Rand.Next(1,31)} {Rand.Next(8, 18)}:{Rand.Next(01, 59)}:{Rand.Next(01, 59)}  ", clients[i], MonConcessionnaire.VehiculeMotorises[i]));
                    MonConcessionnaire.MontantArgent += MonConcessionnaire.VehiculeMotorises[i].Prix;
                }
                else
                {
                    Console.WriteLine($"\n\nle client na pas les moyens\n Client infos \n {clients[i]}\n\n");
                }
            }
        }

        public List<Client> genererListeClient() 
        {
            for(int i = 0;i < Rand.Next(2,5);i++)
            {
                Clients.Add(new Client());
            }

            return Clients;
        }

        public override string ToString()
        {
            return $"{MonConcessionnaire}";
        }

    }
}
