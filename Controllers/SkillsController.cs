using Microsoft.AspNetCore.Mvc;

namespace FPW8.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
