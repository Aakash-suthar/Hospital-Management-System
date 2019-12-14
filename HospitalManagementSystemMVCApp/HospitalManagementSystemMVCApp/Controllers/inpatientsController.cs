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
    public class inpatientsController : Controller
    {
        private masterEntities db = new masterEntities();

        // GET: inpatients
        public ActionResult Index()
        {
            return View(db.inpatients.ToList());
        }

        // GET: inpatients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            inpatient inpatient = db.inpatients.Find(id);
            if (inpatient == null)
            {
                return HttpNotFound();
            }
            return View(inpatient);
        }

        // GET: inpatients/Create
        public ActionResult Create()
        {
            ViewBag.doctors = db.doctors.ToList();
            ViewBag.roomlist = db.rooms.Where(y => y.patient_id==null).ToList();
            return View();
        }

        // POST: inpatients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "patient_id,admission_date,doctor_assigned,disease,room_assigned")] inpatient inpatient)
        {
            try
            {
              
            if (inpatient.admission_date > DateTime.Now)
            {
                ModelState.AddModelError("admission_date", "Date should be less than todays date.");
            }
           
                if (db.inpatients.Where(u => u.patient_id==inpatient.patient_id).First()!=null)
                {

                }
          
            
            if (ModelState.IsValid)
            {
                db.inpatients.Add(inpatient);
                 db.rooms.Where(r => r.room_id == inpatient.room_assigned).First().patient_id = inpatient.patient_id;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
                ViewBag.roomlist = db.rooms.ToList();
                ViewBag.doctors = db.doctors.ToList();
            return View(inpatient);
            }

            catch
            {
                ModelState.AddModelError("patient_id", "Patient already inpatient.");
                ViewBag.roomlist = db.rooms.ToList();
                ViewBag.doctors = db.doctors.ToList();

                return View(inpatient);
            }
        }

        // GET: inpatients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            inpatient inpatient = db.inpatients.Find(id);
            if (inpatient == null)
            {
                return HttpNotFound();
            }
            return View(inpatient);
        }

        // POST: inpatients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "patient_id,admission_date,doctor_assigned,disease,room_assigned")] inpatient inpatient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inpatient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inpatient);
        }

        // GET: inpatients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            inpatient inpatient = db.inpatients.Find(id);
            if (inpatient == null)
            {
                return HttpNotFound();
            }
            return View(inpatient);
        }

        // POST: inpatients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            inpatient inpatient = db.inpatients.Find(id);

            db.inpatients.Remove(inpatient);
            try
            {
                db.rooms.Where(i => i.patient_id == inpatient.patient_id).First().patient_id = null;

            }
            catch { }
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
