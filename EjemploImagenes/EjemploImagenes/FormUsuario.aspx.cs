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


            var nuevoUsuario = new Usuario()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                //guardaremos la imagen con el nombre de la persona, en este caso supondremos
                //que su nombre es único, más la extensión correspondiente
                URLImagen = "~/imagenes/" + txtNombre.Text + System.IO.Path.GetExtension(imgEntrada.Value)
            };
            
            //PostedFile nos da acceso a la imagen que ha sido subida
            //guardamos dicha imagen en el servidor, para ello requerimos una ruta absoluta
            //por usamos MapPath
            imgEntrada.PostedFile.SaveAs(MapPath(nuevoUsuario.URLImagen));

            var resultado = Modelo.AgregarUsuario(nuevoUsuario);
        }
    }
}