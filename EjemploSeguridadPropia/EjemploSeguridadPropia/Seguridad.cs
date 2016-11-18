using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploSeguridadPropia
{
    //Un struct es como una clase mucho más ligera
    //http://geeks.ms/jalarcon/2010/03/26/clases-y-estructuras-en-net-cundo-usar-cul-y-otras-cuestiones-habituales/
    public struct Regla
    {
        public string Recurso;
        public Permiso Acceso;
    }

    public enum Permiso
    {
        //el primer elemento es el valor por defecto en un enum
        Ninguno,
        Lectura,
        Escritura,
        LecturaYEscritura
    }

    public static class Seguridad
    {
        //por ejemplo: TipoUsuario.Administrador -> (tiene acceso a:) FormularioA.aspx, FormularioB.aspx, etc.
        static Dictionary<TipoUsuario, Regla[]> ReglasDeAcceso;

        //un constructor en una clase estática es ejecutado la primera
        //vez que dicha clase es usada, ya que no se puede instanciar
        static Seguridad()
        {
            CargarReglas();
        }

        //aquí pondríamos cualquier regla nueva que se le añada al sistema
        private static void CargarReglas()
        {
            //nuestro atributo no estaba instanciado
            ReglasDeAcceso = new Dictionary<TipoUsuario, Regla[]>();

            //las reglas para nuestro rol Usuario
            ReglasDeAcceso.Add(TipoUsuario.Usuario, new Regla[]{
                new Regla() { Recurso = "/Contabilidad.aspx", Acceso = Permiso.LecturaYEscritura},
                new Regla() { Recurso = "/RRHH.aspx", Acceso = Permiso.LecturaYEscritura},
            });
            
            //el invitado tiene los mismo que Usuario pero solo lectura
            ReglasDeAcceso.Add(TipoUsuario.Invitado, new Regla[]{
                new Regla() { Recurso = "/Contabilidad.aspx", Acceso = Permiso.Lectura},
                new Regla() { Recurso = "/RRHH.aspx", Acceso = Permiso.Lectura},
            });
        }

        public static Usuario Autenticar(string nombre, string contraseña)
        {
            //El método FirstOrDefault obtiene el primer objeto de una lista o el valor por defecto
            //si la lista está vacía. Hacemos esto porque el resultado de la siguiente consulta
            //es una lista, como solo debería haber un usuario con el nombre específico
            return (from u in Modelo.ObtenerUsuarios()
                    where u.NombreUsuario == nombre && u.Contraseña == contraseña
                    select u).FirstOrDefault();
        }

        //determina si un usuario específico tiene permiso al recurso solicitado
        public static bool Autorizar(string recurso, Usuario usuario, Permiso permiso)
        {
            //podemos añadir un check en el que le damos acceso al administrador a TODO (usar con precaución)
            if (usuario.Tipo == TipoUsuario.Administrador)
                return true;

            //primero validamos que exista el tipo de usuario solicitado
            if (!ReglasDeAcceso.ContainsKey(usuario.Tipo))
                return false;

            //luego accedemos a los detalles
            var reglasActuales = ReglasDeAcceso[usuario.Tipo];

            //Any() retorna verdadero si algún elemento en la secuencia cumple el criterio
            var tieneAcceso = (from r in reglasActuales
                               where r.Recurso == recurso && r.Acceso == permiso
                               select r).Any();

            return tieneAcceso;
        }

        //similar al de arriba. devuelve los permisos disponibles para un recurso específico, si los hay
        //método creado principalmente para pruebas, el de arriba es el que debería usarse
        public static Permiso ObtenerPermisosDisponibles(string recurso, Usuario usuario)
        {
            if (usuario == null)
                return Permiso.Ninguno;

            //podemos añadir un check en el que le damos acceso al administrador a TODO (usar con precaución)
            if (usuario.Tipo == TipoUsuario.Administrador)
                return Permiso.LecturaYEscritura;

            //primero validamos que exista el tipo de usuario solicitado
            if (!ReglasDeAcceso.ContainsKey(usuario.Tipo))
                return Permiso.Ninguno;

            //luego accedemos a los detalles
            var reglasActuales = ReglasDeAcceso[usuario.Tipo];

            //el valor por defecto sería Ninguno
            var permiso = (from r in reglasActuales
                           where r.Recurso == recurso
                           select r.Acceso).FirstOrDefault();

            return permiso;
        }
    }
}