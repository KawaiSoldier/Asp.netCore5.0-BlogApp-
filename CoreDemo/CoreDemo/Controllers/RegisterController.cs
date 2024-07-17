using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Writer p)
		{
			p.WriterStatus = true;
			p.WriterAbout = "Merhaba Ben BlogDemo Kullanıyorum";
			wm.WriterAdd(p);

			return RedirectToAction("Index" , "Blog");
		}

	}
}
