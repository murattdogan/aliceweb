using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Service.Model
{
    public class SiteSettingsDTO : BaseModel
    {
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
    }
}
