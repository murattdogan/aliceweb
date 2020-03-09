using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alice.Service.Model;
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
        private readonly TourService _tourService;
        private readonly TourCategoriesService _tourCategoryService;

        public CategoryController(TourCategoriesService tourCategoryService, TourService tourService, CategoryService categoryService, CategoriesSlidersService categoriesSliderService, GalleryPoolService galleryPoolService)
        {
            _categoryService = categoryService;
            _categoriesSliderService = categoriesSliderService;
            _galleryPoolService = galleryPoolService;
            _tourService = tourService;
            _tourCategoryService = tourCategoryService;
        }
        public IActionResult Detail(string categoryName, string parentCategoryName, string subParentCategoryName)
        {
            if (categoryName.Contains(".") || categoryName.Contains("src") || categoryName.ToLower().Contains("true") || categoryName.ToLower().Contains("false"))
            {
                return RedirectPermanent(categoryName);
            }

            var sa = $"/{categoryName}";

            if (!string.IsNullOrEmpty(parentCategoryName))
            {
                sa = $"/{parentCategoryName}/{categoryName}";
            }

            if (!string.IsNullOrEmpty(subParentCategoryName))
            {
                sa = $"/{parentCategoryName}/{subParentCategoryName}/{categoryName}";
            }

            var categoryModel = _categoryService.GetByUrl(sa);
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

            var tourList = new List<TourDTO>();

            if (_categoryService.GetAllSubCategories(categoryModel.Id).Count() == 0)
            {
                var categoryTours = _tourCategoryService.GetAllByCategoriesofTours(categoryModel.Id).ToList();
                foreach (var item in categoryTours)
                {
                    tourList.Add(_tourService.GetTourById(item.Id));
                }
            }
            ViewBag.TourList = tourList;

            return View(categoryModel);
        }
    }
}