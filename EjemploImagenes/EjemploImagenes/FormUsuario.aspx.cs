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
            string modo = Request.Params["modo"];
            //si no hay modo por defecto cargamos modo NUEVO
            if (modo == null)
                Response.Redirect("~/FormUsuario.aspx?modo=nuevo");
            string nombre = null;
            
            if (Request.Params["nombre"] != null)
                nombre = Request.Params["nombre"];

            switch (modo)
            {
                case "nuevo":
                    CargarModoNuevo();
                    break;
                case "lectura":
                    CargarModoLectura(nombre);
                    break;
            }
        }

        private void CargarModoNuevo()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            imgEntrada.Visible = true;
            imgPreview.Visible = true;
            imgUsuario.Visible = false;
            lnkNuevo.Visible = false;
        }

        private void CargarModoLectura(string nombre)
        {
            //estética
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            imgEntrada.Visible = false;
            imgPreview.Visible = false;
            btnGuardar.Visible = false;
            lnkNuevo.Visible = true;

            var u = Modelo.ObtenerUsuario(nombre);
            if (u == null)
            {
                Response.Write("no existe");
                return;
            }

            txtNombre.Text = u.Nombre;
            txtApellido.Text = u.Apellido;
            //guardamos rutas relativas en la BD
            imgUsuario.Src = u.URLImagen;
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

            if (resultado == 0)
            {
                Response.Redirect("~/FormUsuario.aspx?modo=lectura&nombre=" + nuevoUsuario.Nombre);
            }
        }
    }
}