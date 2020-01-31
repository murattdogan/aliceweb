using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Service.Model
{
    public class GalleryPoolDTO : BaseModel
    {
        public string Path { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
