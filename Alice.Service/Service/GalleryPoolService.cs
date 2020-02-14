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
        private readonly LuxuryContext _context;
        private IMapper _iMapper;
        public GalleryPoolService(LuxuryContext context)
        {
            _context = context;

            _galleryPoolRepository = new Repository<GalleryPool>(_context);
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
                GalleryId = gallery.GalleryId,
                Thumbnail = gallery.Thumbnail,
                ImagePath= gallery.ImagePath,
                ImageSize= gallery.ImageSize,
                PathExtension= gallery.PathExtension,
                RecordDate = DateTime.Now
            });
        }

        public List<GalleryPoolDTO> GetAll()
        {
            return _iMapper.Map<List<GalleryPool>, List<GalleryPoolDTO>>(_galleryPoolRepository.All().ToList());
        }

        public GalleryPoolDTO GetFirst(int Id)
        {
            return _iMapper.Map<GalleryPool, GalleryPoolDTO>(_galleryPoolRepository.First(x=> x.Id== Id));
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

        public GalleryPoolDTO GetByGalleryId(string galleryId)
        {
            return _iMapper.Map<GalleryPool, GalleryPoolDTO>(_galleryPoolRepository.First(x => x.GalleryId == galleryId));
        }

    }
}
