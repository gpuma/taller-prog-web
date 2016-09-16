using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica7
{
    public partial class ControlesLista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //si es postback no hacemos nada
            if (IsPostBack)
                return;
            
            //si es la primera vez que se carga la página
            //cargamos los datos
            CargarLenguajes();
        }

        //En este método nos encargamos de hacer el binding
        public void CargarLenguajes()
        {
            //leemos los datos desde nuestro modelo
            drpLenguajes.DataSource = Modelo.ObtenerLenguajes();

            //TODO: Actividad 4: Actualmente si carga la página se mostrará el nombre
            //de la clase ya que no hemos especificado qué propiedad se debe mostrar.
            //Añada el código necesario para que muestre el nombre del lenguaje
            //y como valor utilice el código del lenguaje.
            //Revise las propiedades DataTextField y DataValueField de ListBox


            drpLenguajes.DataBind();

            //TODO: Actividad 5: Haga lo mismo que arriba pero para el ListBox lstLengDisponibles
            //TODO: Actividad 6: Haga lo mismo que arriba pero para el CheckBoxList chkLeng

        }

        public void drpLenguajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: Actividad 7: Añada el código y control necesarios para que cuando se seleccione
            //otro lenguaje me muestre lo siguiente: "Ud. ha seleccionado el lenguaje C# con código 1".
            //TIP: Utilice String.Format()
            //TIP: Revise las propiedades de DropDownList.SelectedItem (item seleccionado)
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            //TODO: Actividad 8: Añada una validación al comienzo en la que el método actual
            //finalice (return) SI no hay ningún item seleccionado o si no quedan items
            //TIP: Utilice ListBox.Items.Count para obtener el número de items
            //TIP: Utilice ListBox.SelectedItem para ver si hay algún item seleccionado


            //obtenemos el item seleccionado por el usuario
            ListItem itemSelec = lstLengDisponibles.SelectedItem;

            //le cambiamos su propiedad Selected a False porque sino
            //resultaremos con un ListBox con múltiples valores seleccionados
            //y como no tiene opción de selección múltiple resulta en error
            itemSelec.Selected = false;

            //lo quitamos de la lista de lenguajes disponibles
            lstLengDisponibles.Items.Remove(itemSelec);

            //lo agregamos a la lsita de lenguajes conocidos
            lstLengConocidos.Items.Add(itemSelec);
        }

        protected void btnQuitar_Click(object sender, EventArgs e)
        {
            //TODO: Actividad 9: Realice la opción inversa del método btnAgregar_Click.
            //Quite elementos de lstLengConocidos y regréselos a lstLengDisponibles
        }

        protected void chkLeng_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: Actividad 10: En esta sección tiene que mostrarle al usuario
            //cuáles son los lenguajes que ha seleccionado. Es decir, si le dio check
            //a C# y Haskell debería mostrarle un mensaje como: "Usted ha seleccionado C#, Haskell"

            //Para esta tarea deberá emplear un bucle, ya se le muestra la estructura de
            //un bucle foreach, que es una versión simplificada del FOR, que no utiliza índices
            //En este bucle Ud. deberá iterar por cada Item del CheckBoxList, verificar
            //si ha sido seleccionado, y si es así, agregar el lenguaje a su mensaje final

            //Para poder agregar mensajes de manera iterativa, puede utilizar
            // el operador de concatenación e incremento de cadenas (+=)
            //Por ejemplo, si tengo lo siguiente:
                //string msj = "Adiós,";
            //Si agrego la sgte instrucción
                //msj += "mundo cruel";
            //msj ahora contendría "Adiós,mundo cruel"

            string mensaje = "Usted ha seleccionado: ";
            foreach(ListItem item in chkLeng.Items)
            {
                //AQUÍ SU CÓDIGO
            }

            lblCheck.Text = mensaje;

            //TODO: PUNTO EXTRA
            //Si no hay ningún item seleccionado (o cuando se deseleccionen todos los items)
            //muestre un mensaje que lo diga
        }
    }
}