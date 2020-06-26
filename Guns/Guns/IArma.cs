using System;
using System.Collections.Generic;
using System.Text;

namespace Guns
{
    //Interface de la cual heredaran las diferentes armas para estar obligadas a declarar el método Disparar
    public interface IArma
    {
        string Disparar();
    }
}
