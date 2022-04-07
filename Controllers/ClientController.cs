using EveriHoldings;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EveriHoldings1.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Test()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Submit()
        {
            var myClient = new ClientModel();
            if (ModelState.IsValid)
            {
                ViewBag.Message = "testMessage";
                myClient.DriversLicense = "P123456789012";
                myClient.FirstName = "Homer";
                myClient.LastName = "Simpson";
                myClient.DateOfBirth = DateTime.UtcNow;
                myClient.MiddleName = "J";
                myClient.AnnualSalary = 1.0M;
                myClient.MonthlySpending = 0.001M;
            }
            return View(myClient);
        }
    }
}