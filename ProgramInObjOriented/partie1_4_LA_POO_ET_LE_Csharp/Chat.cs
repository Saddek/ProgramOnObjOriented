﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramInObjOriented.partie1_4_LA_POO_ET_LE_Csharp
{
    public class Chat : Animal
    {
        public Chat() 
        {
            Console.WriteLine("Je la classe Chien qui herite de la classe Animal");
            //this.prenom = prenomDuChat;
        }
        public Chat(string prenomDuChat) : base (prenomDuChat)
        {
            Console.WriteLine("Je la classe Chien qui herite de la classe Animal");
            //this.prenom = prenomDuChat;
        }

        public void Miauler()
        {
            Console.WriteLine("Miaou");
        }
        private Chien.Coeur coeur = new Chien.Coeur("");

        public void Mourir()
        {
            coeur.Stop();
        }
    }
}
