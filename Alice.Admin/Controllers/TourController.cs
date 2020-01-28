using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alice.Admin.Filters;
using Alice.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace Alice.Admin.Controllers
{
    public class TourController : Controller
    {
        private readonly TourService _tourService;
        private readonly CategoryService _categoryService;


        public TourController(TourService tourService, CategoryService categoryService)
        {
            _tourService = tourService;
            _categoryService = categoryService;
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
        public IActionResult NewTour(string TourName, string TourSpot, string TourBody)
        {
            _tourService.Insert(new Service.Model.TourDTO() { TourName = TourName, TourSpot = TourSpot, TourBody = TourBody });

            return View();
        }


        [ServiceFilter(typeof(AuthorizationAttribute))]
        public PartialViewResult GetTourDays(int Id)
        {
            return PartialView();
        }
    }
}