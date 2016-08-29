using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica4
{
    public partial class Exito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			//TODO: Actividad 5
			//Cuando se cargue la página muestre el sgte. mensaje
			//Bienvenido de nuevo, Nombres + Apellidos
			//Donde nombres y apellidos, corresponden al usuario creado
			//TIP: se recomienda que cree un nuevo Label para esto
			
            //Para obtener el nombre de usuario que enviamos como parámetro en la URL
            //en el form Login.aspx, usamos código a continuación.
            //TIP: no se olvide usar este nombre para recuperar
            //al objeto Usuario guardado en Session, al igual que anteriormente
            string nombreUsuario = Request.Params["nomUsr"];

			//TODO: su código va aquí
        }
    }
}