using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramInObjOriented
{
    class MoreThenOneAsOutput
    {
        public class Program
        {
            static void Main(string[] args)
            {
                string nombre = "1234";
                Resultat resultat = TryParse(nombre);
                if (resultat.ConversionOk)
                    Console.WriteLine(resultat.Valeur);
                Thread.Sleep(10000);
            }

            public static Resultat TryParse(string chaine)
            {
                Resultat resultat = new Resultat();
                int valeur;
                resultat.ConversionOk = int.TryParse(chaine, out valeur);
                resultat.Valeur = valeur;
                return resultat;
            }

        }

        public class Resultat
        {
            public bool ConversionOk { get; set; }
            public int Valeur { get; set; }
        }
    }
}
