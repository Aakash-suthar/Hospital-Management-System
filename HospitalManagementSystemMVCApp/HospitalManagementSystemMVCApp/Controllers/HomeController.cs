using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HospitalManagementSystemMVCApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logout()
        {
            //Session["Username"] = null;
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}