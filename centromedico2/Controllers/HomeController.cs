using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace centromedico2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AgregarCita()
        {
            return View();
        }
        public ActionResult citas()
        {
            return View();
        }
        public ActionResult consultorios()
        {
            return View();
        }
        public ActionResult especialidades()
        {
            return View();
        }
        public ActionResult medicos()
        {
            return View();
        }
        public ActionResult pacientes()
        {
            return View();
        }
        public ActionResult reportes()
        {
            return View();
        }
        public ActionResult usuarios()
        {
            return View();
        }
    }
}