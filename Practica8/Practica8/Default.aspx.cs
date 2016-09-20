using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Practica8
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var con_str = @"Data Source=.\SQLEXPRESS;
                            AttachDbFilename=|DataDirectory|\Escuela.mdf;
                            Integrated Security=True;
                            Connect Timeout=30;
                            Initial Catalog=Escuela;
                            User Instance=True";

            using (var con = new SqlConnection(con_str))
            {
                SqlCommand cmd = new SqlCommand("select * from NotaEstudiante", con);
                con.Open();
                var reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        Response.Write(String.Format("{0}, {1} <br/>", reader[0], reader[1]));
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
        }
    }
}