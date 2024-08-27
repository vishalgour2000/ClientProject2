using ClientProject.Models;
using ClientProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ClientProject.Controllers
{
    public class HomeController : Controller
    {
        private IClientRepository IClient;
        public HomeController(IClientRepository Iclient)
        {
            this.IClient = Iclient;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Product()
        {
            return View();
        }

        public IActionResult Product1()
        {
            return View();
        }

        public IActionResult details()
        {
            return View();
        }

        [HttpPost]
        public IActionResult formSubmit(FormSubmitViewModel model)
        {
            if (ModelState.IsValid)
            {
                Client obj = new Client
                {
                    name = model.name,
                    contactNumber = model.contactNumber,
                    emailAddress = model.emailAddress,
                    purpose = model.purpose
                };
                IClient.add(obj);
                return RedirectToAction("Product1");
            }
            return View();
        }
    }
}
