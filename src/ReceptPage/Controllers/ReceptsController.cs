﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace ReceptPage.Controllers
{
    public class ReceptsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
