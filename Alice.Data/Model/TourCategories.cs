using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Data.Model
{
    public class TourCategories : BaseModel
    {
        public int TourId { get; set; }
        public int CategoriesId { get; set; }
        public string CategoriesName { get; set; }
    }
}
