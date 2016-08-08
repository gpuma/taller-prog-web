using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConversionMoneda
{
    public partial class ConversionHTML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnOk_ServerClick(object sender, EventArgs e)
        {
            //no olvidemos hacer la conversión
            double soles = Convert.ToDouble(txtSoles.Value);
            double dolares = soles * 0.30;

            //InnerText es la propiedad que nos permite cambiar el texto de un <div>
            Resultado.InnerText = soles + " soles son " + dolares + " dólares";
        }
    }
}