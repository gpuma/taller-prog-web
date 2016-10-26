using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//necesario
using System.Web.Security;

namespace Seguridad
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)
            //    return;
            //var usuario = Modelo.ValidarUsuario(txtNombreUsuario.Value, txtContraseña.Value);
            //if (usuario == null)
            //{
            //    Response.Write("Error iniciando sesión");
            //    return;
            //}

            ////con esto podremos usar al objeto desde todos los formularios
            //Session["credencial"] = usuario;
            //Response.Redirect("~/FormA.aspx");


            //roles
            //if (!IsPostBack)
            //{
            //    Roles.CreateRole("administrador");
            //    Roles.CreateRole("usuario");
            //}
            //else
            //    Response.Write(Roles.GetAllRoles().Count());
        }

        protected void txtLogin_Click(object sender, EventArgs e)
        {
            var usuario = Modelo.ValidarUsuario(txtNombreUsuario.Value, txtContraseña.Value);
            if (usuario == null)
            {
                Response.Write("Error iniciando sesión");
                return;
            }
            FormsAuthentication.RedirectFromLoginPage(usuario.NombreUsuario, true);
        }
    }
}