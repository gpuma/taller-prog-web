using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionEstado.otros
{
    public partial class Fin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Actividad 7:
            //Muestre el contenido de su cookie en el lblCookie con el sgte formato:
            //"El valor de la cookie Nombre es Pedrito! y expira el 31/12/2016"
            //Para convertir un DateTime a string simplemente llame al método .ToString()
            //Ejemplo: fecha.ToString();

            //Recuerde que el navegador envia las cookies que se han creado como PETICIÓN
            //al servidor así que debe usar la clase Request, por ejemplo:
            //Request.Cookies["llave"];

            //TODO: SU CÓDIGO VA AQUÍ
        }
    }
}