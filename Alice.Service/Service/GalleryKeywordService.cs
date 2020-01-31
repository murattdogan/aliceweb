using Alice.Data.Context;
using Alice.Data.Model;
using Alice.Data.Repository;
using Alice.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Service.Service
{
    public class GalleryKeywordService
    {
        IRepository<GalleryKeyword> _galleryKeywordRepository;
        public GalleryKeywordService()
        {
            _galleryKeywordRepository = new Repository<GalleryKeyword>(new LuxuryContext());
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
    }
}
