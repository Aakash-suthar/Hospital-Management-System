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
    public class patientsController : Controller
    {
        private masterEntities db = new masterEntities();

        // GET: patients
        public ActionResult Index()
        {
            return View(db.patients.ToList());
        }

        [HttpPost]
        public ActionResult Search(FormCollection f)
        {
            int option = Convert.ToInt32(f["options"]);
            string p = f["searchtextbox"];

            try
            {
                switch (option)
                {
                    case 0:
                        return View("Index", db.patients.ToList());
                    case 1:
                        int y = Convert.ToInt32(p);
                        return View("Index", db.patients.Where(p1 => p1.patient_Id == y).ToList());
                    case 2:
                        return View("Index", db.patients.Where(p1 => p1.Name.ToLower() == p.ToLower()).ToList());
                    default:
                        return View("Index", db.patients.ToList());
                }
            }
            catch
            {
                return View("Index", db.patients.ToList());
            }


            //return View(db.Patients.Where(p => p.DoctorId == name).ToList());
        }

        // GET: patients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: patients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "patient_Id,Name,Age,Weight,Gender,Address,PhoneNo")] patient patient)
        {
            if (ModelState.IsValid)
            {
                db.patients.Add(patient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patient);
        }

        // GET: patients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            patient patient = db.patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // POST: patients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "patient_Id,Name,Age,Weight,Gender,Address,PhoneNo")] patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patient);
        }

        // GET: patients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            patient patient = db.patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }

        // POST: patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            patient patient = db.patients.Find(id);
            db.patients.Remove(patient);
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
