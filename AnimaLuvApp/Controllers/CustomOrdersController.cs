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
    public class CustomOrdersController : Controller
    {
        private AnimaLuvDataEntities db = new AnimaLuvDataEntities();

        // GET: CustomOrders
        public ActionResult Index()
        {
            var customOrders = db.CustomOrders.Include(c => c.Animal).Include(c => c.Color).Include(c => c.Material).Include(c => c.Outfit).Include(c => c.Size).Include(c => c.Stuffing);
            return View(customOrders.ToList());
        }

        // GET: CustomOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomOrder customOrder = db.CustomOrders.Find(id);
            if (customOrder == null)
            {
                return HttpNotFound();
            }
            return View(customOrder);
        }

        // GET: CustomOrders/Create
        public ActionResult Create()
        {
            ViewBag.AnimalID = new SelectList(db.Animals, "AnimalID", "Name");
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Name");
            ViewBag.MaterialID = new SelectList(db.Materials, "MaterialID", "Name");
            ViewBag.OutfitID = new SelectList(db.Outfits, "OutfitID", "Name");
            ViewBag.SizeID = new SelectList(db.Sizes, "SizeID", "Name");
            ViewBag.StuffingID = new SelectList(db.Stuffings, "StuffingID", "Name");
            return View();
        }

        // POST: CustomOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomOrderID,Name,AnimalID,SizeID,ColorID,MaterialID,StuffingID,OutfitID,OrderDate")] CustomOrder customOrder)
        {
            if (ModelState.IsValid)
            {
                customOrder.OrderDate = DateTime.Now;
                db.CustomOrders.Add(customOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AnimalID = new SelectList(db.Animals, "AnimalID", "Name", customOrder.AnimalID);
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Name", customOrder.ColorID);
            ViewBag.MaterialID = new SelectList(db.Materials, "MaterialID", "Name", customOrder.MaterialID);
            ViewBag.OutfitID = new SelectList(db.Outfits, "OutfitID", "Name", customOrder.OutfitID);
            ViewBag.SizeID = new SelectList(db.Sizes, "SizeID", "Name", customOrder.SizeID);
            ViewBag.StuffingID = new SelectList(db.Stuffings, "StuffingID", "Name", customOrder.StuffingID);
            return View(customOrder);
        }

        // GET: CustomOrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomOrder customOrder = db.CustomOrders.Find(id);
            if (customOrder == null)
            {
                return HttpNotFound();
            }
            ViewBag.AnimalID = new SelectList(db.Animals, "AnimalID", "Name", customOrder.AnimalID);
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Name", customOrder.ColorID);
            ViewBag.MaterialID = new SelectList(db.Materials, "MaterialID", "Name", customOrder.MaterialID);
            ViewBag.OutfitID = new SelectList(db.Outfits, "OutfitID", "Name", customOrder.OutfitID);
            ViewBag.SizeID = new SelectList(db.Sizes, "SizeID", "Name", customOrder.SizeID);
            ViewBag.StuffingID = new SelectList(db.Stuffings, "StuffingID", "Name", customOrder.StuffingID);
            return View(customOrder);
        }

        // POST: CustomOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomOrderID,Name,AnimalID,SizeID,ColorID,MaterialID,StuffingID,OutfitID,OrderDate")] CustomOrder customOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AnimalID = new SelectList(db.Animals, "AnimalID", "Name", customOrder.AnimalID);
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Name", customOrder.ColorID);
            ViewBag.MaterialID = new SelectList(db.Materials, "MaterialID", "Name", customOrder.MaterialID);
            ViewBag.OutfitID = new SelectList(db.Outfits, "OutfitID", "Name", customOrder.OutfitID);
            ViewBag.SizeID = new SelectList(db.Sizes, "SizeID", "Name", customOrder.SizeID);
            ViewBag.StuffingID = new SelectList(db.Stuffings, "StuffingID", "Name", customOrder.StuffingID);
            return View(customOrder);
        }

        // GET: CustomOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomOrder customOrder = db.CustomOrders.Find(id);
            if (customOrder == null)
            {
                return HttpNotFound();
            }
            return View(customOrder);
        }

        // POST: CustomOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomOrder customOrder = db.CustomOrders.Find(id);
            db.CustomOrders.Remove(customOrder);
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
