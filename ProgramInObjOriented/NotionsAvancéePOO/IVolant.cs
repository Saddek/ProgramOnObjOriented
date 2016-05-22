using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramInObjOriented.NotionsAvancéePOO
{
    public interface IVolant
    {
        int NombrePropulseurs { get; set; }
        void Voler();
    }
}
