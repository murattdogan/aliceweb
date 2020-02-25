using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alice.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace Alice.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService _categoryService;

        public CategoryController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Detail(string categoryName)
        {
            var categoryModel = _categoryService.GetByUrl($"/{categoryName}");
            return View(categoryModel);
        }
    }
}