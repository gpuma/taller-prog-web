using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploSeguridadPropia
{
    //un enum es una lista de enteros más legible, básicamente
    //Administrador corresponde a 0, Usuario a 1, Invitado a 2...
    public enum TipoUsuario
    {
        Administrador,
        Usuario,
        Invitado
    }
    public class Usuario
    {
        public string NombreUsuario;
        public string Contraseña;
        public TipoUsuario Tipo;
    }
}