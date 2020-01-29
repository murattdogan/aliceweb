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
    public class TourService
    {
        private IMapper _iMapper;
        private readonly LuxuryContext _dbContext;

        public TourService()
        {
            _dbContext = new LuxuryContext();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Tour, TourDTO>();
            });
            _iMapper = config.CreateMapper();

        }

        public IEnumerable<TourDTO> GetAllTours()
        {
            IRepository<Tour> tourRepository = new Repository<Tour>(_dbContext);
            return tourRepository.All().Select(x => new TourDTO() { Id = x.Id, TourName = x.TourName, OverView = x.OverView, TourActivity = x.TourActivity, TourCode = x.TourCode, TourMap = x.TourMap, TourSpot = x.TourSpot, TourType = x.TourType }).ToList();
        }

        public TourDTO GetTourByTourCode(string tourCode)
        {
            IRepository<Tour> tourRepository = new Repository<Tour>(_dbContext);
            return _iMapper.Map<Tour, TourDTO>(tourRepository.First(x => x.TourCode == tourCode));
        }

        public TourDTO GetTourById(int Id)
        {
            IRepository<Tour> tourRepository = new Repository<Tour>(_dbContext);
            return _iMapper.Map<Tour, TourDTO>(tourRepository.First(x => x.Id == Id));
        }

        public bool Delete(int Id)
        {
            IRepository<Tour> tourRepository = new Repository<Tour>(_dbContext);
            var tourEntity = tourRepository.First(x => x.Id == Id);
            return tourRepository.Delete(tourEntity);
        }

        public bool Insert(TourDTO tour)
        {
            IRepository<Tour> tourRepository = new Repository<Tour>(_dbContext);
            return tourRepository.Add(new Tour()
            {
                OverView = tour.OverView,
                TourActivity = tour.TourActivity,
                RecordDate = DateTime.Now,
                TourCode = tour.TourCode,
                TourMap = "",
                TourName = tour.TourName,
                TourSpot = tour.TourSpot,
                TourType = 0
            });
        }

        public bool Update(TourDTO tour)
        {
            IRepository<Tour> tourRepository = new Repository<Tour>(_dbContext);
            var tourEntity = tourRepository.First(x => x.Id == tour.Id);
            if (tourEntity != null)
            {
                tourEntity.OverView = tour.OverView;
                tourEntity.TourActivity = tour.TourActivity;
                tourEntity.TourCode = tour.TourCode;
                tourEntity.TourMap = tour.TourMap;
                tourEntity.TourName = tour.TourName;
                tourEntity.TourSpot = tour.TourSpot;
                tourEntity.TourType = tour.TourType;
                return tourRepository.Update(tourEntity);
            }
            else return false;
        }
    }
}
