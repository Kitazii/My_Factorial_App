using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KBurns_Task1.Models;

namespace KBurns_Task1.Controllers
{
    public class FactorialController : Controller
    {
        // Create a factorial form
        [HttpGet]
        public ActionResult CreateFactorial()
        {
            return View();
        }

        //posts form
        [HttpPost]
        public ActionResult CreateFactorial(Factorial model) //overloaded method for posting the model

        {
            if(ModelState.IsValid)
            {
                model.FactorialLogic();
                model.FormatLargeNumberWithCommas(model.FactorialCalculation);
            }
            return View(model);
        }

    }
}