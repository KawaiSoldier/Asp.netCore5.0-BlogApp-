using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {

        //metodlar tanımlanır

        List<T> GetListAll();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        List <T> GetListAll(Expression<Func<T,bool>>filter); //filtreleme yapmak için kullanılır 


    }
}
