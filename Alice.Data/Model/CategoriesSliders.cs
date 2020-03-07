using Alice.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Service.Model
{
    public class CategoriesSliders : BaseModel
    {
        public string GalleryId { get; set; }
        public int CategoryId { get; set; }
    }
}
