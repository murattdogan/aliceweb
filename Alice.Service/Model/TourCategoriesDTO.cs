using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Service.Model
{
    public class TourCategoriesDTO : BaseModel
    {
        public int TourId { get; set; }
        public int CategoriesId { get; set; }
    }
}
