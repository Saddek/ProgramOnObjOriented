using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramInObjOriented.partie1_4_LA_POO_ET_LE_Csharp
{
    class Polymorphe
    {
        
            static void Main1111(string[] args)
            {
                Math math = new Math();
                int a = 5;
                int b = 6;
                int resultat = math.Addition(a, b);

                double c = 1.5;
                double d = 5.0;
            //resultat = math.Addition(c, d); // erreur de compilation
            double resultatDouble = math.Addition(c, d); // ca compile, youpi , polymorphe
        }
        }

        public class Math
        {
            public int Addition(int a, int b)
            {
                return a + b;
            }
            public double Addition(double a, double b)
            {
                return a + b;
            }
            public int Addition(Chien c1, Chien c2)
            {
                return c1.NombreDePattes + c2.NombreDePattes;
            }
    }
    
}
