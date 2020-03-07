using Alice.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alice.Web.Models
{
    public class CategoryModel
    {
        public List<string> GalleryId { get; set; }
        public List<string> ImagePath { get; set; }
        public Dictionary<int, string> CategoryImageList { get; set; }
        public Dictionary<int, string> NewCategoryImageList { get; set; }

        private readonly GalleryPoolService _galleryPoolService;
        public CategoryModel(GalleryPoolService galleryPoolService, List<string> galleryIds, Dictionary<int, string> cilist)
        {
            ImagePath = new List<string>();
            CategoryImageList = new Dictionary<int, string>();
            NewCategoryImageList = new Dictionary<int, string>();
            GalleryId = galleryIds;
            CategoryImageList = cilist;
            _galleryPoolService = galleryPoolService;
            if (GalleryId != null && GalleryId.Count != 0)
            {
                GalleryId.ForEach(x => ImagePath.Add(GetImage(x)));
            }

            if (CategoryImageList != null && CategoryImageList.Count != 0)
            {
                foreach (var item in CategoryImageList)
                {
                    AddOrUpdateDictionaryEntry(item.Key, GetImage(item.Value));
                }
            }
        }

        public void AddOrUpdateDictionaryEntry(int key, string value)
        {
            if (NewCategoryImageList.ContainsKey(key))
            {
                NewCategoryImageList[key] = value;
            }
            else
            {
                NewCategoryImageList.Add(key, value);
            }
        }

        private string GetImage(string galleryId)
        {
            string image = "";
            var t = _galleryPoolService.GetByGalleryId(galleryId);
            if (t != null)
            {
                image = $"console.luxuryistanbul.com\\{t.ImagePath}\\{t.GalleryId}{t.PathExtension}".Replace("\\", @"/").Replace("//", "/");
                image = $"http://{image}";
            }

            return image;
        }
    }
}
