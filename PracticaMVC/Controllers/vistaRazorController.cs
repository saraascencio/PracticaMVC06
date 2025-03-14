using Microsoft.AspNetCore.Mvc;

namespace PracticaMVC.Controllers
{
    public class vistaRazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult bloqueMultiple()
        {
            return View();
        }

        public IActionResult condiciones()
        {
            return View();
        }

        public IActionResult bucles()
        {
            return View();
        }
    }
}
