using Little_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Little_project.Controllers
{
    public class HomeController : Controller
    {


        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
            Repository.AddResponse(guestResponse);
            return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }
        
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Response.Where(r => r.willAttend == true));
        }
    }
}
