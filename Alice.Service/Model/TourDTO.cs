using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Service.Model
{
    [Serializable]
    public class TourDTO : BaseModel
    {
        public string TourName { get; set; }
        public string TourCode { get; set; }
        public int TourType { get; set; }
        public int TourActivity { get; set; }
        public string OverView { get; set; }
        public string TourMap { get; set; }
        public string TourSpot { get; set; }
        public string TourBody { get; set; }
        public string RecordDate { get; set; }
    }
}
