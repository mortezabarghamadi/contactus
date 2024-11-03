using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactUs.Models;

namespace ContactUs.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index(int id)
        {
            ViewBag.message = id;
            ViewData["Message2"] = "Hello";

            return View();
        }
        public IActionResult Privacy(string name)
        {

            return View(model:name);
        }
        public IActionResult Messages(string name)
        {
            ViewData["namees"] = name;
            return View(DataBase.DataBase.Messages);
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("sda","Test Error");
                return View("Index", message);
            }
            if (message.PhoneNumber.Length == 11)
            {
                TempData["IsSuccess"] = true;
                DataBase.DataBase.Messages.Add(message);
            }
            return Redirect("/home/Messages");
        }
    }
}
