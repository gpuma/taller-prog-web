using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemploImagenes
{
    public partial class FormUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            var resultado = Modelo.AgregarUsuario(new Usuario()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                //URLImagen = txtImagenURL.Text
            });
        }
    }
}