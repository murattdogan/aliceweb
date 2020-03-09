using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alice.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace Alice.Web.Controllers
{
    public class TourController : Controller
    {
        private readonly TourService _tourService;

        public TourController(TourService tourService)
        {
            _tourService = tourService;
        }

        public IActionResult Detail(string tourUrl)
        {
            if (tourUrl.Contains(".") || tourUrl.Contains("src") || tourUrl.ToLower().Contains("true") || tourUrl.ToLower().Contains("false"))
            {
                return RedirectPermanent(tourUrl);
            }
            var q = _tourService.GetTourByUrl(tourUrl);
            if (q != null)
            {
                return View(q);
            }

            return View(null);
        }
    }
}