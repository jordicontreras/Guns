using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Lib.Models
{
    class Tanque
    {
        protected IArma arma;

        //Constructor recibe como parámetro una instancia de arma
        public Tanque(IArma _arma)
        {
            this.arma = _arma;
        }

        //Método para cambiar el arma donde recibimos como parámetro una instancia de arma y llamamos a la función que imprime el cambio por pantalla
        public void CambiarArma(IArma _arma)
        {
            this.arma = _arma;
            var cambioArma = new CambiosArma("tanque", _arma);
        }

        //Método disparar que llama a la método Disparar de la instancia de arma creada
        public string Disparar()
        {
            return this.arma.Disparar();
        }
    }

    //Clase Metralleta y su método Disparar
    public class Metralleta : IArma
    {
        public string Disparar()
        {
            return "PU PU PU PU PU PU PU PU PU PU PU PU PU PU PU PUPU PU PU PU PU PU PU PU PUMMMM !! ..";
        }
    }

    //Clase Cannon y su método Disparar
    public class Cannon : IArma
    {
        public string Disparar()
        {
            return "PUUUUUUUUUMMMM !! ..";
        }
    }
}
