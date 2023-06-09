using Microsoft.AspNetCore.Mvc;

namespace booklibrary.Controllers
{
	public class BookListController : Controller
	{
		public IActionResult BookIndex()
		{
			return View();
		}
	}
}
