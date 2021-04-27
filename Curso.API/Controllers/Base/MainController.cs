using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.API.Controllers.Base
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
