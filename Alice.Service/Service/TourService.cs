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
        private readonly LuxuryContext _context;
        private readonly IRepository<Tour> _tourRepository;

        public TourService(LuxuryContext context)
        {
            _context = context;
            _tourRepository = new Repository<Tour>(_context);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Tour, TourDTO>();
            });
            _iMapper = config.CreateMapper();

        }

        public IEnumerable<TourDTO> GetAllTours()
        {
            return _iMapper.Map<List<Tour>, List<TourDTO>>(_tourRepository.All().ToList());
        }

        public TourDTO GetTourByTourCode(string tourCode)
        {
            return _iMapper.Map<Tour, TourDTO>(_tourRepository.First(x => x.TourCode == tourCode));
        }

        public TourDTO GetTourById(int Id)
        {
            return _iMapper.Map<Tour, TourDTO>(_tourRepository.First(x => x.Id == Id));
        }

        public bool Delete(int Id)
        {
            var tourEntity = _tourRepository.First(x => x.Id == Id);
            return _tourRepository.Delete(tourEntity);
        }

        public bool Insert(TourDTO tour)
        {
            return _tourRepository.Add(new Tour()
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
            var tourEntity = _tourRepository.First(x => x.Id == tour.Id);
            if (tourEntity != null)
            {
                tourEntity.OverView = tour.OverView;
                tourEntity.TourActivity = tour.TourActivity;
                tourEntity.TourCode = tour.TourCode;
                tourEntity.TourMap = tour.TourMap;
                tourEntity.TourName = tour.TourName;
                tourEntity.TourSpot = tour.TourSpot;
                tourEntity.TourType = tour.TourType;
                return _tourRepository.Update(tourEntity);
            }
            else return false;
        }
    }
}
