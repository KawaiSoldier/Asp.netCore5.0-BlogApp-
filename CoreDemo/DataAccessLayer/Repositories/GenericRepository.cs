using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class // Class değeri taşıyan tüm entityler için kullanılacak olan generic repository
    {
        Context c = new Context();
        public void Add(T entity)  // Ekleme işlemi  | Entity tipinde bir parametre alır ve bu parametreyi veritabanına ekler | entity = T
        {
            c.Add(entity);
            c.SaveChanges();
        }

        public void Delete(T entity)
        {
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<T> GetListAll()
        {
           return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {

            return c.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            c.Update(entity);
            c.SaveChanges();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
