//Objetivos
//- Usar ViewState
//- Validar entrada
//- Detectar Postbacks
//- Entender String.Format()

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConversionMoneda_v2
{
    public partial class Convertidor : System.Web.UI.Page
    {
        //La clave de este ejercicio es el ViewState, que en términos de
        //estructura de datos es un Diccionario
        //Un diccionario nos sirve para relacionar pares de llaves y valores
        //en nuestro caso vamos a relacionar cada código de una moneda
        //por ejemplo "AUD" con su valor equivalente en soles (0.39)
        //de esta manera podemos, simplemente con el código respectivo,
        //extraer el valor que necesitamos para la conversión
        //sin necesidad de programar lógica adicional
        protected void Page_Load(object sender, EventArgs e)
        {
            //solo necesitamos cargar estos valores en memoria una sola vez
            //es decir, cuando se carga la página por primera vez
            if (!Page.IsPostBack)
            {
                ViewState["AUD"] = 0.39;
                ViewState["JPY"] = 30.83;
                ViewState["THB"] = 10.52;
                ViewState["EUR"] = 0.27;
            }
        }

        protected void btnConvertir_OnClick(object sender, EventArgs e)
        {
            //e.g. AUD
            string codigoMoneda = drpMoneda.SelectedItem.Value;
            //e.g. Dolar australiano
            string nombreMoneda = drpMoneda.SelectedItem.Text;

            //antes de hacer la conversión validamos
            double soles;
            //TryParse() es un método que nos permite hacer la conversión de un
            //tipo a otro, la ventaja es de que nos avisa si es que no se pudo
            //convertir, en vez de que falle nuestro programa
            //el segundo argumento es donde se va a guardar el resultado
            //de la conversión si es que fue exitosa
            //luego discutiremos la razón por la cual soles tiene un comando 'out'
            bool seConvirtio = Double.TryParse(txtSoles.Text, out soles);
            if (!seConvirtio)
            {
                lblResultado.Text = "El valor indicado no es un número válido";
                return;
            }
            
            //necesitamos hacer un Cast (Conversión de tipos de datos)
            //porque el ViewState guarda todos sus valores como Object
            double valorParaConvertir = (double)ViewState[codigoMoneda];
            double resultado = soles * valorParaConvertir;

            //Cuando usamos String.Format(), los símbolos del tipo {n}, donde n es un número
            //representan la posición donde se va insertar algún argumento, los argumentos
            //se especifican en comas y su orden es el orden en el que fueron especificados
            //e.g. soles es 0, resultado es 1 y nombreMoneda es 2
            lblResultado.Text = String.Format("{0} soles = {1} {2}", soles, resultado, nombreMoneda);
        }
    }
}