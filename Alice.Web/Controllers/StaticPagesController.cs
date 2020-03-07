using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alice.Service.Service;
using Alice.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Alice.Web.Controllers
{
    public class StaticPagesController : Controller
    {
        private readonly StaticPagesService _staticPagesService;
        private readonly GalleryPoolService _galleryPoolService;

        public StaticPagesController(StaticPagesService staticPagesService, GalleryPoolService galleryPoolService)
        {
            _galleryPoolService = galleryPoolService;
            _staticPagesService = staticPagesService;
        }

        [Route("/Page/{pageUrl}")]
        public IActionResult Page(string pageUrl)
        {
            var page = _staticPagesService.GetByUrl(pageUrl);
            if (page != null)
            {
                page.PageImage = PageImages.GetImage(page.PageImage, _galleryPoolService);
                return View(page);
            }
            return Redirect("/");
        }


    }
}