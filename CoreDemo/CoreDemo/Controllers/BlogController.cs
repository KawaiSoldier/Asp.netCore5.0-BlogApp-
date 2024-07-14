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
        public IActionResult BlogDetails(int id)
        {
           return View();
        }
    }
}
