using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M2NCore_HelloMVC.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            var email = form["email"].ToString();
            var password = form["password"].ToString();

            if (email == "luis@qboinstitute.com" && password == "123456")
            {
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Login");

        }


    }
}
