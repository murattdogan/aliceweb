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
        private readonly IHostingEnvironment _environment;

        public GalleryPoolController(GalleryPoolService galleryPoolService, KeywordPoolService keywordPoolService, IHostingEnvironment environment)
        {
            _galleryPoolService = galleryPoolService;
            _keywordPoolService = keywordPoolService;
            _environment = environment;
        }


        public IActionResult List()
        {
            ViewBag.KeywordPool = _keywordPoolService.GetAll();
            return View(_galleryPoolService.GetAll());
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            return View(_galleryPoolService.Delete(new GalleryPoolDTO() { Id = Id }));
        }

        //public static Image ResizeImage(this Image image, int width, int height)
        //{
        //    var res = new Bitmap(width, height);
        //    using (var graphic = Graphics.FromImage(res))
        //    {
        //        graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //        graphic.SmoothingMode = SmoothingMode.HighQuality;
        //        graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
        //        graphic.CompositingQuality = CompositingQuality.HighQuality;
        //        graphic.DrawImage(image, 0, 0, width, height);
        //    }
        //    return res;
        //}

        [HttpPost]
        public IActionResult Insert(int KeywordPool, string ImageCategoryName, IFormFile ImageFile)
        {

            string randomFileName = Guid.NewGuid().ToString();
            var fileName = Path.Combine(_environment.ContentRootPath, "Content/UI/Image", $"{randomFileName}{Path.GetExtension(ImageFile.FileName)}");
            string largeFileName = $"large-{fileName}", mediumFileName = $"medium-{fileName}", smallFileName = $"large-{fileName}";
            using (var memoryStream = new MemoryStream())
            {
                ImageFile.CopyToAsync(memoryStream);
                using (var img = Image.FromStream(memoryStream))
                {
                    img.GetThumbnailImage(1024, 120, () => false, IntPtr.Zero).Save(largeFileName);
                    img.GetThumbnailImage(768, 120, () => false, IntPtr.Zero).Save(mediumFileName);
                    img.GetThumbnailImage(512, 120, () => false, IntPtr.Zero).Save(smallFileName);
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
            _galleryPoolService.Add(new GalleryPoolDTO()
            {
                Path = upload,
                Height =
            });


            return View();
        }




    }
}