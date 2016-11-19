using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace EjemploImagenes
{
    public static class Modelo
    {
        //hay que modificar esto según el equipo
        const string con_str = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=UsuarioBD;Integrated Security=True";
        
        public static int AgregarUsuario(Usuario u)
        {
            using (var con = new SqlConnection(con_str))
            using (var da = new SqlDataAdapter("SELECT * FROM Usuario WHERE 0 = 1", con))
            {
                var ds = new DataSet();
                da.Fill(ds);

                var nuevaFila = ds.Tables[0].NewRow();
     
                nuevaFila["Nombre"] = u.Nombre;
                nuevaFila["Apellido"] = u.Apellido;
                nuevaFila["URLImagen"] = u.URLImagen;

                ds.Tables[0].Rows.Add(nuevaFila);

                new SqlCommandBuilder(da);

                da.Update(ds);
            }
            return 0;
        }

        public static Usuario ObtenerUsuario(string nombre)
        {
            Usuario u = null;

            using (var con = new SqlConnection(con_str))
            using (var da = new SqlDataAdapter(
                String.Format("SELECT * FROM Usuario WHERE nombre = '{0}'", nombre), con))
            {
                var ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count == 0)
                    return u;

                var fila = ds.Tables[0].Rows[0];
                u = new Usuario
                {
                    Nombre = fila.Field<string>("Nombre"),
                    Apellido = fila.Field<string>("Apellido"),
                    URLImagen = fila.Field<string>("URLImagen")
                };
            }
            return u;
        }
    }
}