using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alice.Admin.Filters;
using Alice.Admin.Models;
using Alice.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace Alice.Admin.Controllers
{
    public class TourController : Controller
    {
        private readonly TourService _tourService;
        private readonly CategoryService _categoryService;
        private readonly TourCategoriesService _tourCategoryService;

        public TourController(TourService tourService, CategoryService categoryService, TourCategoriesService tourCategoryService)
        {
            _tourService = tourService;
            _categoryService = categoryService;
            _tourCategoryService = tourCategoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        public IActionResult List()
        {
            ViewBag.TourList = _tourService.GetAllTours().ToList();
            return View();
        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        public IActionResult New()
        {
            return View();
        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        [HttpPost]
        public JsonResult NewTour(string TourName, string TourSpot, string TourBody)
        {
            var code = DateTime.Now.ToString("ddmmmmyyHHmmss");
            var isInsert = _tourService.Insert(new Service.Model.TourDTO() { TourName = TourName, TourSpot = TourSpot, OverView = TourBody, TourCode = code, TourActivity = 0 });
            if (isInsert) return Json(code);
            else return Json("0");

        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        [HttpPost]
        public JsonResult UpdateTour(int Id, string TourName, string TourSpot, string TourBody)
        {
            var tour = _tourService.GetTourById(Id);
            if (tour != null)
            {
                tour.TourName = TourName;
                tour.TourSpot = TourSpot;
                tour.OverView = TourBody;
                _tourService.Update(tour);
                return Json(true);
            }
            else return Json(false);
        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        public IActionResult TourUpdateView(string Id)
        {
            var tour = _tourService.GetTourByTourCode(Id);

            ViewBag.Categories = new TourCategoryViewModel()
            {
                SelectAllCategories = _tourCategoryService.GetAllByTourIdCategories(tour.Id),
                AllCategories = _categoryService.GetAllCategories()
            };

            return View(tour);
        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        [HttpPost]
        public IActionResult UpdateCategories(int Id, List<string> CategoryList)
        {

            _tourCategoryService.DeleteAllByTourId(Id);

            foreach (var item in CategoryList)
            {
                _tourCategoryService.Insert(new Service.Model.TourCategoriesDTO()
                {
                    TourId = Id,
                    CategoriesId = int.Parse(item)
                });
            }

            return View();
        }



        [ServiceFilter(typeof(AuthorizationAttribute))]
        public PartialViewResult GetTourDays(int Id)
        {
            return PartialView();
        }
    }
}