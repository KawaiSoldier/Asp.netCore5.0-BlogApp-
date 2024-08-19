using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace App.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.AdminName = c.Admins.Where(x => x.AdminID == 1).Select(y => y.AdminName).FirstOrDefault();
            ViewBag.AdminImage = c.Admins.Where(x => x.AdminID == 1).Select(y => y.AdminImage).FirstOrDefault();
            ViewBag.AdminDescription = c.Admins.Where(x => x.AdminID == 1).Select(y => y.AdminShortDescription).FirstOrDefault();

            return View();
        }
    }
}
