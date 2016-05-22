using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramInObjOriented.NotionsAvancéePOO
{
    public class Voiture : IComparable
    {
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public int Vitesse { get; set; }

        public int CompareTo(object obj)
        {
            //throw new NotImplementedException();
            Voiture voiture = (Voiture)obj;
            if (this.Vitesse < voiture.Vitesse)
                return -1;
            if (this.Vitesse > voiture.Vitesse)
                return 1;
            return 0;
        }
    }
}
