using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            /* TODO: Actividad 4 - Lectura del usuario creado
             * Ahora deberá comprobar que el usuario y contraseña
             * ingresados en este formulario correspondan
             * al usuario guardado en memoria en el SessionState
             * (que Ud. debe haber creado para llegar aquí).
             */
            if (Session[txtNomUsuario.Text] == null)
            {
                //no existe
                //TODO: muestre algún mensaje apropiado
            }
            else
            {
                //sí existe
                //TODO: verifique que la contraseña ingresada
                //en el form. sea la que está guardada en el SessionState
                //para esto tendrá que obtener el objeto del SessionState,
                //convertirlo (cast) a tipo de dato 'Usuario' y comparar su
                //propiedad password con el password ingresado

                //esto es un cast o conversión. Recuerde que Session
                //guarda objetos del tipo Object, por eso esto
                Usuario user = (Usuario)Session[txtNomUsuario.Text];

                //Sí la contraseña es correcta, redirija al form. Exito.aspx
                //si no, muestre un mensaje apropiado
                
                //Para poder mostrar los datos requeridos en el form Exito.aspx
                //debe enviarle el nombre de usuario de modo que este Web Form
                //pueda recuperar al Usuario desde Session
                //para esto utilizaremos parámetros de dirección
                //TIP: podemos usar txtNomUsuario porque ya verificamos que
                //el nombre de usuario ingresado existe en esta parte del código
                Response.Redirect("Exito.aspx?nomUsr=" + txtNomUsuario.Text);
            }
        }
    }
}