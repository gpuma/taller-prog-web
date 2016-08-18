using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionEstado
{
    public partial class Bienvenido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Actividad 1:
            //Mostrar el código de Hola Mundo en HTML en lblHTML
            //sin que el navegador lo interprete (escapar HTML)
            //Use el método Server.HtmlEncode()
            
            //TIP: Si desea especificar una cadena de texto en lineas múltiples
            //lo puede hacer usando el caracter '@' de la sgte. forma:
            //string cadena = @"una linea
            //                  dos lineas
            //                  tres lineas";

            //TODO: SU CÓDIGO VA AQUÍ
        }

        protected void btnIr_Click(object sender, EventArgs e)
        {
            //Actividad 2:
            //Agregar código para que al hacer click al botón
            //lo redireccione a la página OtraPagina.aspx
            //Use el método Response.Redirect()
            //TIP: Recuerde que OtraPagina.aspx se encuentra
            //dentro de una carpeta
            
            //TODO: SU CÓDIGO VA AQUÍ
        }
    }
}