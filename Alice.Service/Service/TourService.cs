using Alice.Data.Context;
using Alice.Data.Model;
using Alice.Data.Repository;
using Alice.Service.Helper;
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
        IRepository<TourCategories> _tourCategoriesService;

        public TourService(LuxuryContext context)
        {
            _context = context;
            _tourRepository = new Repository<Tour>(_context);
            _tourCategoriesService = new Repository<TourCategories>(_context);

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

        public TourDTO GetTourByUrl(string tourUrl)
        {
            return _iMapper.Map<Tour, TourDTO>(_tourRepository.First(x => x.TourUrl == tourUrl));
        }

        public List<TourCategoriesDTO> GetTourByCategoryId(int categoryId)
        {
            var t = _tourCategoriesService.Where(x => x.CategoriesId == categoryId).ToList();
            if (t.Count() > 0)
            {
                var tlist = new List<TourCategoriesDTO>();
                foreach (var item in t)
                {
                    tlist.Add(new TourCategoriesDTO()
                    {
                        CategoriesId = item.CategoriesId,
                        CategoriesName = item.CategoriesName,
                        TourId = item.TourId
                    });
                }

                return tlist;
            }
            else
            {
                return new List<TourCategoriesDTO>() { };
            }
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
                TourSliderImage = tour.TourSliderImage,
                TourImage = tour.TourImage,
                TourType = 0,
                SEOTitle = tour.SEOTitle,
                SEODescription = tour.SEODescription,
                TourUrl = ConstHelper.UrlFriendly(tour.TourName)
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
                tourEntity.TourImage = tour.TourImage;
                tourEntity.TourSliderImage = tour.TourSliderImage;
                tourEntity.SEOTitle = tour.SEOTitle;
                tourEntity.SEODescription = tour.SEODescription;
                tourEntity.TourMapDesc = tour.TourMapDesc;
                tourEntity.TourMapImage = tour.TourMapImage;
                tourEntity.TourUrl = ConstHelper.UrlFriendly(tour.TourName);
                return _tourRepository.Update(tourEntity);
            }
            else return false;
        }
    }
}
