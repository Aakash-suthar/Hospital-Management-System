using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HospitalManagementSystemMVCApp.Models;

namespace HospitalManagementSystemMVCApp.Controllers
{
    public class labsController : Controller
    {
        private masterEntities db = new masterEntities();

        // GET: labs
        public ActionResult Index()
        {
            return View(db.labs.ToList());
        }

        // GET: labs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lab lab = db.labs.Find(id);
            if (lab == null)
            {
                return HttpNotFound();
            }
            return View(lab);
        }

        // GET: labs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: labs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "lab_id,patient_id,test_name,test_cost")] lab lab)
        {
            if (ModelState.IsValid)
            {
                db.labs.Add(lab);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lab);
        }

        // GET: labs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lab lab = db.labs.Find(id);
            if (lab == null)
            {
                return HttpNotFound();
            }
            return View(lab);
        }

        // POST: labs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "lab_id,patient_id,test_name,test_cost")] lab lab)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lab).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lab);
        }

        // GET: labs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            lab lab = db.labs.Find(id);
            if (lab == null)
            {
                return HttpNotFound();
            }
            return View(lab);
        }

        // POST: labs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            lab lab = db.labs.Find(id);
            db.labs.Remove(lab);
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
