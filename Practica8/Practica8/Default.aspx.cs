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
            var point = new { x = 3, y = 5 };
            //point.

            var con_str = @"Data Source=.\SQLEXPRESS;
                            AttachDbFilename=|DataDirectory|\Escuela.mdf;
                            Integrated Security=True;
                            Connect Timeout=30;
                            Initial Catalog=Escuela;
                            User Instance=True";

            using (var con = new SqlConnection(con_str))
            //using (var cmd = new SqlCommand("select * from NotaEstudiante", con))
            using (var da = new SqlDataAdapter("select * from NotaEstudiante", con))
            {
                var ds = new DataSet();
                da.Fill(ds);

                IEnumerable<NotaEstudiante> notas = ds.Tables[0].AsEnumerable().Select(dr => new NotaEstudiante
                {
                    IDMatricula = dr.Field<int>("IDMatricula"),
                    IDCurso = dr.Field<int>("IDCurso"),
                    IDEstudiante = dr.Field<int>("IDEstudiante"),
                    Nota = dr.Field<double?>("Nota"),
                });

                var no = notas.ToList();
                int g = 0;
                //SqlCommand cmd = new SqlCommand("select * from NotaEstudiante", con);
                //con.Open();
                //var reader = cmd.ExecuteReader();
                //try
                //{
                //    while (reader.Read())
                //    {
                //        Response.Write(String.Format("{0}, {1} <br/>", reader[0], reader[1]));
                //    }
                //}
                //finally
                //{
                //    reader.Close();
                //}
            }
        }
    }
}