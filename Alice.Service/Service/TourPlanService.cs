using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alice.Data.Context;
using Alice.Data.Model;
using Alice.Data.Repository;
using Alice.Service.Model;
using AutoMapper;

namespace Alice.Service.Service
{
    public class TourPlanService
    {
        private readonly LuxuryContext _context;
        private readonly IRepository<TourPlanList> _tourPlanRepository;
        private IMapper _iMapper;
        public TourPlanService(LuxuryContext context)
        {
            _context = context;
            _tourPlanRepository = new Repository<TourPlanList>(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TourPlanList, TourPlanListDTO>();
            });
            _iMapper = config.CreateMapper();
        }

        public IEnumerable<TourPlanListDTO> GetAll()
        {
            return _tourPlanRepository.All().Select(x => new TourPlanListDTO() { Id = x.Id, DayDetail = x.DayDetail, Day = x.Day, DayTitle = x.DayTitle, TourId = x.TourId }).ToList();
        }

        public TourPlanListDTO GetById(int Id)
        {
            return _iMapper.Map<TourPlanList, TourPlanListDTO>(_tourPlanRepository.First(x => x.Id == Id));
        }

        public bool Add(TourPlanListDTO tourPlan)
        {
            return _tourPlanRepository.Add(new TourPlanList()
            {
                Day = tourPlan.Day,
                DayDetail = tourPlan.DayDetail,
                DayTitle = tourPlan.DayTitle,
                TourId = tourPlan.TourId
            });
        }

        public bool Update(TourPlanListDTO tourPlan)
        {
            var t = _tourPlanRepository.First(x => x.Id == tourPlan.Id);
            if (t != null)
            {
                t.Day = tourPlan.Day;
                t.DayTitle = tourPlan.DayTitle;
                t.DayDetail = tourPlan.DayDetail;
                t.TourId = tourPlan.TourId;
                return _tourPlanRepository.Update(t);
            }
            return false;
        }

        public bool Delete(int tourDayId)
        {
            var t = _tourPlanRepository.First(x => x.Id == tourDayId);
            if (t != null)
            {
                return _tourPlanRepository.Delete(t);
            }
            return false;
        }
    }
}
