using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Seguridad
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                return;
            var usuario = Modelo.ValidarUsuario(txtNombreUsuario.Value, txtContraseña.Value);
            if (usuario == null)
            {
                Response.Write("Error iniciando sesión");
                return;
            }

            //con esto podremos usar al objeto desde todos los formularios
            Session["credencial"] = usuario;
            //Response.Redirect("~/FormA.aspx");
        }
    }
}