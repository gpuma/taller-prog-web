using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica4
{
    public class Usuario
    {
        /*
         * TODO: Actividad 2 - Clase Usuario
         * A continuación creará una Clase que representará
         * a los usuarios de su sistema. Complete las propiedades
         * que faltan según los campos de su formulario CrearUsuario.aspx
         * Se le proporciona la sintaxis de los primeros campos a continuación
         * { get; set; } indica que el campo es una propiedad
         */
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
    }
}