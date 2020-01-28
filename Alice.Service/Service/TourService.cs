using Alice.Data.Context;
using Alice.Data.Model;
using Alice.Data.Repository;
using Alice.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alice.Service.Service
{
    public class TourService
    {
        private readonly LuxuryContext _dbContext;

        public TourService()
        {
            _dbContext = new LuxuryContext();
        }

        public IEnumerable<TourDTO> GetAllTours()
        {
            IRepository<Tour> tourRepository = new Repository<Tour>(_dbContext);
            return tourRepository.All().Select(x => new TourDTO() { Id = x.Id, TourName=x.TourName, OverView = x.OverView, TourActivity = x.TourActivity, TourCode = x.TourCode, TourMap = x.TourMap, TourSpot = x.TourSpot, TourType = x.TourType }).ToList();
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
                OverView = tour.TourBody,
                TourActivity = 0,
                RecordDate = DateTime.Now,
                TourCode = "",
                TourMap = "",
                TourName = tour.TourName,
                TourSpot = tour.TourSpot,
                TourType = 0
            });
        }
    }
}
