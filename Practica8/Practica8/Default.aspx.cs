using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Practica8
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var ds = Modelo.ObtenerPaises();
            //grd.DataSource = ds;
            //grd.DataBind();

            dtl.DataSource = new List<Pais> { Modelo.ObtenerPais(4)};
            dtl.DataBind();
            //var p = ds[7];
            //p.nom_pais="Corea del sur";
            //p.pbi_pais=777;

            //Modelo.ActualizarPais(p);
            //Modelo.EliminarPais(11);
        }
    }
}