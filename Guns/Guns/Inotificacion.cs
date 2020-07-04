using System;
using System.Collections.Generic;
using System.Text;

namespace Guns
{
    //Interface de la cual heredaran las diferentes armas para estar obligadas imprimir el cambio de arma
    public interface Inotificacion
    {
        string CambioArma();
    }
}
