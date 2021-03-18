using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Task2_API.Models;

namespace Task2_API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("/Swagger");
        }
    }
}
