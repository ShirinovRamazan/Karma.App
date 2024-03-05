using Microsoft.AspNetCore.Mvc;

namespace Karma.App.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
