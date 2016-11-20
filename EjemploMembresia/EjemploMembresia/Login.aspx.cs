using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace EjemploMembresia
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ctlLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Membership.ValidateUser(ctlLogin.UserName, ctlLogin.Password))
            {
                //RedirectFromLoginPage redirige al usuario al recurso que trató de acceder
                //RememberMeSet indica si el usuario chequeó la opción de "Recordar mis credenciales"
                FormsAuthentication.RedirectFromLoginPage(ctlLogin.UserName, ctlLogin.RememberMeSet);
            }
        }
    }
}