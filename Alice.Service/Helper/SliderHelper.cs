using Alice.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alice.Service.Helper
{
    public class SliderHelper
    {
        public static string SliderGetImagebyGalleryId(string galleryId)
        {
            GalleryPoolService _galleryPoolService = new GalleryPoolService();
            var q = _galleryPoolService.GetByGalleryId(galleryId);
            if (q != null)
            {
                return _galleryPoolService.GetByGalleryId(galleryId)?.Large?.ToString() ?? string.Empty;
            }
            return "";
        }
    }
}
