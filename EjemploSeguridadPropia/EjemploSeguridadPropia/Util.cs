using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploSeguridadPropia
{
    //clase "utilitaria"
    public static class Util
    {
        public const string NomVariableCredenciales = "credencial";

        //método extensión, básicamente para no tener que estar escribiendo el
        //código de adentro para todos los formularios
        public static Usuario ObtenerUsuarioSesion(this System.Web.UI.Page formulario)
        {
            //la palabra clave "as" realiza el cast de la expresión a la izquierda solo si no es nula
            return formulario.Session[NomVariableCredenciales] as Usuario;
        }
    }
}