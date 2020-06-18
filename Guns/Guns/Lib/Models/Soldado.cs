using System;
using System.Collections.Generic;
using System.Text;

namespace Guns.Lib.Models
{
    public class Soldado
    {
        protected IArma arma;

        public Soldado(IArma _arma)
        {
            this.arma = _arma;
        }

        public string Disparar()
        {
            return this.arma.Disparar();
        }
    }

    public interface IArma
    {
        string Disparar();
    }

    public class Revolver : IArma
    {
        public string Disparar()
        {
            return "Pum Pum ..";
        }
    }

    public class Rifle : IArma
    {
        public string Disparar()
        {
            return "Pum pum pum pum pum ..";
        }
    }

    public class Escopeta : IArma
    {
        public string Disparar()
        {
            return "pum PUMMM !! ..";
        }
    }

    public class Gatling : IArma
    {
        public string Disparar()
        {
            return "PU PU PU PU PU PU PU PU PU PU PU PU PU PU PU PUPU PU PU PU PU PU PU PU PUUUUMMMM !! ..";
        }
    }
}
