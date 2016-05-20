using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramInObjOriented.partie1_4_LA_POO_ET_LE_Csharp
{
    class Program_P1_4
    {
        static void Main(string[] args)
        {
            /*Animal animal = new Animal { NombreDePattes = 4 };
            animal.Respirer();
            Console.WriteLine();

            //Chien chien = new Chien { NombreDePattes = 4 };
            chien.Respirer();
            chien.Aboyer();*/
            List<Animal> animaux = new List<Animal>();
            Animal milou = new Chien("Milou");
            Animal dingo = new Chien("Dingo");
            Animal idefix = new Chien("Idéfix");
            Animal tom = new Chat("Tom");
            Animal felix = new Chat("Félix");

            animaux.Add(milou);
            animaux.Add(dingo);
            animaux.Add(idefix);
            animaux.Add(tom);
            animaux.Add(felix);

            foreach (Animal animal in animaux)
            {
                animal.Respirer();
            }





            List<Animal> animaux2 = new List<Animal>();
            Animal chien2 = new Chien();
            Animal tom2 = new Chat("Tom");
            Animal felix2 = new Chat("Félix");

            animaux.Add(chien2);
            animaux.Add(tom2);
            animaux.Add(felix2);

            foreach (Animal animal in animaux2)
            {
                animal.Respirer();
            }
            Console.WriteLine();
            Console.WriteLine("chien2.ToString()  :"+ chien2.ToString());
            Console.WriteLine("tom2.ToString()  :" + tom2.ToString());

            ChienMuet pauvreChien = new ChienMuet();
            pauvreChien.Aboyer();

            Chien chien = new Chien();
            chien.Manger();

            Thread.Sleep(100000);
        }
    }
    
}
