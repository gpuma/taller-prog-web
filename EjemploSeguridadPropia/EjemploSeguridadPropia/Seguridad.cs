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
        Lectura,
        Escritura,
        Todo
    }

    public static class Seguridad
    {
        //por ejemplo: TipoUsuario.Administrador -> (tiene acceso a:) FormularioA.aspx, FormularioB.aspx, etc.
        static Dictionary<TipoUsuario, Regla[]> ReglasDeAcceso;

        //un constructor en una clase estática es ejecutado la primera
        //vez que dicha clase es usada, ya que no se puede instanciar
        public Seguridad()
        {
            PrepararReglas();
        }

        private static void PrepararReglas()
        {
            //nuestro atributo no estaba instanciado
            ReglasDeAcceso = new Dictionary<TipoUsuario, Regla[]>();

            //las reglas para nuestro rol Usuario
            ReglasDeAcceso.Add(TipoUsuario.Usuario, new Regla[]{
                new Regla() { Recurso = "Contabilidad.aspx", Acceso = Permiso.Todo},
                new Regla() { Recurso = "RRHH.aspx", Acceso = Permiso.Todo},
            });
            
            //el invitado tiene los mismo que Usuario pero solo lectura
            ReglasDeAcceso.Add(TipoUsuario.Invitado, new Regla[]{
                new Regla() { Recurso = "Contabilidad.aspx", Acceso = Permiso.Lectura},
                new Regla() { Recurso = "RRHH.aspx", Acceso = Permiso.Lectura},
            });
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
    }
}