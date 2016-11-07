using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica9
{
    public partial class AJAX : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblGanador.Text = ObtenerMensajeGanador();

            lblFechaActual.Text = "La hora actual en Arequipa es: " + DateTime.Now.ToLongTimeString();
        }

        //retorna un mensaje sobre la persona aleatoria que se ganó
        //un monto aleatorio de dinero
        string ObtenerMensajeGanador()
        {
            //los nombres de nuestros concursantes
            var concursantes = new string[] { "juan", "pedro", "julia", "bruno", "hector", "mayte" };

            //vamos a elegir a un concursante al azar utilizando un generador de números pseudo-aleatorios
            //DateTime.Now.Milisecond es un entero que actúa como semilla para el generador
            //Más información sobre generadores pseudoaleatorios y semillas:
            //http://www.sc.ehu.es/sbweb/fisica/cursoJava/fundamentos/clases1/azar.htm
            var generador = new Random(DateTime.Now.Millisecond);

            //obtenemos un número entre 0 y el número de concursantes menos 1
            int indiceAleatorio = generador.Next(0, concursantes.Length - 1);

            //también generamos un monto de dinero aleatorio que ganó el concursante
            double montoAleatorio = generador.Next(100000);

            var ganador = concursantes[indiceAleatorio];

            var msjGanador = String.Format("{0} se ganó S/.{1}.00!", ganador, montoAleatorio);

            return msjGanador;
        }
    }
}