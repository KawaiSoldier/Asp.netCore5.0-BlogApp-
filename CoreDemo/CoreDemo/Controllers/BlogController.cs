using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {
            var blogValues = bm.GetBlogListWithCategory();
            return View(blogValues);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var blogValues = bm.GetBlogByID(id);
            return View(blogValues);
          
        }
    }
}
