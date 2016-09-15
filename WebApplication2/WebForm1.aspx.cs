using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<Persona> usuarios;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Page.IsPostBack)
            //    return;
            usuarios = new List<Persona>()
                            {
                                new Persona() { DNI = "12312", Nombres = "Gustavo" },
                                new Persona() { DNI = "54564", Nombres = "Hernando" },
                                new Persona() { DNI = "6666", Nombres = "Julian" }
                            };
            lst.DataSource = usuarios;
            lst.DataTextField = "Nombres";
            lst.DataValueField = "DNI";
            lst.DataBind();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            usuarios.Add(new Persona() { DNI = "666", Nombres = "MC Ride" });
            lst.DataBind();
        }
    }
}