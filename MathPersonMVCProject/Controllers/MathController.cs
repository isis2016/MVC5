using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MathPersonMVCProject.Controllers
{
    public class MathController : Controller
    {
        // Return the sum of two interger numbers a and b
        public ContentResult Add(int a, int b)
        {
            return Content(Convert.ToString(a + b));
        }

        //Return the square of an integer number n
        public ContentResult Square(int n)
        {
            return Content(Convert.ToString(n * n));
        }
    }
}