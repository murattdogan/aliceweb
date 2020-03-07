using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Data.Model
{
    public class StaticPages : BaseModel
    {
        public string PageTitle { get; set; }
        public string PageBody { get; set; }
        public string PageUrl { get; set; }
        public string PageImage { get; set; }
    }
}
