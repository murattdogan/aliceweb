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
    public class GalleryPoolService
    {
        IRepository<GalleryPool> _galleryPoolRepository;
        private IMapper _iMapper;
        public GalleryPoolService()
        {
            _galleryPoolRepository = new Repository<GalleryPool>(new LuxuryContext());
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GalleryPool, GalleryPoolDTO>();
            });
            _iMapper = config.CreateMapper();
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

        public List<GalleryPoolDTO> GetAll()
        {
            return _iMapper.Map<List<GalleryPool>, List<GalleryPoolDTO>>(_galleryPoolRepository.All().ToList());
        }

        public bool Delete(GalleryPoolDTO gallery)
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
