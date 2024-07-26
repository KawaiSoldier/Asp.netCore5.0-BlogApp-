﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            var blogValues = bm.GetBlogListWithCategory();
            return View(blogValues);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var blogValues = bm.GetBlogByID(id);
            return View(blogValues);

        }

        public IActionResult BlogListByWriter(int id)
        {
            var values = bm.GetCategoryByWriterId(1);
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryvalue = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.cv = categoryvalue;
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(p);
            if (results.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCrateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID = 1; // Sessiondan gelecek
                bm.TAdd(p);

                return RedirectToAction("BlogListByWriter", "Blog");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }

        }

        public IActionResult DeleteBlog(int id)
        {
            var blogValue = bm.TGetById(id);
            bm.TDelete(blogValue);
            return RedirectToAction("BlogListByWriter");
        }


        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            List<SelectListItem> categoryvalue = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.cv = categoryvalue;
            var blogValue = bm.TGetById(id);
            return View(blogValue);
        }

        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
            p.WriterID = 1;
            p.BlogCrateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.BlogStatus = true;
            bm.TUpdate(p);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
