using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramInObjOriented
{
    class Program
    {
        static void Main111(string[] args)
        {
            MaBibliotheque.Bonjour bonjour = new MaBibliotheque.Bonjour();
            bonjour.DireBonjour();

          
   
            Client client = new Client("Nico", "12345");
            Console.WriteLine(client.MotDePasse);

            Console.WriteLine(Generateur.ObtenirIdentifiantUnique());

            /*string chaine = "12345".Crypte();
            Encodage.Crypte("12345");
            Thread.Sleep(10000);*/
        }
    }
}
