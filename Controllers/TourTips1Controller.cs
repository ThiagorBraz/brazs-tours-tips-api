using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BrazsToursTipsAPI.Models;

namespace BrazsToursTipsAPI.Controllers
{
    public class TourTips1Controller : Controller
    {
        private BrazsToursTipsDBConToString db = new BrazsToursTipsDBConToString();

        // GET: TourTips1
        public ActionResult Index()
        {
            return View(db.TourTips.ToList());
        }

        // GET: TourTips1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourTip tourTip = db.TourTips.Find(id);
            if (tourTip == null)
            {
                return HttpNotFound();
            }
            return View(tourTip);
        }

        // GET: TourTips1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TourTips1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TourTipId,TourName,TourTip1")] TourTip tourTip)
        {
            if (ModelState.IsValid)
            {
                db.TourTips.Add(tourTip);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tourTip);
        }

        // GET: TourTips1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourTip tourTip = db.TourTips.Find(id);
            if (tourTip == null)
            {
                return HttpNotFound();
            }
            return View(tourTip);
        }

        // POST: TourTips1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TourTipId,TourName,TourTip1")] TourTip tourTip)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tourTip).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tourTip);
        }

        // GET: TourTips1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourTip tourTip = db.TourTips.Find(id);
            if (tourTip == null)
            {
                return HttpNotFound();
            }
            return View(tourTip);
        }

        // POST: TourTips1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TourTip tourTip = db.TourTips.Find(id);
            db.TourTips.Remove(tourTip);
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
