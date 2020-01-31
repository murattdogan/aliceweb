using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Data.Model
{
    public class TourGalleries : BaseModel
    {
        public int TourId { get; set; }
        public int GalleryId { get; set; }
    }
}
