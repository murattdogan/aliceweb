using Alice.Service.Model;
using Alice.Service.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Alice.Admin.Helper
{
    public class GalleryPoolHelper
    {
        public static void SaveGalleryPool(IHostingEnvironment _environment, string randomFileName, IFormFile ImageFile, string root, string size, GalleryKeywordService _galleryKeywordService
            , GalleryPoolService _galleryPoolService, int KeywordPool, int width, int height)
        {
                    //var img = Path.Combine(_environment.ContentRootPath, "Content/UI/Image", $"large-{randomFileName}{Path.GetExtension(ImageFile.FileName)}");
            var _anaSayfa_401x289_Path = Alice.Admin.Helper.ImageSizeHelper.Resize(_environment, randomFileName, ImageFile, root, size, width, height, Path.GetExtension(ImageFile.FileName));
            var _anaSayfa_401x289_Thumbnail_Path = Alice.Admin.Helper.ImageSizeHelper.Resize(_environment,randomFileName, ImageFile, root, $"{size}_Thumbnail", 70, 70, Path.GetExtension(ImageFile.FileName));


            _galleryKeywordService.Add(new GalleryKeywordDTO()
            {
                GalleryId = randomFileName,
                KeywordId = KeywordPool
            });

            _galleryPoolService.Add(new GalleryPoolDTO()
            {
                GalleryId = randomFileName,
                Thumbnail = _anaSayfa_401x289_Thumbnail_Path,
                ImagePath = _anaSayfa_401x289_Path,
                ImageSize = size,
                PathExtension = Path.GetExtension(ImageFile.FileName),
                RecordDate = DateTime.Now
            });
        }
    }
}
