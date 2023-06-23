using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    internal interface IArchivo
    {
        string[] leerArchivo();
        void convertirDatos(string x);
    }
}
