using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessagingManager : IMessagingService
    {

        IMessagingDal _messagingDal;

        public MessagingManager(IMessagingDal MessageigDal)
        {
            _messagingDal = MessageigDal;

        }
        public List<Messaging> GetInBoxListByWriter(int id)
        {
            return _messagingDal.GetListWithMessageByWriter(id);
        }

        public List<Messaging> GetList()
        {
           return _messagingDal.GetListAll();
        }

        public void TAdd(Messaging t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Messaging t)
        {
            throw new NotImplementedException();
        }

        public Messaging TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Messaging t)
        {
            throw new NotImplementedException();
        }
    }
}
