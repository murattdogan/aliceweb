using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Service.Model
{
    public class StaticPagesDTO : BaseModel
    {
        public string PageTitle { get; set; }
        public string PageBody { get; set; }
        public string PageUrl { get; set; }
        public string PageImage { get; set; }
    }
}
