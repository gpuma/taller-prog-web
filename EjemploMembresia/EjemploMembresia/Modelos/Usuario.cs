using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploMembresia
{
    public class Usuario
    {
        //los atributos propios a nuestra tabla
        public string dni;
        public string nombres;
        public string apellidos;
        public string telefono;
        public string id_usuario_asp;

        //atributos ajenos a la tabla pero que podemos
        //guardarlos aquí por conveniencia
        public string nombre_usuario;
        public string contraseña;
        public string rol;
    }
}