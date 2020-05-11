using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using centromedico2.Data;
using centromedico2.Models;

namespace centromedico2.Controllers
{
    public class citassesController : Controller
    {
        private centromedico2Context db = new centromedico2Context();

        // GET: citasses
        public ActionResult Index()
        {
            return View(db.citasses.ToList());
        }

        // GET: citasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            citass citass = db.citasses.Find(id);
            if (citass == null)
            {
                return HttpNotFound();
            }
            return View(citass);
        }

        // GET: citasses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: citasses/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,citfecha,cithora,citPaciente,citMedico,citConsultorio,citestado,citobservaciones")] citass citass)
        {
            if (ModelState.IsValid)
            {
                db.citasses.Add(citass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(citass);
        }

        // GET: citasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            citass citass = db.citasses.Find(id);
            if (citass == null)
            {
                return HttpNotFound();
            }
            return View(citass);
        }

        // POST: citasses/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,citfecha,cithora,citPaciente,citMedico,citConsultorio,citestado,citobservaciones")] citass citass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(citass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(citass);
        }

        // GET: citasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            citass citass = db.citasses.Find(id);
            if (citass == null)
            {
                return HttpNotFound();
            }
            return View(citass);
        }

        // POST: citasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            citass citass = db.citasses.Find(id);
            db.citasses.Remove(citass);
            db.SaveChanges();
            return RedirectToAction("Index");
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
