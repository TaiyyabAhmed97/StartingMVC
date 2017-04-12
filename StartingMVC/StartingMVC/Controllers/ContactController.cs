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
            return View();
        }
        public ActionResult Taiyyab()
        {
            return View();
        }
        public ActionResult Rizwan()
        {
            return View();
        }
        public ActionResult Amer()
        {
            return View();
        }
    
    }
}