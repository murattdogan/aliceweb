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
        private readonly CategoriesSlidersService _categoriesSliderService;
        private readonly KeywordPoolService _keywordPoolService;
        private readonly GalleryPoolService _galleryPoolService;
        private readonly IHostingEnvironment _environment;

        public CategoriesController(CategoryService categoryService, CategoriesSlidersService categoriesSliderService, KeywordPoolService keywordPoolService, GalleryPoolService galleryPoolService, IHostingEnvironment environment)
        {
            _categoryService = categoryService;
            _categoriesSliderService = categoriesSliderService;
            _environment = environment;
            _keywordPoolService = keywordPoolService;
            _galleryPoolService = galleryPoolService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        public IActionResult List()
        {
            ViewBag.SelectAllKeyword = _keywordPoolService.GetAll();
            var model = _categoryService.GetAllCategories();
            return View(model);
        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        [HttpPost]
        public IActionResult Insert(string id, string CategoryName, string CategoryPath, int TopCategory, string Title, string Description, string SEOTitle, string SEODescription)
        {
            if (id == "0" || id == null)
            {
                var category = new CategoriesDTO()
                {
                    CategoryName = CategoryName,
                    Path = CategoryPath,
                    ImagePath = "",
                    MainCategoryId = TopCategory,
                    Description = Description,
                    Title = Title,
                    SEODescription = SEODescription,
                    SEOTitle = SEOTitle
                };
                _categoryService.AddCategory(category);
            }
            else
            {
                _categoryService.UploadCategory(new CategoriesDTO()
                {
                    Id = int.Parse(id),
                    CategoryName = CategoryName,
                    ImagePath = "",
                    MainCategoryId = TopCategory,
                    Path = CategoryPath,
                    Description = Description,
                    Title = Title,
                    SEODescription = SEODescription,
                    SEOTitle = SEOTitle
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
        [HttpGet]
        public JsonResult CategoryGalleryDelete(int categoryId, string galleryId)
        {
            var categoryGallery = _categoriesSliderService.GetGalleriesByCategoryId(categoryId)?.First(x => x.GalleryId == galleryId) ?? null;
            return Json(categoryGallery != null ? _categoriesSliderService.DeleteCategory(categoryGallery) : false);

        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        [HttpGet]
        public PartialViewResult GetGalleryImages(int Id)
        {
            var categoryGalleries = new List<GalleryPoolDTO>();
            var categoryGallery = _categoriesSliderService.GetGalleriesByCategoryId(Id);
            if (categoryGallery.Any())
            {
                foreach (var item in categoryGallery)
                {
                    categoryGalleries.Add(_galleryPoolService.GetByGalleryId(item.GalleryId));
                }
            }
            return PartialView(categoryGalleries);
        }

        public JsonResult UpdateCategoryBox(string galleryId, int categoryId)
        {
            _categoriesSliderService.AddCategory(new CategoriesSlidersDTO()
            {
                GalleryId = galleryId,
                CategoryId = categoryId
            });
            return Json(true);
        }


        public JsonResult CategoryPictureUpdate(string galleryId, int categoryId)
        {
            var t = _categoryService.GetById(categoryId);
            if (t != null)
            {
                t.ImagePath = galleryId;
                _categoryService.UploadCategory(t);
                return Json(true);
            }
            return Json(false);
        }



        [ServiceFilter(typeof(AuthorizationAttribute))]
        public JsonResult GetById(int Id)
        {
            var t = _categoryService.GetById(Id);
            return Json(t);
        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        public JsonResult UpCategory()
        {
            var model = _categoryService.GetAllCategories();
            return Json(model);
        }
    }
}