using Alice.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alice.Admin.Models
{
    public class TourCategoryViewModel
    {
        public IEnumerable<CategoriesDTO> AllCategories { get; set; }
        public IEnumerable<KeywordPoolDTO> SelectAllKeyword { get; set; }
        public IEnumerable<TourCategoriesDTO> SelectAllCategories { get; set; }
        public IEnumerable<GalleryPoolDTO> GalleryPhotos { get; set; }
    }
}
