using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonajesEjemplo.Controllers
{
    //por defecto la primera sección de la ruta se mapea al controlador del mismo nombre
    //y la segunda sección se mapea a una acción dentro de dicho controlador
    //en este caso sería: ejemplo.com/Home/Index
    public class HomeController : Controller
    {
        //Los métodos que retornan ActionResult se llaman "métodos de acción"
        //Los métodos de acción proveen respuestas que pueden ser usadas por el navegador
        public ActionResult Index()
        {
            //aquí pondremos la cadena que queremos retornar
            object name = "Gustavo";
            return View(name);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
