using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using berralib.Models;
using Microsoft.AspNetCore.Mvc;

namespace berralib.Controllers
{
    public class BerraController : Controller
    {
        public IActionResult Index()
        {
            var msg = "Hello from Index action method in BerraController!";
            return View(new BerraModel { Message = msg });
        }
    }
}
