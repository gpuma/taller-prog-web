using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemploSeguridadPropia
{
    public partial class RRHH : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var permiso = Seguridad.ObtenerPermisosDisponibles(Request.Path, this.ObtenerUsuarioSesion());

            if (permiso == Permiso.Ninguno)
                Response.Redirect("~/Vistas/Error.aspx");
            else
                Response.Write("Ud. tiene permiso de: " + permiso.ToString());
        }
    }
}