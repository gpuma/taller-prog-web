using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica8
{
    public partial class PaisesEditables : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }
        }

        protected void grdPaises_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //necesario setear el índice de edición para que entre a modo edición
            grdPaises.EditIndex = e.NewEditIndex;
            Bind();
        }

        protected void grdPaises_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var p = new Pais()
            {
                //con e.Keys obtenemos el valor del campo que indicamos como primario
                //para la fila que está siendo editado
                id_pais = Convert.ToInt32(e.Keys[0]),
                //los campos de solo lectura deben accederse directamente
                nom_pais = grdPaises.Rows[e.RowIndex].Cells[2].Text,
                //solo los campos que han sido editados aparecen en la colección e.NewValues
                pbi_pais = Convert.ToDecimal(e.NewValues["pbi_pais"])
            };
            Modelo.ActualizarPais(p);
            
            //termina el modo de edición
            grdPaises.EditIndex = -1;
            Bind();
        }
        protected void Bind()
        {
            grdPaises.DataSource = Modelo.ObtenerPaises();
            grdPaises.DataBind();
        }
        protected void grdPaises_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdPaises.EditIndex = -1;
            Bind();
        }


    }
}