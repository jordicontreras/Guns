using System;
using System.Collections.Generic;
using System.Text;

namespace Guns
{
    class CambiosArma
    {
        //El constructor recibe la unidad y el arma y las imprime por pantalla
        public CambiosArma(string unidad, IArma arma)
        {
            Console.WriteLine(unidad + " ha cambiado a " + arma);
        }
    }
}
