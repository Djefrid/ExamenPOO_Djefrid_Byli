using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    static class Factory
    {
        static List<string> ListNom = new List<string>();
        static List<string> ListPrenom = new List<string>();
        static Random Rand = new Random();


        static Factory()
        {
            RemplirListe();
        }

        static public void RemplirListe()
        {
            AjouterNom();
            AjouterPrenom();
        }

        static void AjouterNom()
        {
            string[] listeNom = { "luca","trembley","emanuel","tiot" };



            foreach (string item in listeNom)
            {
                    ListNom.Add(item);
                }
            
        }

        static void AjouterPrenom()
        {
            string[] listePrenom = { "toto", "ista", "lulu", "garfilde" };

            foreach (string item in listePrenom)
            {
                ListPrenom.Add(item);
            }

        }

        static public string FabriquerNom()
        {
            int rnd1 = Rand.Next(1, ListNom.Count);
            int rnd2 = Rand.Next(1, ListPrenom.Count);
            string nom = $"{ListNom[rnd1]} {ListPrenom[rnd2]}";

            return nom;
        }
    }
}
