using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Data.Model
{
    public class Tour : BaseModel
    {
        public string TourName { get; set; }
        public string TourSliderImage { get; set; }
        public string TourImage { get; set; }
        public string TourCode { get; set; }
        public int TourType { get; set; }
        public int TourActivity { get; set; }
        public string OverView { get; set; }
        public string TourMap { get; set; }
        public string TourSpot { get; set; }
        public string TourUrl { get; set; }
        public DateTime RecordDate { get; set; }
        public string SEOTitle { get; set; }
        public string SEODescription { get; set; }
        public string TourMapImage { get; set; }
        public string TourMapDesc { get; set; }
        public string TourMorning { get; set; }
        public string TourLunch { get; set; }
        public string TourAfternoon { get; set; }
        public string Notes { get; set; }
    }
}
