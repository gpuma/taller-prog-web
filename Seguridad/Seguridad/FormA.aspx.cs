using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Seguridad
{
    public partial class FormA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Primero verificamos si inició sesión
            if (Session["credencial"] == null)
            {
                Response.Write("No tiene acceso a este formulario. Inicie sesión");
                return;
            }
            //luego verificamos si tiene permisos
        }
    }
}