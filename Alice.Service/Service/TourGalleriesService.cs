using Alice.Data.Context;
using Alice.Data.Model;
using Alice.Data.Repository;
using Alice.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Service.Service
{
    public class TourGalleriesService
    {
        IRepository<TourGalleries> _tourGalleriesRepository;
        public TourGalleriesService()
        {
            _tourGalleriesRepository = new Repository<TourGalleries>(new LuxuryContext());
        }


        public bool Add(TourGalleriesDTO tourGalleries)
        {
            return _tourGalleriesRepository.Add(new TourGalleries()
            {
                GalleryId = tourGalleries.GalleryId,
                TourId = tourGalleries.TourId
            });
        }

        public bool Delete(TourGalleriesDTO tourGalleries)
        {
            var tourGallery = _tourGalleriesRepository.First(x => x.Id == tourGalleries.Id);
            if (tourGallery != null)
            {
                _tourGalleriesRepository.Delete(tourGallery);
                return true;
            }

            return false;
        }
    }
}
