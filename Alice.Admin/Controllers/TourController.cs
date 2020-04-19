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
        private readonly TourPlanService _tourPlanListService;

        public TourController(TourPlanService tourPlanListService, TourService tourService, CategoryService categoryService, TourCategoriesService tourCategoryService, KeywordPoolService keywordPoolService, GalleryKeywordService galleryKeywordService, GalleryPoolService galleryPoolService, TourGalleriesService tourGalleryService)
        {
            _tourService = tourService;
            _categoryService = categoryService;
            _tourCategoryService = tourCategoryService;
            _keywordPoolService = keywordPoolService;
            _galleryKeywordService = galleryKeywordService;
            _galleryPoolService = galleryPoolService;
            _tourGalleryService = tourGalleryService;
            _tourPlanListService = tourPlanListService;
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
        public JsonResult UpdateTour(int Id, string TourName, string TourSpot, string TourBody, string TourActivity2, string TourActivity1, string TourActivity0)
        {
            var tour = _tourService.GetTourById(Id);
            if (tour != null)
            {
                tour.TourName = TourName;
                tour.TourSpot = TourSpot;
                tour.OverView = TourBody;
                tour.TourActivity = int.Parse(TourActivity2 ?? TourActivity1 ?? TourActivity0);
                _tourService.Update(tour);
                return Json(true);
            }
            else return Json(false);
        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        [HttpPost]
        public JsonResult AddTourDayOrUpdate(int tourDayId, int tourDay, string tourDayTitle, string tourDayDetail, int tourId)
        {
            if (tourDayId == 0)
            {
                return Json(_tourPlanListService.Add(new TourPlanListDTO()
                {
                    DayTitle = tourDayTitle,
                    DayDetail = tourDayDetail,
                    Day = tourDay,
                    TourId = tourId
                }));
            }
            else
            {
                var tourDayList = _tourPlanListService.GetById(tourDayId);
                if (tourDayList != null)
                {
                    tourDayList.Day = tourDay;
                    tourDayList.DayTitle = tourDayTitle;
                    tourDayList.DayDetail = tourDayDetail;
                    tourDayList.TourId = tourId;
                    return Json(_tourPlanListService.Update(tourDayList));
                }
            }
            return Json(false);

        }
        [ServiceFilter(typeof(AuthorizationAttribute))]
        [HttpGet]
        public JsonResult TourDayDelete(int tourDayId)
        {
            var tourDayList = _tourPlanListService.Delete(tourDayId);
            return Json(tourDayList);

        }
        [ServiceFilter(typeof(AuthorizationAttribute))]
        public IActionResult TourUpdateView(string Id)
        {
            var tour = _tourService.GetTourByTourCode(Id);
            if (tour != null)
            {
                var tourGalleries = new List<GalleryPoolDTO>();
                var tourGallery = _tourGalleryService.GetGalleriesByTourId(tour.Id);
                if (tourGallery!=null && tourGallery.Any())
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
                    GalleryPhotos = tourGalleries,
                    TourPlanList = _tourPlanListService.GetAll()
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
            if (tourGallery !=null && tourGallery.Any())
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
        public JsonResult AddTourGalleries(int tourId, string galleryId, int imageType)
        {
            var tour = _tourService.GetTourById(tourId);
            var galleryPath = _galleryPoolService.GetByGalleryId(galleryId);
            var image = "";
            if (galleryPath != null)
            {
                image = $"console.luxuryistanbul.com\\{galleryPath.ImagePath}\\{galleryPath.GalleryId}{galleryPath.PathExtension}".Replace("\\", @"/").Replace("//", "/");
                image = $"http://{image}";
            }

            if (imageType == 1)
            {
                _tourGalleryService.Add(new TourGalleriesDTO() { TourId = tourId, GalleryId = galleryId });
            }
            else if (imageType == 2)
            {
                if (galleryPath != null)
                {
                    tour.TourImage = image;
                    _tourService.Update(tour);
                }
            }
            else if (imageType == 3)
            {
                if (galleryPath != null)
                {
                    tour.TourSliderImage = image;
                    _tourService.Update(tour);
                }
            }


            return Json(true);
        }

        [ServiceFilter(typeof(AuthorizationAttribute))]
        [HttpPost]
        public JsonResult MapsAddTourGalleries(int tourId, string galleryId, int imageType, string mapsDesc)
        {
            var tour = _tourService.GetTourById(tourId);
            var galleryPath = _galleryPoolService.GetByGalleryId(galleryId);
            var image = "";
            if (galleryPath != null)
            {
                image = $"console.luxuryistanbul.com\\{galleryPath.ImagePath}\\{galleryPath.GalleryId}{galleryPath.PathExtension}".Replace("\\", @"/").Replace("//", "/");
                image = $"http://{image}";

                if (galleryPath != null)
                {
                    tour.TourMapImage = image;
                    tour.TourMapDesc = mapsDesc;
                    _tourService.Update(tour);
                }
            }
            return Json(true);
        }

    }
}