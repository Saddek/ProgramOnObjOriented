using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramInObjOriented.partie1_4_LA_POO_ET_LE_Csharp
{
    public class Chien : Animal
    {
        public Chien() : base()
        {
            Console.WriteLine("Je la classe Chien qui herite de la classe Animal");
            //this.prenomAnimal = prenomDuChien;
        }
        public Chien(string prenomDuChien) : base (prenomDuChien)
        {
            Console.WriteLine("Je la classe Chien qui herite de la classe Animal");
            //this.prenomAnimal = prenomDuChien;
        }
        public virtual void Aboyer()
        {
            Console.WriteLine("Wouaf !");
        }

        public void Vieillir()
        {
            age++;
        }

        public void Naissance()
        {
            age = 0;
            estVivant = true;   // Erreur	> 'MaPremiereApplication.Animal.estVivant' 
                                // est inaccessible en raison de son niveau de protection
        }

        public override string ToString()
        {
            return "Je suis un chien et je m'appelle " + prenom;
        }

        public override void Manger()
        {
            Console.WriteLine("Réclamer à manger au maître");
            base.Manger();
            Console.WriteLine("Remuer la queue");
        }
    }
}
