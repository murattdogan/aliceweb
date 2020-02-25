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
        public static void SaveGalleryPool(string randomFileName, IFormFile ImageFile, string size, GalleryKeywordService _galleryKeywordService
            , GalleryPoolService _galleryPoolService, int KeywordPool, int width, int height)
        {
            //var img = Path.Combine(_environment.ContentRootPath, "Content/UI/Image", $"large-{randomFileName}{Path.GetExtension(ImageFile.FileName)}");
            try
            {
                var imageFile = Alice.Admin.Helper.ImageSizeHelper.Resize(randomFileName, ImageFile, size, width, height, Path.GetExtension(ImageFile.FileName));
                var imageFile_Thumbnail = Alice.Admin.Helper.ImageSizeHelper.Resize(randomFileName, ImageFile, $"{size}_Thumbnail", 70, 70, Path.GetExtension(ImageFile.FileName));
                _galleryKeywordService.Add(new GalleryKeywordDTO()
                {
                    GalleryId = randomFileName,
                    KeywordId = KeywordPool
                });

                _galleryPoolService.Add(new GalleryPoolDTO()
                {
                    GalleryId = randomFileName,
                    Thumbnail = imageFile_Thumbnail,
                    ImagePath = imageFile,
                    ImageSize = size,
                    PathExtension = Path.GetExtension(ImageFile.FileName),
                    RecordDate = DateTime.Now
                });
            }
            catch (Exception e)
            {
                _galleryPoolService.Add(new GalleryPoolDTO()
                {
                    GalleryId = "12334556123",
                    Thumbnail = e.Message,
                    ImagePath = "",
                    ImageSize = size,
                    PathExtension = Path.GetExtension(ImageFile.FileName),
                    RecordDate = DateTime.Now
                });
                throw;
            }

            
        }
    }
}
