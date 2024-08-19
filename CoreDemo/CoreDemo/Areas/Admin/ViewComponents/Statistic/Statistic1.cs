using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace App.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {

            var result = bm.GetList().Count();

            ViewBag.BlogSayisi = result;
            ViewBag.MesajSayisi = c.Contacts.Count();
            ViewBag.KategoriSayisi = c.Categories.Count();
            ViewBag.YorumSayisi = c.Comments.Count();
            ViewBag.EnFazlaKategoriAdi = c.Categories.GroupBy(x => x.CategoryName).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();



            ViewBag.EnFazlaBlogYazanYazar = c.Blogs.GroupBy(x => x.Writer.WriterName).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            string enFazlaBlogYazanYazar = ViewBag.EnFazlaBlogYazanYazar?.ToString().ToLower().Trim();
            ViewBag.EnÇokBlogYazanYazarınYazdığıBlogSayısı = c.Blogs.Count(x => x.Writer.WriterName.ToLower().Trim() == enFazlaBlogYazanYazar);

            return View(result);
        }


    }
}
