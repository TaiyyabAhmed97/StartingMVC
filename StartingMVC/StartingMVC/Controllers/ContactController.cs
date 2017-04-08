using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StartingMVC.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Haseeb()
        {
            ViewBag.message = "Your application description page.";
            return View();
        }
        public ActionResult Fayyaz()
        {
            ViewBag.message = "Your application description page.";
            return View();
        }
        public ActionResult Taiyyab()
        {
            ViewBag.message = "Your application description page.";
            return View();
        }
        public ActionResult Rizwan()
        {
            ViewBag.message = "Your application description page.";
            return View();
        }
        public ActionResult Amer()
        {
            ViewBag.message = "Your application description page.";
            return View();
        }
        public ActionResult Zaki()
        {
            ViewBag.message = "Your application description page.";
            return View();
        }
    }
}