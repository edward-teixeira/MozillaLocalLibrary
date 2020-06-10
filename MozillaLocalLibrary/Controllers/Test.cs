using Microsoft.AspNetCore.Mvc;

namespace MozillaLocalLibrary.Controllers
{
    public class Test : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}