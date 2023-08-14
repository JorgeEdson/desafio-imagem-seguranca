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

        
        public ActionResult Index()
        {
            return View(db.Dispositivos.ToList());
        }

        
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

        
        public ActionResult Create()
        {
            return View();
        }

        
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

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Dispositivo dispositivo = db.Dispositivos.Find(id);
            db.Dispositivos.Remove(dispositivo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AbrirFechar(int endereco)
        {
            if (ModelState.IsValid)
            {
                var service = new DesafioService.DesafioServiceClient();
                var response = service.AbrirFechar(endereco);
                TempData["AlertMessage"] = response;
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ManterAberto(int endereco)
        {
            if (ModelState.IsValid)
            {
                var service = new DesafioService.DesafioServiceClient();
                var response = service.ManterAberto(endereco);
                TempData["AlertMessage"] = response;
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Fechar(int endereco)
        {
            if (ModelState.IsValid)
            {
                var service = new DesafioService.DesafioServiceClient();
                var response = service.Fechar(endereco);
                TempData["AlertMessage"] = response;
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}
