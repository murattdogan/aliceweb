using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Data.Model
{
    public class GalleryKeyword : BaseModel
    {
        public string GalleryId { get; set; }
        public int KeywordId { get; set; }
    }
}
