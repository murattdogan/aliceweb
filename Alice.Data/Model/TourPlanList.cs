using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Data.Model
{
    public class TourPlanList: BaseModel
    {
        public int Day { get; set; }
        public int TourId { get; set; }
        public string DayTitle { get; set; }
        public string DayDetail{ get; set; }
    }
}
