using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());

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
