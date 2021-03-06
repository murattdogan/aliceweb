﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Data.Model
{
    public class Categories : BaseModel
    {
        public string CategoryName { get; set; }
        public string Path { get; set; }
        public string ImagePath { get; set; }
        public int MainCategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SEOTitle { get; set; }
        public string SEODescription { get; set; }
    }
}
