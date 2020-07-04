using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Lib.Models
{
    public class Soldado
    {
        protected IArma arma;

        //Constructor recibe como parámetro una instancia de arma
        public Soldado(IArma _arma)
        {
            this.arma = _arma;
        }

        //Método para cambiar el arma donde recibimos como parámetro una instancia de arma y llamamos a la función que imprime el cambio por pantalla
        public void CambioArma(IArma _arma)
        {
            this.arma = _arma;
            Console.WriteLine("Soldado cambio a " + this.arma);
            
        }

        //Método disparar que llama a la método Disparar de la instancia de arma creada
        public string Disparar()
        {
            return this.arma.Disparar();
        }
    }

    //Clase Revolver y su método Disparar
    public class Revolver : IArma, Inotificacion
    {
        public string Disparar()
        {
            return "Pum Pum ..";
        }

        public string CambioArma()
        {
            return "Soldado tiene revolver";
        }
    }

    //Clase Rifle y su método Disparar
    public class Rifle : IArma, Inotificacion
    {
        public string Disparar()
        {
            return "Pum pum pum pum pum ..";
        }

        public string CambioArma()
        {
            return "Soldado tiene rifle";
        }
    }

    //Clase Escopeta y su método Disparar
    public class Escopeta : IArma, Inotificacion
    {
        public string Disparar()
        {
            return "pum PUMMM !! ..";
        }

        public string CambioArma()
        {
            return "Soldado tiene escopeta";
        }
    }

    //Clase Gatling y su método Disparar
    public class Gatling : IArma, Inotificacion
    {
        public string Disparar()
        {
            return "PU PU PU PU PU PU PU PU PU PU PU PU PU PU PU PUPU PU PU PU PU PU PU PU PUUUUMMMM !! ..";
        }

        public string CambioArma()
        {
            return "Soldado tiene gatling";
        }
    }
}
