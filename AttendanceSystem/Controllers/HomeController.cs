using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projev2.Models;

namespace projev2.Controllers
{
    public class HomeController : Controller
    {



        public ActionResult home()
        {
            return View();
        }

        public ActionResult about()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult contact()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Form()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Form(contact ct)
        {
            if (ModelState.IsValid)
            {
                ViewBag.name = ct.Name;
                ViewBag.name = ct.SurName;
                ViewBag.name = ct.Email;
                ViewBag.name = ct.Subject;
                ViewBag.name = ct.Message;
                return View("ContactResult",ct);
            }
            else
            {
                return View();
            }
        }


        public ActionResult login()
        {
            ViewBag.Message = "Your login page.";

            return View();
        }

        public ActionResult studentAttendance()
        {
            ViewBag.Message = "Your student attendance page.";

            return View();
        }
        public ActionResult teacherAttendance()
        {
            ViewBag.Message = "Your teacher attendance page.";

            return View();
        }
        public ActionResult teacherPast()
        {
            ViewBag.Message = "Your teacher past page.";

            return View();
        } 
    }
}