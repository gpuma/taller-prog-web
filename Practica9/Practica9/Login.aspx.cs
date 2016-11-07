using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//necesario para autenticación
using System.Web.Security;

namespace Practica9
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //usamos nuestra clase Seguridad
            Seguridad.PrepararUsuariosYRoles();
        }

        protected void ctlLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            Response.Write(Membership.GetAllUsers().Count);
            if (FormsAuthentication.Authenticate(ctlLogin.UserName, ctlLogin.Password))
                Response.Write("nice");
            else
                Response.Write("NOPE!");
        }
    }
}