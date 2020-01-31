using Alice.Data.Context;
using Alice.Data.Model;
using Alice.Data.Repository;
using Alice.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Service.Service
{
    public class GalleryPoolService
    {
        IRepository<GalleryPool> _galleryPoolRepository;
        public GalleryPoolService()
        {
            _galleryPoolRepository = new Repository<GalleryPool>(new LuxuryContext());
        }

        public bool Add(GalleryPoolDTO gallery)
        {
            return _galleryPoolRepository.Add(new GalleryPool()
            {
                Height = gallery.Height,
                Width = gallery.Width,
                Path = gallery.Path,
                RecordDate = DateTime.Now
            });
        }
     
        public bool Delete(GalleryPool gallery)
        {
            var category = _galleryPoolRepository.First(x => x.Id == gallery.Id);
            if (category != null)
            {
                _galleryPoolRepository.Delete(category);
                return true;
            }

            return false;
        }

    }
}
