using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionEstado
{
    public partial class OtraPagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Actividad 3:
            //Cree un Cookie que se llame 'Nombre' (sin comillas)
            //y que el valor de esa Cookie sea su nombre
            //Recuerde que para crear una cookie se usa la siguiente sintaxis:
            //HttpCookie cookie = new HttpCookie("llave", "valor");

            //Actividad 4:
            //Póngale como fecha de expiración a su cookie 31/12/2016
            //TIP: Revisa la propiedad .Expires de HttpCookie
            //Para esto debe usar el tipo de dato DateTime, que representa a una fecha
            //TIP: revise la documentación de DateTime; hay un constructor de DateTime que toma
            //tres argumentos: año, mes y día

            //Actividad 5:
            //Añada su cookie a la respuesta que envía el servidor
            //Use Response.Cookies.Add(...)

            //TODO: SU CÓDIGO VA AQUÍ
        }

        protected void btnTerminar_Click(object sender, EventArgs e)
        {
            //Actividad 6:
            //Redirija a la página Fin.aspx

            //TODO: SU CÓDIGO VA AQUÍ
        }
    }
}