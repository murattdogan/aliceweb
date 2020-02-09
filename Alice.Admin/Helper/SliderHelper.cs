using Alice.Data.Context;
using Alice.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alice.Admin.Helper
{
    public class SliderHelper
    {
        //private readonly LuxuryContext _context;
        //public SliderHelper(LuxuryContext context)
        //{
        //    _context = context;
        //}

        public static string SliderGetImagebyGalleryId(string galleryId)
        {
            if (galleryId == null) return "";
            GalleryPoolService _galleryPoolService = new GalleryPoolService(new LuxuryContext());
            var q = _galleryPoolService.GetByGalleryId(galleryId);
            if (q != null)
            {
                    return $"{q.Thumbnail}\\{q.GalleryId}{q.PathExtension}";
            }
            return "";
        }
    }
}
