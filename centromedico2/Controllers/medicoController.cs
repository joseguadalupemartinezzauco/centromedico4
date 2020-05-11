using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using centromedico2.Data;
using centromedico2.Models;

namespace centromedico2.Controllers
{
    public class medicoController : Controller
    {
        private centromedico2Context db = new centromedico2Context();
        // GET: medico/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: citasses/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,apellido,correo,telefono,especialidad,citobservaciones")] medicos medicos)
        {
            if (ModelState.IsValid)
            {
                db.medicos.Add(medicos);
                db.SaveChanges();
                return RedirectToAction("AgregarMedico");
            }

            return View(medicos);
        }

        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}