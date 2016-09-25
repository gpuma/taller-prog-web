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
        //todo: mover a otro lado
        public class NotaEstudiante
        {
            public int IDMatricula;
            public int IDCurso;
            public int IDEstudiante;
            public double? Nota;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            grd.DataSource = Modelo.ObtenerPaises();
            grd.DataBind();
        }
    }
}