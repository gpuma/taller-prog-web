using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica4
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            /*
             * TODO: Actividad 3 - Guardar al Usuario
             * A continuación instanciará un objeto del tipo Usuario (la clase
             * que creó en el paso anterior). En este objeto guardará
             * los valores capturados de este formulario, que ya fueron validados.
             * Como no tenemos base de datos guardaremos al usuario en memoria
             * usando el SessionState. Recordemos que la sesión se crea cuando
             * se carga la aplicación por primera vez, y se mantiene 'viva' 
             * a través de TODOS los formularios, hasta que se CIERRA la aplicación.
             * 
             */
                   
            Usuario nuevoUsuario = null;

            //TODO: SU CÓDIGO VA AQUÍ

            //guardamos al usuario en el sessionState
            //la llave es el nombre del usuario (debería ser único)
            //y el valor es el usuario en sí
            Session[nuevoUsuario.NombreUsuario] = nuevoUsuario;

            //Una vez creado vamos a la página de login
            //Continúe en Login.aspx.cs
            Response.Redirect("Login.aspx");
        }
    }
}