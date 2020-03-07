using Alice.Service.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Service.Model
{
    public class CategoriesSlidersDTO : BaseModel
    {
        public string GalleryId { get; set; }
        public int CategoryId { get; set; }
    }
}
