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
    }
}