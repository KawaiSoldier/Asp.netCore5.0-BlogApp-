﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
       //List<Blog> GetList();
       // Blog GetById(int id);
       // void BlogAdd(Blog blog);
       // void BlogUpdate(Blog blog);
       // void BlogDelete(Blog blog);

        List<Blog> GetBlogListWithCategory();

        List<Blog> GetBlogByWriter(int id);

       
    }
}
