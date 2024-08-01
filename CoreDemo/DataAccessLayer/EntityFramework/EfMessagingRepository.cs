using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessagingRepository : GenericRepository<Messaging>, IMessagingDal
    {
        public List<Messaging> GetListWithMessageByWriter(int id)
        {
            using (var context = new Context())
            {
                return context.Messagings.Include(x => x.ReceiverWriter).Where(x => x.ReceiverID == id).ToList();
            }
        }
    }
}
