using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Alice.Admin.Filters;
using Alice.Service.Model;
using Alice.Service.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alice.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly CategoryService _categoryService;
        private readonly IHostingEnvironment _environment;

        public CategoriesController(CategoryService categoryService, IHostingEnvironment environment)
        {
            _categoryService = categoryService;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        public IActionResult List()
        {
            var model = _categoryService.GetAllCategories();
            return View(model);
        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        [HttpPost]
        public IActionResult Insert(string Id, string CategoryName, string CategoryPath, int TopCategory, IFormFile CategoryFile)
        {

            string fileName = Guid.NewGuid().ToString();
            var upload = "";
            if (CategoryFile != null)
            {
                upload = Path.Combine(_environment.ContentRootPath, "Content/UImage/Categories", $"{fileName}{Path.GetExtension(CategoryFile.FileName)}");
                CategoryFile.CopyTo(new FileStream(upload, FileMode.Create));
            }

            if (Id == "0")
            {
                var category = new CategoriesDTO()
                {
                    CategoryName = CategoryName,
                    Path = CategoryPath,
                    ImagePath = upload,
                    MainCategoryId = TopCategory
                };
                _categoryService.AddCategory(category);
            }
            else
            {
                _categoryService.UploadCategory(new CategoriesDTO()
                {
                    Id = int.Parse(Id),
                    CategoryName = CategoryName,
                    ImagePath = upload,
                    MainCategoryId = TopCategory,
                    Path = CategoryPath
                });
            }
            return RedirectToAction("List");
        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        public IActionResult Delete(int Id)
        {
            _categoryService.DeleteCategory(new CategoriesDTO() { Id = Id });
            return RedirectToAction("List");

        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        public JsonResult GetById(int Id)
        {
            return Json(_categoryService.GetById(Id));
        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        public JsonResult UpCategory()
        {
            var model = _categoryService.GetAllCategories();
            return Json(model);
        }
    }
}