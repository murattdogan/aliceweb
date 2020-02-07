using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Alice.Web.Models;
using Alice.Service.Service;

namespace Alice.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly SiteSettingsService _siteSettingsService;

        public HomeController(SiteSettingsService siteSettingsService)
        {
            _siteSettingsService = siteSettingsService;
        }
        public IActionResult Index()
        {
            ViewBag.HomePage = new LayoutModel(_siteSettingsService);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
