using Alice.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alice.Admin.Models
{
    public class PageImages
    {
        public static string GetImage(string galleryId, GalleryPoolService _galleryPoolService)
        {
            string image = "";
            var t = _galleryPoolService.GetByGalleryId(galleryId);
            if (t != null)
            {
                image = $"console.luxuryistanbul.com\\{t.ImagePath}\\{t.GalleryId}{t.PathExtension}".Replace("\\", @"/").Replace("//", "/");
                image = $"http://{image}";
            }
            return image;
        }
    }
}
