using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MathPersonMVCProject.Controllers
{
    public class PersonController : Controller
    {
        // Return the age of the person
        public ContentResult Age(int year, int month, int date)
        {
            return Content(Convert.ToString(DateTime.Today.Year - year));
        }

        //Return full name
        public ContentResult FullName(string firstname, string lastname)
        {
            return Content(firstname + " " + lastname);
        }
    }
}