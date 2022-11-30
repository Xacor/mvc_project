using mvc_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace mvc_project.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}