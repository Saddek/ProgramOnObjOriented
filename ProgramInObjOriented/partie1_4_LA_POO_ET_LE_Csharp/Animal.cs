using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramInObjOriented.partie1_4_LA_POO_ET_LE_Csharp
{
    public class Animal
    {
        public int NombreDePattes { get; set; }
        public int age;
        //private bool estVivant;
        protected bool estVivant;

        protected string prenom = "AnimalSansPrenom";
        public Animal()
        {
            Console.WriteLine("Je la classe Animal mon prenom est " + prenom);
            this.prenom = prenom;
        }
        public Animal(string prenomAnimal)
        {
            Console.WriteLine("Je la classe Animal mon prenom est " + prenomAnimal);
            this.prenom = prenomAnimal;
        }

        public void Respirer()
        {
            //Console.WriteLine("Je respire");
            Console.WriteLine("Je suis " + prenom + " et je respire");
        }

        public override string ToString()
        {
            return "Je suis un Animal et je m'appelle " + prenom;
        }

        public virtual void Manger()
        {
            Console.WriteLine("Mettre les aliments dans la bouche");
            Console.WriteLine("Mastiquer");
            Console.WriteLine("Avaler");
            Console.WriteLine("...");
        }
    }
}
