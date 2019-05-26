using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OfficialWebsite.Controllers
{
    public class FireGenerationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Intro()
        {
            return View();
        }

        public IActionResult Character(string role)
        {
            ViewBag.PartialPath = string.Format("_{0}", role);

            return View();
        }

        public IActionResult Timeline()
        {
            return View();
        }

        public IActionResult Season()
        {
            return View();
        }

        //public IActionResult Chapter()
        //{
        //    return View();
        //}

        public IActionResult Conception()
        {
            return View();
        }

        public IActionResult ConceptionContent(long id)
        {
            return PartialView();
        }
    }
}