using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alice.Service.Service;
using Alice.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Alice.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService _categoryService;
        private readonly CategoriesSlidersService _categoriesSliderService;
        private readonly GalleryPoolService _galleryPoolService;


        public CategoryController(CategoryService categoryService, CategoriesSlidersService categoriesSliderService, GalleryPoolService galleryPoolService)
        {
            _categoryService = categoryService;
            _categoriesSliderService = categoriesSliderService;
            _galleryPoolService = galleryPoolService;
        }
        public IActionResult Detail(string categoryName)
        {
            if (categoryName.Contains(".") || categoryName.Contains("src") || categoryName.ToLower().Contains("true") || categoryName.ToLower().Contains("false"))
            {
                return RedirectPermanent(categoryName);
            }
            var categoryModel = _categoryService.GetByUrl($"/{categoryName}");
            if (categoryModel == null)
            {
                return RedirectToAction("Page", "StaticPages", new { pageUrl = categoryName });
            }

            var t = _categoriesSliderService.GetGalleriesByCategoryId(categoryModel.Id);

            var s = new List<string>();
            s.AddRange(t.Select(x => x.GalleryId).ToList<string>());
            var subCategory = _categoryService.GetAllSubCategories(categoryModel.Id).ToList();
            var imgs = new Dictionary<int, string>();

            subCategory.ForEach(x => imgs.Add(x.Id, x.ImagePath));

            CategoryModel cm = new CategoryModel(_galleryPoolService, s, imgs);
            ViewBag.SubCategories = subCategory;
            ViewBag.CategorySlider = cm;


            return View(categoryModel);
        }
    }
}