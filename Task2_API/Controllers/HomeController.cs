using Microsoft.AspNetCore.Mvc;

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
