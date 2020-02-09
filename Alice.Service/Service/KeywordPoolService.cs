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
    public class KeywordPoolService
    {
        private IMapper _iMapper;
        private readonly LuxuryContext _context;
        IRepository<KeywordPool> _keywordPoolRepository;
        public KeywordPoolService(LuxuryContext context)
        {
            _context = context;
            _keywordPoolRepository = new Repository<KeywordPool>(_context);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<KeywordPool, KeywordPoolDTO>();
            });
            _iMapper = config.CreateMapper();
        }

        public bool Add(KeywordPoolDTO keywordpool)
        {
            return _keywordPoolRepository.Add(new KeywordPool()
            {
                Keyword = keywordpool.Keyword
            });
        }

        public bool Delete(KeywordPoolDTO keyword)
        {
            var keywordpool = _keywordPoolRepository.First(x => x.Id == keyword.Id);
            if (keywordpool != null)
            {
                _keywordPoolRepository.Delete(keywordpool);
                return true;
            }

            return false;
        }

        public List<KeywordPoolDTO> GetAll()
        {
            return _iMapper.Map<List<KeywordPool>, List<KeywordPoolDTO>>(_keywordPoolRepository.All().ToList());
        }

        public List<KeywordPoolDTO> GetTake(int take)
        {
            return _iMapper.Map<List<KeywordPool>, List<KeywordPoolDTO>>(_keywordPoolRepository.AllTake(take).ToList());
        }

        public KeywordPoolDTO GetByKeyword(string keyword)
        {
            return _iMapper.Map<KeywordPool, KeywordPoolDTO>(_keywordPoolRepository.First(x => x.Keyword == keyword));
        }
    }

}
