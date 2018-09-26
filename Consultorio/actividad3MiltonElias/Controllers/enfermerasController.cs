using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using actividad3MiltonElias.Models;

namespace actividad3MiltonElias.Controllers
{
    public class enfermerasController : Controller
    {
        private Model1 db = new Model1();

        // GET: enfermeras
        public ActionResult Index()
        {
            var enfermera = db.enfermera.Include(e => e.Medico);
            return View(enfermera.ToList());
        }

        // GET: enfermeras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            enfermera enfermera = db.enfermera.Find(id);
            if (enfermera == null)
            {
                return HttpNotFound();
            }
            return View(enfermera);
        }

        // GET: enfermeras/Create
        public ActionResult Create()
        {
            ViewBag.idmedico = new SelectList(db.Medico, "idmedico", "Nombre");
            return View();
        }

        // POST: enfermeras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idenfermera,Nombre,Apellido,Edad,Area,idmedico")] enfermera enfermera)
        {
            if (ModelState.IsValid)
            {
                db.enfermera.Add(enfermera);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idmedico = new SelectList(db.Medico, "idmedico", "Nombre", enfermera.idmedico);
            return View(enfermera);
        }

        // GET: enfermeras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            enfermera enfermera = db.enfermera.Find(id);
            if (enfermera == null)
            {
                return HttpNotFound();
            }
            ViewBag.idmedico = new SelectList(db.Medico, "idmedico", "Nombre", enfermera.idmedico);
            return View(enfermera);
        }

        // POST: enfermeras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idenfermera,Nombre,Apellido,Edad,Area,idmedico")] enfermera enfermera)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enfermera).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idmedico = new SelectList(db.Medico, "idmedico", "Nombre", enfermera.idmedico);
            return View(enfermera);
        }

        // GET: enfermeras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            enfermera enfermera = db.enfermera.Find(id);
            if (enfermera == null)
            {
                return HttpNotFound();
            }
            return View(enfermera);
        }

        // POST: enfermeras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            enfermera enfermera = db.enfermera.Find(id);
            db.enfermera.Remove(enfermera);
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
