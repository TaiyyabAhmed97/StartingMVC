using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StartingMVC.Models
{
    public class Profile
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string email { get; set; }
        public string gender { get; set; }
    }
}