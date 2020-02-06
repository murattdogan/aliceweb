using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Data.Model
{
    public class GalleryPool : BaseModel
    {
        public string GalleryId { get; set; }
        public string Thumbnail { get; set; }
        public string Small { get; set; }
        public string Medium { get; set; }
        public string Large { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
