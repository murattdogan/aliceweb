using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Service.Model
{
    public class GalleryPoolDTO : BaseModel
    {
        public string GalleryId { get; set; }
        public string Thumbnail { get; set; }
        public string Small { get; set; }
        public string Medium { get; set; }
        public string Large { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
