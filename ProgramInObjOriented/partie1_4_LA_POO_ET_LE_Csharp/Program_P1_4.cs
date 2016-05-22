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
            // CASTING
            Chien medor = new Chien();
            Animal animalCasted = (Animal)medor;
            List<Animal> animaux3 = new List<Animal>();
            Chien chien3 = new Chien();
            Chat chat3 = new Chat();

            animaux.Add((Animal)chien3);
            animaux.Add((Animal)chat3);

            // Erreur
            /*foreach (Chien c in animaux)
            {
                c.Aboyer();
            }*/

            //Mieux

            foreach (Animal animal in animaux)
            {
                if (animal is Chien)
                {
                    Chien c = (Chien)animal;
                    c.Aboyer();
                }
                if (animal is Chat)
                {
                    Chat c = (Chat)animal;
                    c.Miauler();
                }
            }

            // DYNAMIC CASTING with as
            foreach (Animal animal in animaux)
            {
                Chien c1 = animal as Chien;
                if (c1 != null)
                {
                    c1.Aboyer();
                }
                Chat c2 = animal as Chat;
                if (c2 != null)
                {
                    c2.Miauler();
                }
            }

            // BOXING : Covertir type valeur en type reference
            int i = 5;
            object o = i; // boxing
            Console.WriteLine("object oGetType  : " + o.GetType());

            int j = 5;
            object Oo = j; // boxing
            Oo = 6;
            j = 10;
            Console.WriteLine("j = " + j);
            Console.WriteLine("Oo = " + Oo);
            // UNBOXING

            int h = 5;
            object ob = i; // boxing
            int g = (int)ob; // unboxing

            
            Thread.Sleep(100000);
        }
    }
    
}
