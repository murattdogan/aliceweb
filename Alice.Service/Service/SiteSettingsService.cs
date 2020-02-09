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
    public class SiteSettingsService
    {
        private IMapper _iMapper;
        private readonly LuxuryContext _context;
        private readonly IRepository<SiteSettings> _sitesettingsRepository;

        public SiteSettingsService(LuxuryContext context)
        {
            _context = context;
            _sitesettingsRepository = new Repository<SiteSettings>(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SiteSettings, SiteSettingsDTO>();
            });
            _iMapper = config.CreateMapper();

        }

        public IEnumerable<SiteSettingsDTO> GetAll()
        {
            return _iMapper.Map<List<SiteSettings>, List<SiteSettingsDTO>>(_sitesettingsRepository.All().ToList());
        }


        public SiteSettingsDTO GetFirstByFieldName(string fieldName)
        {
            return _iMapper.Map<SiteSettings, SiteSettingsDTO>(_sitesettingsRepository.First(x => x.FieldName == fieldName));
        }

        public bool Delete(int Id)
        {
            var entity = _sitesettingsRepository.First(x => x.Id == Id);
            return _sitesettingsRepository.Delete(entity);
        }

        public bool Insert(SiteSettingsDTO siteSettings)
        {
            return _sitesettingsRepository.Add(new SiteSettings()
            {
                FieldName = siteSettings.FieldName,
                FieldValue = siteSettings.FieldValue
            });
        }

        public bool Update(SiteSettingsDTO siteSettings)
        {
            var entity = _sitesettingsRepository.First(x => x.Id == siteSettings.Id);
            if (entity != null)
            {
                entity.FieldName = siteSettings.FieldName;
                entity.FieldValue = siteSettings.FieldValue;
                return _sitesettingsRepository.Update(entity);
            }
            else return false;
        }
    }
}
