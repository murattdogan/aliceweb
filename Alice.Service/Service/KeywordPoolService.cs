using Alice.Data.Context;
using Alice.Data.Model;
using Alice.Data.Repository;
using Alice.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alice.Service.Service
{
    public class KeywordPoolService
    {
        IRepository<KeywordPool> _keywordPoolRepository;
        public KeywordPoolService()
        {
            _keywordPoolRepository = new Repository<KeywordPool>(new LuxuryContext());
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

    }

}
