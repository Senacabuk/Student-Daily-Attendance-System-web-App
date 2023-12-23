using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using projev2.Data;
using projev2.Models;
using System.Web.Security;

namespace projev2.Controllers
{
    public class SecurityController : Controller
    {
        private projev2Context db = new projev2Context();

        // GET: Security
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Login(login login)
        {
            var loginInDb = db.Users.FirstOrDefault(x => x.username == login.username && x.password == login.password);
            if (loginInDb != null)
            {

                FormsAuthentication.SetAuthCookie(loginInDb.username, false);
                return RedirectToAction("login", "loginsController");
            }
            else
            {
                ViewBag.Message = "Invalid Username or Password";
            }

        }
    }
}