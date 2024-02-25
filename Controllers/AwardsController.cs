using Microsoft.AspNetCore.Mvc;

namespace FPW8.Controllers
{
    public class AwardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
