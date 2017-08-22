using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using gurralib.Models;
using Microsoft.AspNetCore.Mvc;

namespace gurralib.Controllers
{
    public class GurraController : Controller
    {
        public IActionResult Index()
        {
            var msg = "Hello from actionmethod in gurra";
            return View(new GurraModel { Message = msg });
        }
    }
}
