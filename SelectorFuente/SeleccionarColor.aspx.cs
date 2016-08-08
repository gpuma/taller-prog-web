using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//sin esta directiva no podemos manipular colores
using System.Drawing;

namespace SelectorFuente
{
    public partial class SeleccionarColor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void drpColores_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            //obtenemos la cadena de texto que indica el color seleccionado
            //también podríamos usar drpColores.SelectedItem.Value
            //porque en este caso ambos valores son iguales
            string color = drpColores.SelectedItem.Text;

            //recordemos que las cadenas de texto son CASE-SENSITIVE
            //lo que quiere decir que distinguen entre minúsculas y mayúsculas
            if (color == "Negro")
            {
                //.ForeColor es el color de la letra de nuestro label
                lblMensaje.ForeColor = Color.Black;
            }
            else if (color == "Rojo")
            {
                //los colores en .NET se especifican en inglés...
                lblMensaje.ForeColor = Color.Red;
            }
            else if (color == "Azul")
            {
                lblMensaje.ForeColor = Color.Blue;
            }
        }
    }
}