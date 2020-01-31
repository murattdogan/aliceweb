using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alice.Service.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Alice.Admin.Controllers
{
    public class GalleryPoolController : Controller
    {
        private readonly GalleryPoolService _galleryPoolService;
        private readonly IHostingEnvironment _environment;

        public GalleryPoolController(GalleryPoolService galleryPoolService, IHostingEnvironment environment)
        {
            _galleryPoolService = galleryPoolService;
            _environment = environment;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}