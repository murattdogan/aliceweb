using Alice.Data.Context;
using Alice.Data.Model;
using Alice.Data.Repository;
using Alice.Service.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alice.Service.Service
{
    public class TourGalleriesService
    {
        private IMapper _iMapper;
        IRepository<TourGalleries> _tourGalleriesRepository;
        IRepository<GalleryPool> _galleryPoolRepository;
        private readonly LuxuryContext _context;
        public TourGalleriesService(LuxuryContext context)
        {
            _context = context;
            _galleryPoolRepository = new Repository<GalleryPool>(_context);
            _tourGalleriesRepository = new Repository<TourGalleries>(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TourGalleries, TourGalleriesDTO>();
            });
            _iMapper = config.CreateMapper();
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

        private string GetImage(string galleryId)
        {
            string image = "";
            var t = _galleryPoolRepository.First(x => x.GalleryId == galleryId);
            if (t != null)
            {
                image = $"console.luxuryistanbul.com\\{t.ImagePath}\\{t.GalleryId}{t.PathExtension}".Replace("\\", @"/").Replace("//", "/");
                image = $"http://{image}";
            }

            return image;
        }

        public List<TourGalleriesDTO> GetGalleriesByTourId(int tourId)
        {
            var tourGallery = _tourGalleriesRepository.Where(x => x.TourId == tourId).ToList();
            if (tourGallery.Any())
            {
                foreach (var item in tourGallery)
                {
                    var q = "";
                    q = GetImage(item.GalleryId);
                    item.GalleryId = q;
                }
                return _iMapper.Map<List<TourGalleries>, List<TourGalleriesDTO>>(tourGallery);
            }

            return null;

        }

    }
}
