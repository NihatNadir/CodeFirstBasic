using Microsoft.AspNetCore.Mvc;

namespace CodeFirstBasic.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
