using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MatrixView
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int n = 2;
            var dt = new DataTable();
            dt.Columns.Add("hola");
            //dt.Columns.Add();
            //dt.Columns.Add();
            dt.Rows.Add(0);
            dt.Rows.Add(0);
            dt.Rows.Add(0);
            //dt.Rows.Add(0, 0, 0);
            //dt.Rows.Add(0, 0, 0);

            //grdMatriz.edi
            grdMatriz.DataSource = dt;
            grdMatriz.DataBind();
        }
    }
}