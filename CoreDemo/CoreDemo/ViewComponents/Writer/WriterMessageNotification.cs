using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        MessagingManager mm = new MessagingManager(new EfMessagingRepository());
        public IViewComponentResult Invoke()
        {
            int id = 3;
            var values = mm.GetInBoxListByWriter(id);
            
            return View(values);
        }
    }
}
