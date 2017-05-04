using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SCCPetsMVC.Models;

namespace SCCPetsMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        // GET: Contact
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Customer customer)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", customer);
            }
            else
            {
                // There is a validation error.
                return View();
            }
        }
    }
}