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
            //así autenticamos
            //todo: explicar remembermeset
            if (Membership.ValidateUser(ctlLogin.UserName, ctlLogin.Password))
            {
                FormsAuthentication.RedirectFromLoginPage(ctlLogin.UserName, ctlLogin.RememberMeSet);
            }
            else
            {
                Response.Write("error");
            }
        }
    }
}