using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Desafio.WebApp;

namespace Desafio.WebApp.Controllers
{
    public class DispositivoController : Controller
    {
        private WebAppContext db = new WebAppContext();

        // GET: Dispositivo
        public ActionResult Index()
        {
            return View(db.Dispositivos.ToList());
        }

        // GET: Dispositivo/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dispositivo dispositivo = db.Dispositivos.Find(id);
            if (dispositivo == null)
            {
                return HttpNotFound();
            }
            return View(dispositivo);
        }

        // GET: Dispositivo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dispositivo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Endereco")] Dispositivo dispositivo)
        {
            if (ModelState.IsValid)
            {
                dispositivo.Id = Guid.NewGuid();
                db.Dispositivos.Add(dispositivo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dispositivo);
        }

        // GET: Dispositivo/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dispositivo dispositivo = db.Dispositivos.Find(id);
            if (dispositivo == null)
            {
                return HttpNotFound();
            }
            return View(dispositivo);
        }

        // POST: Dispositivo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Endereco")] Dispositivo dispositivo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dispositivo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dispositivo);
        }

        // GET: Dispositivo/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dispositivo dispositivo = db.Dispositivos.Find(id);
            if (dispositivo == null)
            {
                return HttpNotFound();
            }
            return View(dispositivo);
        }

        // POST: Dispositivo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Dispositivo dispositivo = db.Dispositivos.Find(id);
            db.Dispositivos.Remove(dispositivo);
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
