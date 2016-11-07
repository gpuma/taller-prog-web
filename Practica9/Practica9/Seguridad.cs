//necesario para implementar autenticación y autorización
using System.Web.Security;

namespace Practica9
{
    public static class Seguridad
    {
        ////el constructor en una clase estática solo corre la primera vez que se
        ////llama a la clase
        //static Seguridad()
        //{

        //}

        //Al usar las opciones de membresía y roles se nos creará
        //una BD en nuestro proyecto con los roles y usuarios que creemos
        public static void PrepararUsuariosYRoles()
        {
            //Ya que todo se guarda en una BD, así reiniciemos nuestra
            //aplicación los usuarios creados seguirán existiendo
            //por lo tanto el cuerpo de este método solo debería ejecutarse
            //si es que no tenemos usuarios
            if (Roles.GetAllRoles().Length > 0)
                return;

            //creamos los roles
            Roles.CreateRole("admin");
            Roles.CreateRole("usuario");

            //creamos los usuarios
            //MembershipCreateStatus estado;
            //Membership.CreateUser("fulano", "1234", null, null, null, true, out estado);
            //Membership.CreateUser("sutano", "1234", null, null, null, true, out estado);
            //Membership.CreateUser("mengano", "1234", null, null, null, true, out estado);

            Membership.CreateUser("fulano", "1234");
            Membership.CreateUser("sutano", "1234");
            Membership.CreateUser("mengano", "1234");

            //y al final asignamos los roles a nuestros usuarios
            Roles.AddUserToRole("fulano", "admin");
            Roles.AddUserToRole("sutano", "usuario");
            Roles.AddUserToRole("mengano", "usuario");
        }
    }
}