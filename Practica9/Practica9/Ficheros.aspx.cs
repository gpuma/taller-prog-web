using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//necesario para manejar ficheros
using System.IO;

namespace Practica9
{
    public partial class Ficheros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //solo hacemos el binding cuando se carga la página por por primera vez
            if (IsPostBack)
                return;
            
            //mostramos los archivos del directorio "documentos"
            //Con Server.MapPath() obtenemos la ruta absoluta, en base a una ruta relativa
            string rutaAbsoluta = Server.MapPath("~/documentos");
            string[] nombresArchivos = Directory.GetFiles(rutaAbsoluta);

            lstArchivos.DataSource = nombresArchivos;
            lstArchivos.DataBind();
            
            //TODO: Actividad 1: muestre el espacio libre en el disco C
            //TIP: Revise las diapositivas o la documentación de la clase DriveInfo

            //TODO: Punto extra: muestre solo el nombre de los archivos, no su ruta completa
            //ejemplo: "C:/proyectos/Practica9/documentos/documento-1.txt" -> "documento-1.txt"

            
        }

        public void lstArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: Actividad 2: cuando el usuario seleccione un archivo en el Listbox lstArchivos
            //muestre su contenido en txtContenido. Se le recomienda crear un método
            //que tome la ruta de un archivo y devuelva una cadena con su contenido.
            //TIP: Haga uso de la clases StreamReader. Revise los ejemplos de la documentación:
            //https://msdn.microsoft.com/es-es/library/system.io.streamreader(v=vs.110).aspx


            //TODO: Actividad 3: Muestre los siguientes datos del archivo seleccionado: fecha de creación,
            //fecha de modificación y fecha de acceso en el control txtInfoArchivo
            //TIP: Revise las diapositivas sobre la clase File

        }

        public void btnGuardar_OnClick(object sender, EventArgs e)
        {
            //TODO: Actividad 4: Permita que el usuario pueda editar el texto del archivo seleccionado
            //y que se guarden los cambios cuando haga click al botón guardar
            //TIP: se le recomienda crear un método que actualice el texto de un archivo existente
            //TIP: Utilice la clase StreamWriter. Revise los ejemplos de la documentación:
            //https://msdn.microsoft.com/es-es/library/system.io.streamwriter(v=vs.110).aspx

        }
    }
}