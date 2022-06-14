using Microsoft.AspNetCore.Mvc;

namespace BlogSystem.Controllers
{
    public class WarningPageController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}
