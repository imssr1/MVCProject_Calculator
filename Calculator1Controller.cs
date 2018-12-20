using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace watertank.Controllers
{
    public class Calculator1Controller : Controller
    {
        // GET: Calculator1
        [HttpGet]
        public ActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculator(int? num1, int? num2, string command)
        {
            if (command == "add")
            {
                int? sum = num1 + num2;
                ViewBag.sum = sum;
            }
            if (command == "sub")
            {
                int? sum = num1 - num2;
                ViewBag.sum = sum;
            }
            if (command == "mul")
            {
                int? sum = num1 * num2;
                ViewBag.sum = sum;
            }
            if (command == "div")
            {
                int? sum = num1 / num2;
                ViewBag.sum = sum;
            }

            ViewBag.num1 = num1;
            ViewBag.num2 = num2;
            
            return View();
        }
    }
}