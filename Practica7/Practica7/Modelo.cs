using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica7
{
    public class Lenguaje
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
    }
    public class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Proveedor { get; set; }
        public double Precio { get; set; }
        public double Stock { get; set; }
        public bool Descontinuado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }

    //Modelo es un término que suele referirse a una (o más) bases de datos. Como todavía no hemos visto
    //conexiones a bases de datos, crearemos nuestros datos nosotros y haremos una especie de simulación
    //de como suele usarse un modelo. ObtenerProductos() simula una lectura de datos y devuelve una lista de objetos
    public class Modelo
    {
        //Como los datos que manipula nuestro método son creados dentro del mismo, en otras palabras,
        //no utilizamos atributos, lo declaramos como estático
        public static List<Producto> ObtenerProductos()
        {
            //Podemos crear una lista e inicializarla con sus respectivos datos
            List<Producto> productos = new List<Producto>()
            {
                new Producto {  Codigo = 1, Nombre = "Monitor IPS 21", Proveedor = "DELTRON", Precio = 600.00,
                                Stock = 20, Descontinuado = false, FechaRegistro = new DateTime(2016, 01, 31)
                },
                new Producto {  Codigo = 2, Nombre = "Mouse Láser", Proveedor = "PEPITO", Precio = 59.90,
                                Stock = 5, Descontinuado = true, FechaRegistro = new DateTime(2010, 12, 12)
                }
            };

            //Pero también podemos añadir datos a una lista existente de la siguiente manera:
            Producto prod = new Producto
            {
                Codigo = 3,
                Nombre = "Oculus Rift",
                Proveedor = "MCNAMAL",
                Precio = 2039.99,
                Stock = 5,
                Descontinuado = false,
                FechaRegistro = new DateTime(2016, 09, 31)
            };
            productos.Add(prod);

            //TODO: Actividad X: Añada 7 productos más

            return productos;
        }

        public static List<Lenguaje> ObtenerLenguajes()
        {
            //TODO: Actividad X: Añada 7 lenguajes más
            List<Lenguaje> lenguajes = new List<Lenguaje>()
            {
                new Lenguaje{ Codigo= 1, Nombre= "C#"},
                new Lenguaje{ Codigo=2,Nombre="Haskell"},
                new Lenguaje{ Codigo=3, Nombre="Prolog"}
            };

            return lenguajes;
        }
    }
}