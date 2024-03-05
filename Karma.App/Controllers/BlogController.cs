using Microsoft.AspNetCore.Mvc;

namespace Karma.App.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
