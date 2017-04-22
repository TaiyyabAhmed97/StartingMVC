using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StartingMVC.Models;
using System.Web.Mvc;

namespace StartingMVC.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index1(string id)
        {
            Profile lol = new Profile();
            //lol.Username = Username
            switch(id)
            {
                case "taiyyab97":
                    lol.Username = id;
                    lol.FirstName = "Taiyyab";
                    lol.LastName = "Ahmed";
                    break;

                case "Haseeb56":
                    lol.Username = id;
                    lol.FirstName = "Haseeb";
                    lol.LastName = "Mo";
                    break;

                case "Riz00":
                    lol.Username = id;
                    lol.FirstName = "Rizwan";
                    lol.LastName = "Hassan";
                    break;
            }



            return View(lol);
        }
    }
}