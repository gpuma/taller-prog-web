using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica8
{
    public partial class FormPais : System.Web.UI.Page
    {
        string modo;
        int id_pais;
        protected void Page_Load(object sender, EventArgs e)
        {
            //si no se sobrescribirán los valores de los formularios
            if (IsPostBack)
                return;
            //Este formulario se comportará de manera diferente según el modo indicado
            modo = Request.Params["modo"];
            //si existe el parámetro id_pais lo guardamos
            if (Request.Params["id_pais"] != null)
                id_pais = Convert.ToInt32(Request.Params["id_pais"]);
            switch (modo)
            {
                case "nuevo":
                    CargarModoNuevo();
                    break;
                case "lectura":
                    CargarPaisModoLectura(id_pais);
                    break;
                case "edicion":
                    CargarPaisModoEdicion(id_pais);
                    break;
            }
        }

        private void CargarPaisModoLectura(int id_pais)
        {
            pnlBusqueda.Visible = false;

            //obtenemos el país indicado
            Pais p = Modelo.ObtenerPais(id_pais);
            if (p == null)
            {
                Response.Write("El país indicado no existe");
                pnlPais.Visible = false;
                btnEliminar.Visible = false;
                return;
            }
            
            //mostramos los controles si estaban escondidos
            pnlPais.Visible = true;
            btnAgregarPais.Visible = false;
            btnActualizarPais.Visible = false;
            btnEliminar.Enabled = true;
            lnkEdicion.Visible = true;

            //deshabilitamos los controles
            CambiarEstadoControles(false);
            
            //llenamos los controles con los valores del país
            txtIdPais.Text = p.id_pais.ToString();
            txtNomPais.Text = p.nom_pais;
            txtPBI.Text = p.pbi_pais.ToString();
        }

        private void CargarPaisModoEdicion(int id_pais)
        {
            //Como primero tenemos que cargar los controles con los datos del país
            //llamamos al método que ya creamos para no repetir código
            CargarPaisModoLectura(id_pais);

            //una vez que está cargado volvemos editables a los controles
            CambiarEstadoControles(true);

            btnActualizarPais.Visible = true;
            //no puede modificar el ID xq es autogenerado
            txtIdPais.Enabled = true;
            //ocultamos el button link de edición
            lnkEdicion.Visible = false;
        }

        private void CargarModoNuevo()
        {
            pnlBusqueda.Visible = false;

            pnlPais.Visible = true;
            CambiarEstadoControles(true);
            //el id es autogenerado
            txtIdPais.Visible = false;
            lblIdPais.Visible = false;
            btnActualizarPais.Visible = false;
            btnEliminar.Visible = false;
        }

        //lee los controles de nuestro formulario y nos devuelve un objeto País
        private Pais LeerControlesYCrearObjeto()
        {
            //no necesitamos guardarlo en una variable, ya que el método
            //solo devuelve al objeto, no lo almacena
            return new Pais
            {
                //a esto se le llama condicional ternaria. es como un if abreviado. Tiene la sgte sintaxis:
                //<condicion>?<qué valor retornar cuándo es verdadera>:<qué retornar cuándo es falsa>
                //aquí decimos que si el textbox está vacío, el valor de id_pais sea cero (útil en la inserción)
                id_pais = (txtIdPais.Text != "") ? Convert.ToInt32(txtIdPais.Text) : 0,
                nom_pais = txtNomPais.Text,
                pbi_pais = Convert.ToDecimal(txtPBI.Text)
            };
        }

        //activa o desactiva los controles del formulario
        void CambiarEstadoControles(bool estado)
        {
            txtIdPais.Enabled = estado;
            txtNomPais.Enabled = estado;
            txtPBI.Enabled = estado;
            btnAgregarPais.Enabled = estado;
            btnActualizarPais.Enabled = estado;
        }
        
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int resultado = Modelo.EliminarPais(Convert.ToInt32(txtIdPais.Text));
            if (resultado == 0)
                Response.Redirect("Exito.aspx");
            else
                Response.Write("Ocurrió un error eliminando!");
        }

        protected void btnActualizarPais_Click(object sender, EventArgs e)
        {
            //obtenemos un objeto a partir de los controles
            Pais p = LeerControlesYCrearObjeto();

            //para verificar el resultado
            int res = Modelo.ActualizarPais(p);
            if (res == 0)
                Response.Redirect("Exito.aspx");
            else
                Response.Write("Ocurrió un error actualizando el dato");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //redirigimos a otro modo del formulario
            Response.Redirect("~/FormPais.aspx?modo=lectura&id_pais=" + txtBusqueda.Text);
        }

        protected void btnAgregarPais_Click(object sender, EventArgs e)
        {
            //obtenemos un objeto a partir de los controles
            Pais p = LeerControlesYCrearObjeto();

            //para verificar el resultado
            int res = Modelo.AgregarPais(p);
            if (res == 0)
                Response.Redirect("Exito.aspx");
            else
                Response.Write("Ocurrió un error agregando el dato");
        }

        //redirección al modo edición
        protected void lnkEdicion_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FormPais.aspx?modo=edicion&id_pais=" + txtIdPais.Text);
        }
    }
}