using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Seguridad
{
    public partial class FormA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var usuario = (Usuario)Session["credencial"];
            ////Primero verificamos si inició sesión
            //if (usuario == null)
            //{
            //    Response.Write("Debe iniciar sesión");
            //    return;
            //}
            ////luego verificamos si tiene permisos
            //if (usuario.Tipo != "A")
            //{
            //    Response.Write("Usted no tiene permisos para acceder a este formulario.");
            //    return;
            //}
            
        }
    }
}