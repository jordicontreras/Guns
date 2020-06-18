using Guns.Lib.Models;
using System;

namespace Guns
{
    class Program
    {
        static void Main(string[] args)
        {
            //soldado shoots with revolver
            var soldado = new Soldado(new Revolver());
            Console.WriteLine(soldado.Disparar());

            //soldado2 shoots with escopeta
            var soldado2 = new Soldado(new Escopeta());
            Console.WriteLine(soldado2.Disparar());

            //soldado3 shoots with rifle
            var soldado3 = new Soldado(new Rifle());
            Console.WriteLine(soldado3.Disparar()); 
        }
    }
}
