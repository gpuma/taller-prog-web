using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemploSeguridadPropia
{
    public partial class Maestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PrepararControles();
        }

        private void PrepararControles()
        {
            var user = Session[Util.NomVariableCredenciales] as Usuario;
            if (user == null)
            {
                //login
                pnlLogin.Visible = true;
                btnLogout.Visible = false;
            }
            else
            {
                //logout
                pnlLogin.Visible = false;
                btnLogout.Visible = true;
            }
        }

        protected void txtLogin_Click(object sender, EventArgs e)
        {
            var usuario = Seguridad.Autenticar(txtNombreUsuario.Value, txtContraseña.Value);
            if (usuario == null)
            {
                Response.Write("Error iniciando sesión");
                return;
            }
            //con esto podremos usar al objeto desde todos los formularios
            Session[Util.NomVariableCredenciales] = usuario;
            Response.Redirect("~/Vistas/Contabilidad.aspx");
        }

        protected void btnLogout_Clicked(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            //setear la variable de sesión nula es suficiente para "eliminar" las credenciales
            Session[Util.NomVariableCredenciales] = null;

            Response.Redirect("~/Vistas/Home.aspx");

            //por razones del ciclo de vida de la página con este pequeño truco forzamos una
            //recarga de la página DESPUÉS de que hemos eliminado las credenciales, que es lo que queremos
            //sirve para cuando queremos permanecer en la misma página
            //Response.Redirect(Page.Request.FilePath);
        }
    }
}