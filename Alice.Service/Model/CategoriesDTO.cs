using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Service.Model
{
    class CategoriesDTO : BaseModel
    {
        public string CategoryName { get; set; }
        public string Path { get; set; }
        public int MainCategoryId { get; set; }
    }
}
