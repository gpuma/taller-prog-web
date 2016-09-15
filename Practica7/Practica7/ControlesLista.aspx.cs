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

        public void CargarLenguajes()
        {
            //leemos los datos desde nuestro modelo
            drpLenguajes.DataSource = Modelo.ObtenerLenguajes();

            //TODO: Actividad X: Actualmente si carga la página se mostrará el nombre
            //de la clase ya que no hemos especificado qué propiedad se debe mostrar.
            //Añada el código necesario para que muestre el nombre del lenguaje
            //y como valor utilice el código del lenguaje.
            //Revise las propiedades DataTextField y DataValueField de ListBox

            drpLenguajes.DataBind();
        }

        public void drpLenguajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: Actividad X: Añada el código y control necesarios para que cuando se seleccione
            //otro lenguaje me muestre lo siguiente: "Ud. ha seleccionado el lenguaje C# con código 1".
            //TIP: Utilice String.Format()
            //TIP: Revise las propiedades de DropDownList.SelectedItem (item seleccionado)
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            //var item = lstLengDisponibles.SelectedItem;
            //lstLengDisponibles.Items.Remove(item);
            //lstLengDisponibles.SelectedIndex = -1;

            //item.Selected = false;
            //lstLengConocidos.Items.Add(item);
        }
    }
}