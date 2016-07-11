using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AnimaLuvApp.Models;

namespace AnimaLuvApp.Controllers
{
    public class StuffingsController : Controller
    {
        private AnimaLuvDataEntities db = new AnimaLuvDataEntities();

        // GET: Stuffings
        public ActionResult Index()
        {
            return View(db.Stuffings.ToList());
        }

        // GET: Stuffings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stuffing stuffing = db.Stuffings.Find(id);
            if (stuffing == null)
            {
                return HttpNotFound();
            }
            return View(stuffing);
        }

        // GET: Stuffings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stuffings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StuffingID,Name,BabySafe")] Stuffing stuffing)
        {
            if (ModelState.IsValid)
            {
                db.Stuffings.Add(stuffing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stuffing);
        }

        // GET: Stuffings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stuffing stuffing = db.Stuffings.Find(id);
            if (stuffing == null)
            {
                return HttpNotFound();
            }
            return View(stuffing);
        }

        // POST: Stuffings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StuffingID,Name,BabySafe")] Stuffing stuffing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stuffing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stuffing);
        }

        // GET: Stuffings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stuffing stuffing = db.Stuffings.Find(id);
            if (stuffing == null)
            {
                return HttpNotFound();
            }
            return View(stuffing);
        }

        // POST: Stuffings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stuffing stuffing = db.Stuffings.Find(id);
            db.Stuffings.Remove(stuffing);
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
