using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica6
{
    public partial class Maestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TODO: Actividad 4: Agregue un pequeño mensaje que muestre
            //la hora actual. Utilice la propiedad especial: DateTime.Now
            //Recuerde que este mensaje se mostrará para cualquier página
            //de contenido que derive de esta página maestra
            
        }
        //TODO: Actividad 5: A continuación, en el explorador de soluciones, agregue
        //tres WebForms más llamados: Pagina2, Pagina3, Pagina4. Tienen
        //que derivar de esta página maestra, puede hacerlo por código
        //o usar la opción: Add Web Form using Master Page.
        //Cada página debe lucir como Pagina1.aspx pero con un mensaje
        //distinto indicando dónde se encuentra
    }
}