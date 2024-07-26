﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {

        List<T> GetList();
        T TGetById(int id);
        void TAdd(T t);
        void TUpdate(T t);
        void TDelete(T t);
    }
}
