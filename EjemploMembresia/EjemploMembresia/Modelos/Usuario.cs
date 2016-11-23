using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploMembresia
{
    public class Usuario
    {
        //los atributos propios a nuestra tabla
        public string dni{ get; set;}
        public string nombres{ get; set;}
        public string apellidos{ get; set;}
        public string telefono{ get; set;}
        public string id_usuario_asp{ get; set;}

        //atributos ajenos a la tabla pero que podemos
        //guardarlos aquí por conveniencia
        public string nombre_usuario{ get; set;}
        public string contraseña{ get; set;}
        public string rol{ get; set;}
    }
}