using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class MessageController : Controller
    {
        
        MessagingManager mm = new MessagingManager(new EfMessagingRepository());
        public IActionResult InBox()
        {
            int id = 3;
            var values = mm.GetInBoxListByWriter(id);
            return View(values);
        }
    }
}
