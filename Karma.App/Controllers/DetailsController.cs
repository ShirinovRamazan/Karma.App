using Microsoft.AspNetCore.Mvc;

namespace Karma.App.Controllers
{
	public class DetailsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
