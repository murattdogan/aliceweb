using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alice.Admin.Filters;
using Alice.Admin.Models;
using Alice.Service.Model;
using Alice.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace Alice.Admin.Controllers
{
    public class TourController : Controller
    {
        private readonly TourService _tourService;
        private readonly CategoryService _categoryService;
        private readonly TourCategoriesService _tourCategoryService;
        private readonly KeywordPoolService _keywordPoolService;
        private readonly GalleryKeywordService _galleryKeywordService;
        private readonly GalleryPoolService _galleryPoolService;
        private readonly TourGalleriesService _tourGalleryService;


        public TourController(TourService tourService, CategoryService categoryService, TourCategoriesService tourCategoryService, KeywordPoolService keywordPoolService, GalleryKeywordService galleryKeywordService, GalleryPoolService galleryPoolService, TourGalleriesService tourGalleryService)
        {
            _tourService = tourService;
            _categoryService = categoryService;
            _tourCategoryService = tourCategoryService;
            _keywordPoolService = keywordPoolService;
            _galleryKeywordService = galleryKeywordService;
            _galleryPoolService = galleryPoolService;
            _tourGalleryService = tourGalleryService;
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
            if (tour != null)
            {
                var tourGalleries = new List<GalleryPoolDTO>();
                var tourGallery = _tourGalleryService.GetGalleriesByTourId(tour.Id);
                if (tourGallery.Any())
                {
                    foreach (var item in tourGallery)
                    {
                        tourGalleries.Add(_galleryPoolService.GetByGalleryId(item.GalleryId));
                    }
                }

                ViewBag.Categories = new TourCategoryViewModel()
                {
                    SelectAllCategories = _tourCategoryService.GetAllByTourIdCategories(tour.Id),
                    AllCategories = _categoryService.GetAllCategories(),
                    SelectAllKeyword = _keywordPoolService.GetAll(),
                    GalleryPhotos = tourGalleries
                };
                return View(tour);
            }
            else return View(null);

        }


        [ServiceFilter(typeof(AuthorizationAttribute))]
        [HttpGet]
        public PartialViewResult GetTourImages(int Id)
        {
            var tourGalleries = new List<GalleryPoolDTO>();
            var tourGallery = _tourGalleryService.GetGalleriesByTourId(Id);
            if (tourGallery.Any())
            {
                foreach (var item in tourGallery)
                {
                    tourGalleries.Add(_galleryPoolService.GetByGalleryId(item.GalleryId));
                }
            }
            return PartialView(tourGalleries);
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

        public PartialViewResult GetGallerybyText(string text)
        {
            var keyword = _keywordPoolService.GetByKeyword(text);
            if (keyword != null)
            {
                var galleryList = new List<GalleryPoolDTO>();
                var galleryIdList = _galleryKeywordService.GetAllbyKeywordId(keyword.Id);
                foreach (var item in galleryIdList)
                {
                    var gallery = _galleryPoolService.GetByGalleryId(item.GalleryId);
                    galleryList.Add(gallery);
                }
                return PartialView(galleryList);
            }
            return PartialView();
        }



        [ServiceFilter(typeof(AuthorizationAttribute))]
        [HttpGet]
        public JsonResult TourGalleryDelete(int tourId, string galleryId)
        {
            var tourGallery = _tourGalleryService.GetGalleriesByTourId(tourId)?.First(x => x.GalleryId == galleryId) ?? null;
            return Json(tourGallery != null ? _tourGalleryService.Delete(tourGallery) : false);

        }
        [ServiceFilter(typeof(AuthorizationAttribute))]
        [HttpPost]
        public JsonResult AddTourGalleries(int tourId, string galleryId)
        {
            return Json(_tourGalleryService.Add(new TourGalleriesDTO() { TourId = tourId, GalleryId = galleryId }));
        }

    }
}