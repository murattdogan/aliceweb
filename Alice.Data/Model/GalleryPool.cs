using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Data.Model
{
    public class GalleryPool : BaseModel
    {
        public string GalleryId { get; set; }
        public string Thumbnail { get; set; }
        public string ImageSize { get; set; }
        public string ImagePath { get; set; }
        public string PathExtension { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
