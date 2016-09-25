using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//nos provee acceso a objetos de manipulación de tablas como DataSet, DataTable
using System.Data;
//nos provee acceso a objetos de acceso a bases de datos relacionales
using System.Data.SqlClient;

namespace Practica8
{
    //clase que representa a nuestra tabla Pais
    public class Pais
    {
        public int id_pais { get; set; }
        public string nom_pais { get; set; }
        public decimal pbi_pais { get; set; }
    }
    
    public class Modelo
    {
        //cadena de conexión a la Base de Datos SQL Server, dependiendo del entorno a usar debe ser cambiada
        static string con_str = @"Data Source=.\SQLEXPRESS; Database=SCRUM; Integrated Security=True;";
        
        public static List<Pais> ObtenerPaises()
        {
            //preparamos nuestra variable que almacena los países, 
            List<Pais> paises = null;

            //objeto de conexión a la BD, utiliza a nuestro atributo con_str, cadena de conexión
            //hacemos uso de las sentencias using para simplificar la gestión de recursos
            using (var con = new SqlConnection(con_str))
            using (var da = new SqlDataAdapter("SELECT * FROM Pais", con))
            {
                //DataSet es una clas genérica que nos permite representar a un conjunto de datos
                //como una serie de tablas
                var ds = new DataSet();
                //DataSet.Fill() llena el DataSet con la información obtenida al ejecutar
                //la sentencia especificada en el SqlDataAdapter
                //Automáticamente se conecta a la BD
                da.Fill(ds);

                //DataSet.Tables[0] obtiene la primera tabla (DataTable) del DataSet. A menos que traigamos
                //múltiples tablas al mismo tiempo usualmente emplearemos este comando
                //También podemos usar DataSet.Tables["Pais"]

                //DataTable.AsEnumerable() convierte toda la colección de filas a una colección Enumerable,
                //es decir, podemos utilizar esta colección en expresiones LINQ, que es lo que hacemos a continuación
                //Select() proyecta cada elemento (fila) a otra forma, mediante una expresión LINQ
                paises = ds.Tables[0].AsEnumerable().Select(
                    fila => new Pais
                    {
                        //a la izquierda tenemos la propiedad de nuestra clase y a la derecha hacemos
                        //una conversión explícita al campo leído de la base de datos para almacenarlo
                        //en nuestro caso hemos modelado nuestra clas Pais para que sus propiedades
                        //tengan el mismo nombre que las columnas en la Tabla
                        id_pais = fila.Field<int>("id_pais"),
                        nom_pais = fila.Field<string>("nom_pais"),
                        pbi_pais = fila.Field<decimal>("pbi_pais")
                    }).ToList();
                //El resultado de la expresión anterior, antes de .ToList(), es una colección genérica
                //que implementa la interfaz IEnumerable. Debemos convertirla a Lista (List<>) explícitamente

                //Básicamente, el bloque anterior convierte un DataTable a una Lista de Paises (List<Pais>)
            }
            return paises;
        }

        public static int InsertarPais(Pais p)
        {
            using (var con = new SqlConnection(con_str))
            //pequeño truco que no trae ningún dato pero basta para obtener la estructura de la tabla
            //como vamos a insertar un registro nuevo no necesitamos traer los datos existentes
            using (var da = new SqlDataAdapter("SELECT * FROM Pais WHERE 0 = 1", con))
            {
                var ds = new DataSet();
                da.Fill(ds);
                
                //crea una nueva fila con el esquema de la tabla
                //todo: no funciona??
                //var nuevaFila = ds.Tables["Pais"].NewRow();
                var nuevaFila = ds.Tables[0].NewRow();
                //no especificamos id_pais porque es autogenerado
                nuevaFila["nom_pais"] = p.nom_pais;
                nuevaFila["pbi_pais"] = p.pbi_pais;

                ds.Tables[0].Rows.Add(nuevaFila);

                //un poco de magia: automáticamente crea las sentencia INSERT o UPDATE
                //o DELETE necesarias para actualizar la tabla
                new SqlCommandBuilder(da);

                da.Update(ds);
            }
            return 0;
        }

        public static int ActualizarPais(Pais p)
        {
            using (var con = new SqlConnection(con_str))
            using (var da = new SqlDataAdapter(
                //solo traemos el registro que va a ser actualizado; así optimizamos recursos
                String.Format("SELECT * FROM Pais WHERE id_pais = {0}", p.id_pais), con))
            {
                var ds = new DataSet();
                da.Fill(ds);

                //nos aseguramos que exista el país indicado, si no, retornamos -1 (error)
                var fila = ds.Tables[0].Rows[0];
                if (fila == null)
                    return -1;

                //actualizamos el registro en el DataTable con los valores de nuestro objeto p
                fila["nom_pais"] = p.nom_pais;
                fila["pbi_pais"] = p.pbi_pais;

                //la misma magia
                new SqlCommandBuilder(da);
                da.Update(ds);
            }
            return 0;
        }

        public static int EliminarPais(int id_pais)
        {
            using (var con = new SqlConnection(con_str))
            using (var da = new SqlDataAdapter(
                //solo traemos el registro a eliminar
                String.Format("SELECT * FROM Pais WHERE id_pais = {0}", id_pais), con))
            {
                var ds = new DataSet();
                da.Fill(ds);

                //nos aseguramos que exista el país indicado, si no, retornamos -1 (error)
                var fila = ds.Tables[0].Rows[0];
                if (fila == null)
                    return -1;

                //borramos el registro
                fila.Delete();

                //la misma magia
                new SqlCommandBuilder(da);
                da.Update(ds);
            }
            return 0;
        }

        public static Pais ObtenerPais(int id_pais)
        {
            //si el método no encontró al país indicado entonces este objeto
            //se queda con su valor nulo
            Pais p = null;
            
            using (var con = new SqlConnection(con_str))
            using (var da = new SqlDataAdapter(
                String.Format("SELECT * FROM Pais WHERE id_pais = {0}", id_pais), con))
            {
                var ds = new DataSet();
                da.Fill(ds);

                //si el nro de filas es cero entonces no existe el id_pais indicado
                //entonces retornamos el objeto nulo
                if (ds.Tables[0].Rows.Count == 0)
                    return p;
                
                var fila = ds.Tables[0].Rows[0];
                p = new Pais
                {
                    id_pais = fila.Field<int>("id_pais"),
                    nom_pais = fila.Field<string>("nom_pais"),
                    pbi_pais = fila.Field<decimal>("pbi_pais")
                };
            }
            return p;
        }

        /*TODO: Actividad 1: Cree*/
    }
}