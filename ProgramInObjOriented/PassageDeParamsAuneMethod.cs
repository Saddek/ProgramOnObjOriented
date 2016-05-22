using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramInObjOriented
{
    class PassageDeParamsAuneMethod
    {
        static void Main121212121(string[] args)
        {
            /*int age = 30;
            Doubler(ref age);
            Console.WriteLine(age);*/

            string chaine = "1234";
            int nombre;
            if (int.TryParse(chaine, out nombre))
                Console.WriteLine(nombre);
            else
                Console.WriteLine("Conversion impossible");

            int age = 30;
            int ageDouble;
            Doubler(age, out ageDouble);
            Thread.Sleep(10000);
        }

        public static void Doubler(ref int valeur)
        {
            valeur = valeur * 2;
        }
        public static void Doubler(int age, out int resultat)
        {
            resultat = age * 2;
        }
    }
}
