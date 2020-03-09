using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Service.Model
{
    public class TourPlanListDTO : BaseModel
    {
        public int Day { get; set; }
        public int TourId { get; set; }
        public string DayTitle { get; set; }
        public string DayDetail { get; set; }
    }
}
