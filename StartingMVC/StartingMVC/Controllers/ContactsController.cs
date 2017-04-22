using System;
using StartingMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StartingMVC.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        public ActionResult Index(string Username)
        {
            Profile viewProfile = new Profile();
            viewProfile.Username = Username;
            viewProfile.FirstName = "Jooe";
            viewProfile.LastName = "Schmoe";

            return View();
        }
    }
}