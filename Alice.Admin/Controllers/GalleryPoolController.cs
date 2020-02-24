using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Alice.Admin.Filters;
using Alice.Admin.Helper;
using Alice.Service.Model;
using Alice.Service.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alice.Admin.Controllers
{
    [ServiceFilter(typeof(AuthorizationAttribute))]
    public class GalleryPoolController : Controller
    {
        private readonly GalleryPoolService _galleryPoolService;
        private readonly KeywordPoolService _keywordPoolService;
        private readonly GalleryKeywordService _galleryKeywordService;
        private readonly IHostingEnvironment _environment;

        public GalleryPoolController(GalleryPoolService galleryPoolService, KeywordPoolService keywordPoolService, GalleryKeywordService galleryKeywordService, IHostingEnvironment environment)
        {
            _galleryPoolService = galleryPoolService;
            _keywordPoolService = keywordPoolService;
            _galleryKeywordService = galleryKeywordService;
            _environment = environment;
        }


        public ActionResult List()
        {
            ViewBag.KeywordPool = _keywordPoolService.GetTake(10).ToList();
            return View(_galleryPoolService.GetAll());
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            _galleryPoolService.Delete(new GalleryPoolDTO() { Id = Id });
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Insert(int KeywordPool, string ImageCategoryName, IFormFile ImageFile, int AnaSayfa_401x289, int AnaSayfa_401x592, int Genellogo_168_57, int AnaSayfa_815x289, int AnasayfaSlider_1440_534, int AnasayfaSlider_1440_800,
            int KategoriDetay_285x285, int KategoriAltDetay_389_280, int TourDetail_1440_550, int TourGallery_257_257)
        {
            string randomFileName = Guid.NewGuid().ToString();
            var root = "\\Content\\UI\\Image\\";

            if (KeywordPool == 0 && !string.IsNullOrEmpty(ImageCategoryName))
            {
                var isNewKeywordPool = _keywordPoolService.Add(new KeywordPoolDTO() { Keyword = ImageCategoryName });
                if (isNewKeywordPool)
                {
                    var keywordResult = _keywordPoolService.GetByKeyword(ImageCategoryName);
                    KeywordPool = keywordResult.Id;
                }
            }


            if (AnaSayfa_401x289 == 1)
                GalleryPoolHelper.SaveGalleryPool(_environment,randomFileName, ImageFile, root, nameof(AnaSayfa_401x289), _galleryKeywordService, _galleryPoolService, KeywordPool, 401, 289);
            if (AnaSayfa_401x592 == 1)
                GalleryPoolHelper.SaveGalleryPool(_environment, randomFileName, ImageFile, root, nameof(AnaSayfa_401x592), _galleryKeywordService, _galleryPoolService, KeywordPool, 401, 592);
            if (Genellogo_168_57 == 1)
                GalleryPoolHelper.SaveGalleryPool(_environment, randomFileName, ImageFile, root, nameof(Genellogo_168_57), _galleryKeywordService, _galleryPoolService, KeywordPool, 168, 57);
            if (AnaSayfa_815x289 == 1)
                GalleryPoolHelper.SaveGalleryPool(_environment, randomFileName, ImageFile, root, nameof(AnaSayfa_815x289), _galleryKeywordService, _galleryPoolService, KeywordPool, 815, 289);
            if (AnasayfaSlider_1440_534 == 1)
                GalleryPoolHelper.SaveGalleryPool(_environment, randomFileName, ImageFile, root, nameof(AnasayfaSlider_1440_534), _galleryKeywordService, _galleryPoolService, KeywordPool, 1440, 534);
            if (AnasayfaSlider_1440_800 == 1)
                GalleryPoolHelper.SaveGalleryPool(_environment, randomFileName, ImageFile, root, nameof(AnasayfaSlider_1440_800), _galleryKeywordService, _galleryPoolService, KeywordPool, 1440, 800);
            if (KategoriDetay_285x285 == 1)
                GalleryPoolHelper.SaveGalleryPool(_environment, randomFileName, ImageFile, root, nameof(KategoriDetay_285x285), _galleryKeywordService, _galleryPoolService, KeywordPool, 285, 285);
            if (KategoriAltDetay_389_280 == 1)
                GalleryPoolHelper.SaveGalleryPool(_environment, randomFileName, ImageFile, root, nameof(KategoriAltDetay_389_280), _galleryKeywordService, _galleryPoolService, KeywordPool, 389, 280);
            if (TourDetail_1440_550 == 1)
                GalleryPoolHelper.SaveGalleryPool(_environment, randomFileName, ImageFile, root, nameof(TourDetail_1440_550), _galleryKeywordService, _galleryPoolService, KeywordPool, 1440, 550);
            if (TourGallery_257_257 == 1)
                GalleryPoolHelper.SaveGalleryPool(_environment, randomFileName, ImageFile, root, nameof(TourGallery_257_257), _galleryKeywordService, _galleryPoolService, KeywordPool, 257, 257);

            return RedirectToAction("List");
        }
    }
}