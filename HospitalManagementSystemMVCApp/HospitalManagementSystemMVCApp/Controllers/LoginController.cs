using HospitalManagementSystemMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
/// <summary>
/// Login logic and start Page
/// </summary>

namespace HospitalManagementSystemMVCApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login()
        {

            string u = Request["Username"];
            string p = Request["Password"];
            if (AuthUser(u,p))
            {
                //Session["Username"] = name;
                FormsAuthentication.SetAuthCookie(u,true);
                return RedirectToAction("Index", "Patients");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public bool AuthUser(string username, string password)
        {
            masterEntities h = new masterEntities();
            try
            {
                if (username != "" && password != null)
                {
                    logintable l = h.logintables.Where(p => p.username == username && p.pass == password).Single();
                    if (l != null)
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            catch { return false; }
        }
       
    }
}