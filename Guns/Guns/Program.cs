//El código del programa esta en Español debido a que el código inicial que hemos usado estaba en este idioma
using Guns.Lib.Models;
using System;

namespace Guns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vamos a crear diferentes objetos de tipo Soldado y Tanque y realizar diferentes acciones como Disparar con diferentes armas o cambiar arma

            //Creamos una instancia de Soldado con un Revolver
            var soldado = new Soldado(new Revolver());
            //La instancia soldado dispara con Revolver
            Console.WriteLine(soldado.Disparar());

            //Cambiamos el arma de la insancia soldado a Rifle
            soldado.CambioArma(new Rifle());
            //La instancia soldado dispara con el Rifle
            Console.WriteLine(soldado.Disparar());

            //Creamos una nueva instancia de Soldado con una Escopeta
            var soldado2 = new Soldado(new Escopeta());
            //La instancia soldado2 dispara con la Escopeta
            Console.WriteLine(soldado2.Disparar());

            //Creamos una instancia de Soldado con un Rifle
            var soldado3 = new Soldado(new Rifle());
            //La instancia soldado3 dispara con el Rifle
            Console.WriteLine(soldado3.Disparar());

            //Creamos una instancia de tanque con un Cannon
            var tanque = new Tanque(new Cannon());
            //La instancia tanque dispara con el Cannon
            Console.WriteLine(tanque.Disparar());

            //Cambiamos el arma de la instancia tanque a Metralleta
            tanque.CambioArma(new Metralleta());
            //La instancia tanque dispara con la Metralleta
            Console.WriteLine(tanque.Disparar());

            //Creamos una nueva instancia de tanque con una Metralleta
            var tanque2 = new Tanque(new Metralleta());
            //La instancia tanque2 dispara con una Metralleta
            Console.WriteLine(tanque2.Disparar());
        }
    }
}
