using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica7
{
    public partial class ControlesComplejos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TODO: Actividad 11: Haga el Data Binding respectivo
            //del GridView y del DetailsView
        }

        //Este evento se da cuando se ha seleccionado un item en el GridVIew
        protected void grdProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: Actividad 14: Haga que el control dtlProductos muestre
            //el detalle del item seleccionado en el grdProductos
            //TIP: Revise la documentación de las propiedades PageIndex 
            //y SelectedIndex de ambos controles, respectivamente.

            //SU CÓDIGO AQUÍ

            //TODO: Actividad 15: Haga que el control dtlProductos se muestre
            //porque por defecto se está cargando oculto


            //tenemos que hacer el Binding de nuevo si cambiamos la
            //página del DetailsView manualmente
            dtlProductos.DataBind();
        }
    }
}