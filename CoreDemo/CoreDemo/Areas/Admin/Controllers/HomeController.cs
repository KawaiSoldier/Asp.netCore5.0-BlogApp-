using Microsoft.AspNetCore.Mvc;

namespace App.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
