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

        public static Usuario ValidarUsuario(string nombre, string contraseña)
        {
            //El método FirstOrDefault obtiene el primer objeto de una lista o el valor por defecto
            //si la lista está vacía. Hacemos esto porque el resultado de la siguiente consulta
            //es una lista, como solo debería haber un usuario con el nombre específico
            return (from u in ObtenerUsuarios()
                    where u.NombreUsuario == nombre && u.Contraseña == contraseña
                    select u).FirstOrDefault();
        }
    }
}