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
    }
}