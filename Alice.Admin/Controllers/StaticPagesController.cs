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
    [ServiceFilter(typeof(AuthorizationAttribute))]
    public class StaticPagesController : Controller
    {
        private readonly StaticPagesService _staticPagesService;
        private readonly GalleryPoolService _galleryPoolService;
        private readonly KeywordPoolService _keywordPoolService;

        public StaticPagesController(StaticPagesService staticPagesService, GalleryPoolService galleryPoolService, KeywordPoolService keywordPoolService)
        {
            _galleryPoolService = galleryPoolService;
            _staticPagesService = staticPagesService;
            _keywordPoolService = keywordPoolService;
        }

        public IActionResult List()
        {
            ViewBag.SelectAllKeyword = _keywordPoolService.GetAll();
            return View(_staticPagesService.GetAllPages());
        }

        
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

        public JsonResult GetById(int id)
        {
            var page = _staticPagesService.GetById(id);
            if (page != null)
            {
                return Json(page);
            }

            return Json(null);
        }


        public IActionResult PagesPictureUpdate(string galleryId, int id, string pageBody)
        {
            var page = _staticPagesService.GetById(id);
            if (page != null)
            {
                page.PageImage = galleryId;
                page.PageBody = pageBody;
                _staticPagesService.Update(page);
                return View(page);
            }
            return Redirect("/");
        }


    }
}