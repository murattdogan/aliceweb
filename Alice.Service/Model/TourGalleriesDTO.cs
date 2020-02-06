using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Service.Model
{
    public class TourGalleriesDTO : BaseModel
    {
        public int TourId { get; set; }
        public string GalleryId { get; set; }
    }
}
