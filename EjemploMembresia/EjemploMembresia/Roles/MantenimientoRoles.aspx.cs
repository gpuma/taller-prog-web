using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//necesario para membresía y roles
using System.Web.Security;

namespace EjemploMembresia
{
    public partial class MantenimientoRoles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrearRol_Click(object sender, EventArgs e)
        {
            CrearRol();
        }

        private void CrearRol()
        {
            var nuevoRol = txtNombreRol.Text;
            if (!Roles.RoleExists(nuevoRol))
            {
                Roles.CreateRole(nuevoRol);
                Response.Write("éxito");
            }
            else
            {
                Response.Write("ya existe el rol");
            }
        }
    }
}