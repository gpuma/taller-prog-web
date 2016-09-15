using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //            //instancia
            //            Perro miMascota = new Perro();
            //            miMascota.nombre = "Lucho";
            //            miMascota.color = "café";
            //            miMascota.raza = "chusquito";
            //            miMascota.cola = true;

            //            Mamifero ornitorrinco = new Mamifero();
            //            ornitorrinco.alas = false;
            //            ornitorrinco.dejaHuevos = false;
            //            //código no válido
            //            ornitorrinco.ObtenerNombrePlaneta();
            //            //código válido
            //            Mamifero.ObtenerNombrePlaneta();

            //Algebra.Multiplicar(2, 2);
            //Algebra.Dividir(2, 2);
            ////código no válido
            //Algebra alg = new Algebra();


            //            Console.ReadKey();
Perro rocky = new Perro();
rocky.Nombre = "Rocky";
//qué nombre tendría ahora?
rocky.Nombre = "";
rocky.Raza = "Rottweiler";
//código no válido
rocky.nombre = "lucho";

            ////llamada a los métodos
            //ornitorrinco.ObtenerNroPatas();
            //rocky.ObtenerNroPatas();
            ////código no válido
            //ornitorrinco.Ladrar();
        }
    }
}
