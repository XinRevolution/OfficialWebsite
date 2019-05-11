﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficialWebsite.Models.Constant;

namespace OfficialWebsite.Controllers
{
    public class IssueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult detail(long id)
        {
            return PartialView("_detail");
        }
    }
}