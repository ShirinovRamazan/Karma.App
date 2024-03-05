using Microsoft.AspNetCore.Mvc;

namespace Karma.App.Controllers
{
    public class BlogDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
