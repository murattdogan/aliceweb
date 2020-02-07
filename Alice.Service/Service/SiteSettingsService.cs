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
        private readonly LuxuryContext _dbContext;

        public SiteSettingsService()
        {
            _dbContext = new LuxuryContext();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SiteSettings, SiteSettingsDTO>();
            });
            _iMapper = config.CreateMapper();

        }

        public IEnumerable<SiteSettingsDTO> GetAll()
        {
            IRepository<SiteSettings> sitesettingsRepository = new Repository<SiteSettings>(_dbContext);
            return _iMapper.Map<List<SiteSettings>, List<SiteSettingsDTO>>(sitesettingsRepository.All().ToList());
        }


        public SiteSettingsDTO GetFirstByFieldName(string fieldName)
        {
            IRepository<SiteSettings> sitesettingsRepository = new Repository<SiteSettings>(_dbContext);
            return _iMapper.Map<SiteSettings, SiteSettingsDTO>(sitesettingsRepository.First(x => x.FieldName == fieldName));
        }

        public bool Delete(int Id)
        {
            IRepository<SiteSettings> sitesettingsRepository = new Repository<SiteSettings>(_dbContext);
            var entity = sitesettingsRepository.First(x => x.Id == Id);
            return sitesettingsRepository.Delete(entity);
        }

        public bool Insert(SiteSettingsDTO siteSettings)
        {
            IRepository<SiteSettings> sitesettingsRepository = new Repository<SiteSettings>(_dbContext);
            return sitesettingsRepository.Add(new SiteSettings()
            {
                FieldName = siteSettings.FieldName,
                FieldValue = siteSettings.FieldValue
            });
        }

        public bool Update(SiteSettingsDTO siteSettings)
        {
            IRepository<SiteSettings> sitesettingsRepository = new Repository<SiteSettings>(_dbContext);
            var entity = sitesettingsRepository.First(x => x.Id == siteSettings.Id);
            if (entity != null)
            {
                entity.FieldName = siteSettings.FieldName;
                entity.FieldValue = siteSettings.FieldValue;
                return sitesettingsRepository.Update(entity);
            }
            else return false;
        }
    }
}
