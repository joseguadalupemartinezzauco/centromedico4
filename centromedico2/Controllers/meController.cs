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
    public class meController : Controller
    {
        private centromedico2Context db = new centromedico2Context();

        // GET: me
        public ActionResult Index() => View(db.me.ToList());

        // GET: me/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            me me = db.me.Find(id);
            if (me == null)
            {
                return HttpNotFound();
            }
            return View(me);
        }

        // GET: me/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: me/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,apellido,corre,telefono,especialidad")] me me)
        {
            if (ModelState.IsValid)
            {
                db.me.Add(me);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(me);
        }

        // GET: me/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            me me = db.me.Find(id);
            if (me == null)
            {
                return HttpNotFound();
            }
            return View(me);
        }

        // POST: me/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,apellido,corre,telefono,especialidad")] me me)
        {
            if (ModelState.IsValid)
            {
                db.Entry(me).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(me);
        }

        // GET: me/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            me me = db.me.Find(id);
            if (me == null)
            {
                return HttpNotFound();
            }
            return View(me);
        }

        // POST: me/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            me me = db.me.Find(id);
            db.me.Remove(me);
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
