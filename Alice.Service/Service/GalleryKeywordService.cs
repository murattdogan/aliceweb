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
    public class GalleryKeywordService
    {
        private IMapper _iMapper;
        IRepository<GalleryKeyword> _galleryKeywordRepository;
        private readonly LuxuryContext _context;
        public GalleryKeywordService(LuxuryContext context)
        {
            _context = context;
            _galleryKeywordRepository = new Repository<GalleryKeyword>(_context);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GalleryKeyword, GalleryKeywordDTO>();
            });
            _iMapper = config.CreateMapper();
        }

        public bool Add(GalleryKeywordDTO gallerykeyword)
        {
            return _galleryKeywordRepository.Add(new GalleryKeyword()
            {
                KeywordId = gallerykeyword.KeywordId,
                GalleryId = gallerykeyword.GalleryId
            });
        }

        public bool Delete(KeywordPoolDTO gallerykeyword)
        {
            var keywordpool = _galleryKeywordRepository.First(x => x.Id == gallerykeyword.Id);
            if (keywordpool != null)
            {
                _galleryKeywordRepository.Delete(keywordpool);
                return true;
            }

            return false;
        }

        public List<GalleryKeywordDTO> GetAllbyKeywordId(int keywordId)
        {
            var keywordpool = _galleryKeywordRepository.Where(x => x.KeywordId == keywordId).ToList();
            if (keywordpool.Any())
            {
                return _iMapper.Map<List<GalleryKeyword>, List<GalleryKeywordDTO>>(keywordpool);
            }
            return null;
        }
    }
}
