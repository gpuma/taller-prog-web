using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multiplicador
{
    public partial class Multiplicacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected int Multiplicar(int a, int b)
        {
            return a * b;
        }

        protected void btnCalcular_OnClick(object sender, EventArgs e)
        {
            //obtenemos el texto de nuestras cajas de texto
            //y lo convertimos a entero
            int nro1 = Convert.ToInt32(txtNro1.Text);
            int nro2 = Convert.ToInt32(txtNro2.Text);

            //usamos nuestra función
            int resultado = Multiplicar(nro1, nro2);

            //mostramos el resultado en nuestro label
            lblResultado.Text = "El resultado es: " + resultado;
        }
    }
}