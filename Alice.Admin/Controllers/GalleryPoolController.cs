using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Alice.Admin.Filters;
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


        public IActionResult List()
        {
            ViewBag.KeywordPool = _keywordPoolService.GetTake(10).ToList();
            return View(_galleryPoolService.GetAll());
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            _galleryPoolService.Delete(new GalleryPoolDTO() { Id = Id });
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Insert(int KeywordPool, string ImageCategoryName, IFormFile ImageFile)
        {

            string randomFileName = Guid.NewGuid().ToString();
            string largeFileName = Path.Combine("/Content/UI/Image", $"large-{randomFileName}{Path.GetExtension(ImageFile.FileName)}");
            string mediumFileName = Path.Combine("/Content/UI/Image", $"medium-{randomFileName}{Path.GetExtension(ImageFile.FileName)}");
            string smallFileName = Path.Combine("/Content/UI/Image", $"small-{randomFileName}{Path.GetExtension(ImageFile.FileName)}");
            string thumbnailFileName = Path.Combine("/Content/UI/Image", $"thumbnail-{randomFileName}{Path.GetExtension(ImageFile.FileName)}");
            using (var memoryStream = new MemoryStream())
            {
                ImageFile.CopyToAsync(memoryStream);
                using (var img = Image.FromStream(memoryStream))
                {
                    img.GetThumbnailImage(40, 40, () => false, IntPtr.Zero).Save(Path.Combine(_environment.ContentRootPath, "Content/UI/Image", $"thumbnail-{randomFileName}{Path.GetExtension(ImageFile.FileName)}"));
                    img.GetThumbnailImage(1024, 120, () => false, IntPtr.Zero).Save(Path.Combine(_environment.ContentRootPath, "Content/UI/Image", $"large-{randomFileName}{Path.GetExtension(ImageFile.FileName)}"));
                    img.GetThumbnailImage(768, 120, () => false, IntPtr.Zero).Save(Path.Combine(_environment.ContentRootPath, "Content/UI/Image", $"medium-{randomFileName}{Path.GetExtension(ImageFile.FileName)}"));
                    img.GetThumbnailImage(512, 120, () => false, IntPtr.Zero).Save(Path.Combine(_environment.ContentRootPath, "Content/UI/Image", $"small-{randomFileName}{Path.GetExtension(ImageFile.FileName)}"));
                }
            }

            if (KeywordPool == 0)
            {
                var isNewKeywordPool = _keywordPoolService.Add(new KeywordPoolDTO() { Keyword = ImageCategoryName });
                if (isNewKeywordPool)
                {
                    var keywordResult = _keywordPoolService.GetByKeyword(ImageCategoryName);
                    KeywordPool = keywordResult.Id;
                }
            }

            _galleryKeywordService.Add(new GalleryKeywordDTO()
            {
                GalleryId = randomFileName,
                KeywordId = KeywordPool
            });

            _galleryPoolService.Add(new GalleryPoolDTO()
            {
                GalleryId = randomFileName,
                Thumbnail = thumbnailFileName,
                Small = smallFileName,
                Large = largeFileName,
                Medium = mediumFileName
            });

            return RedirectToAction("List");
        }
    }
}