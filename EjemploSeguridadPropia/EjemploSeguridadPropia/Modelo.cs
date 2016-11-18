using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploSeguridadPropia
{
    public class Modelo
    {
        //en una aplicación real este método leería de una Base de Datos
        public static IEnumerable<Usuario> ObtenerUsuarios()
        {
            return new List<Usuario>()
            {
                new Usuario {NombreUsuario = "admin", Contraseña = "admin", Tipo=TipoUsuario.Administrador},
                new Usuario {NombreUsuario = "juan", Contraseña = "juan", Tipo=TipoUsuario.Usuario},
                new Usuario {NombreUsuario = "pedro", Contraseña = "pedro", Tipo=TipoUsuario.Invitado}
            };
        }
    }
}