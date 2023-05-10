using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MotoMarine MaMotoMarine = new MotoMarine("spark", "tcl", 12000, new Moteur());

            Console.WriteLine(MaMotoMarine);

            Console.WriteLine("-----");
            VTT MavTT = new VTT("Ride command", "leo",11000,new Moteur());

            Console.WriteLine(MavTT);
            //etape 2

            Concessionnaire concessionnaire = new Concessionnaire();
            Console.WriteLine("------");
            Console.WriteLine(concessionnaire.GetInventaire());
            
            //Console.WriteLine(concessionnaire);

            Simulateur simulateur = new Simulateur();

            

            


            simulateur.Simuler();

        }
    }
}
