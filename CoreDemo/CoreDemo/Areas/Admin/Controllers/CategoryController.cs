using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using X.PagedList;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;


namespace App.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {

        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        Context c = new Context();



        
        public IActionResult Index(int page = 1)
        {
            var values = cm.GetList().ToPagedList(page, 12);

            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()
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
        public IActionResult AddCategory(Category p)
        {
        
            CategoryValidator cv = new CategoryValidator();
            ValidationResult results = cv.Validate(p);
            if (results.IsValid)
            {
                p.CategoryStatus = true;
                cm.TAdd(p);
                return RedirectToAction("Index", "Category");

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

        public IActionResult PassiveCategory(int id)
        {
            var categoryValue = cm.TGetById(id);
            categoryValue.CategoryStatus = false;
            cm.TUpdate(categoryValue);
            return RedirectToAction("Index");
        }

        public IActionResult ActivateCategory(int id)
        {
            var categoryValue = cm.TGetById(id);
            categoryValue.CategoryStatus = true;
            cm.TUpdate(categoryValue);
            return RedirectToAction("Index");
        }
    
    }
}
