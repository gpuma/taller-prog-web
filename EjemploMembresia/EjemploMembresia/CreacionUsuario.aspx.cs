using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemploMembresia
{
    public partial class CreacionUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Simplemente cargamos los roles desde nuestro modelo
                //para mostrarlos en el dropdown
                drpRol.DataSource = Modelo.nombresRoles;
                drpRol.DataBind();
            }
        }

        protected void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            CrearUsuario();
        }

        private void CrearUsuario()
        {
            var nuevoUsuario = new Usuario()
            {
                dni = txtDNI.Text,
                nombres = txtNombres.Text,
                apellidos = txtApellidos.Text,
                telefono = txtTelefono.Text,

                nombre_usuario = txtNombreUsuario.Text,
                contraseña = txtContraseña.Text,
                rol = drpRol.SelectedValue
            };
            if (Modelo.CrearNuevoUsuario(nuevoUsuario) == 0)
            {
                Response.Write("éxito");
            }
            else
            {
                Response.Write("error");
            }
        }
    }
}