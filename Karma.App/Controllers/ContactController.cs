using Microsoft.AspNetCore.Mvc;

namespace Karma.App.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
