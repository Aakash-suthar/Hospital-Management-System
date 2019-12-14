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
    public class BillsController : Controller
    {
        private masterEntities db = new masterEntities();

        // GET: Bills
        public ActionResult Index()
        {
            Bill b = new Bill();
            return View(b);
        }

        [HttpPost]
        public ActionResult Search(FormCollection f)
        {
            try
            {
                string p = f["searchtextbox"];
                int id = Convert.ToInt32(p);
                inpatient findp = db.inpatients.Where(t => t.patient_id == id).First();
                if (findp != null)
                {
                    int labcost = 0;
                    int roomcharge = 0;
                    List<lab> lablist = db.labs.Where(u => u.patient_id == findp.patient_id).ToList();
                    foreach(lab g in lablist)
                    {
                        labcost = labcost + g.test_cost;
                    }

                    room r = db.rooms.Where(y => y.patient_id == findp.patient_id).First();
                    DateTime d = findp.admission_date;
                    double days = (DateTime.Today - d).TotalDays;
                    if (days <= 0)
                    {
                        days = 1;
                    }
                    roomcharge = Convert.ToInt32(days*r.room_charge);

                    Bill b = new Bill();
                    b.PatientName = db.patients.Where(o => o.patient_Id == findp.patient_id).First().Name;
                    b.Patient_Id = findp.patient_id;
                    b.RoomCharge = roomcharge;
                    b.LabCharge = labcost;
                    b.DoctorName = db.doctors.Where(l => l.doctor_id == findp.doctor_assigned).First().doctor_name;
                    b.DaysAdmitted = days;
                    b.TotalCost = roomcharge + labcost;
                    return View("Index",b);
                }
                else
                {
                    ViewBag.Invalid = "No Data Found";
                    return View("Index", new Bill());
                }
            }
            catch
            {
                ViewBag.Invalid = "No Data Found";
                return View("Index",new Bill());
            }
        }




            // GET: Bills/Create
            public ActionResult Create()
        {
            return View();
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
