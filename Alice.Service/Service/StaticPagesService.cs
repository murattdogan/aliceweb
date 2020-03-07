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
    public class StaticPagesService
    {
        IRepository<StaticPages> _staticpagesRepository;
        private IMapper _iMapper;
        private readonly LuxuryContext _context;
        public StaticPagesService(LuxuryContext context)
        {
            _context = context;
            _staticpagesRepository = new Repository<StaticPages>(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StaticPages, StaticPagesDTO>();
            });
            _iMapper = config.CreateMapper();
        }

        public StaticPagesDTO GetByUrl(string path)
        {
            return _iMapper.Map<StaticPages, StaticPagesDTO>(_staticpagesRepository.First(x => x.PageUrl == path));

        }

        public StaticPagesDTO GetById(int Id)
        {
            return _iMapper.Map<StaticPages, StaticPagesDTO>(_staticpagesRepository.First(x => x.Id == Id));

        }
        public IEnumerable<StaticPagesDTO> GetAllPages()
        {
            return _iMapper.Map<List<StaticPages>, List<StaticPagesDTO>>(_staticpagesRepository.All().ToList());
        }

       
        public bool Update(StaticPagesDTO staticPages)
        {
            var page = _staticpagesRepository.First(c => c.Id == staticPages.Id);
            if (page != null)
            {
                page.PageUrl = staticPages.PageUrl;
                page.PageTitle = staticPages.PageTitle;
                page.PageBody = staticPages.PageBody;
                page.PageImage = staticPages.PageImage;
                return _staticpagesRepository.Update(page);
            }
            return false;
        }
  
    }
}
