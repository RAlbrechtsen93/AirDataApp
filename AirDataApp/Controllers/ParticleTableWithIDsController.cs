using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AirDataApp.Models;

namespace AirDataApp.Controllers
{
    public class ParticleTableWithIDsController : Controller
    {
        private ParticleDataDbEntities1 db = new ParticleDataDbEntities1();

        // GET: ParticleTableWithIDs
        public ActionResult Index()
        {
            return View(db.ParticleTableWithIDs.ToList());
        }

        // GET: ParticleTableWithIDs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParticleTableWithID particleTableWithID = db.ParticleTableWithIDs.Find(id);
            if (particleTableWithID == null)
            {
                return HttpNotFound();
            }
            return View(particleTableWithID);
        }

        // GET: ParticleTableWithIDs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParticleTableWithIDs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DatoMaerke,StofNavn,Resultat")] ParticleTableWithID particleTableWithID)
        {
            if (ModelState.IsValid)
            {
                db.ParticleTableWithIDs.Add(particleTableWithID);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(particleTableWithID);
        }

        // GET: ParticleTableWithIDs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParticleTableWithID particleTableWithID = db.ParticleTableWithIDs.Find(id);
            if (particleTableWithID == null)
            {
                return HttpNotFound();
            }
            return View(particleTableWithID);
        }

        // POST: ParticleTableWithIDs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DatoMaerke,StofNavn,Resultat")] ParticleTableWithID particleTableWithID)
        {
            if (ModelState.IsValid)
            {
                db.Entry(particleTableWithID).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(particleTableWithID);
        }

        // GET: ParticleTableWithIDs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParticleTableWithID particleTableWithID = db.ParticleTableWithIDs.Find(id);
            if (particleTableWithID == null)
            {
                return HttpNotFound();
            }
            return View(particleTableWithID);
        }

        // POST: ParticleTableWithIDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ParticleTableWithID particleTableWithID = db.ParticleTableWithIDs.Find(id);
            db.ParticleTableWithIDs.Remove(particleTableWithID);
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
