using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Data.Model
{
    public class GalleryPool : BaseModel
    {
        public string Path { get; set; }
        public string Width{ get; set; }
        public string Height { get; set; }
        public DateTime RecordDate { get; set; }
    }
}
