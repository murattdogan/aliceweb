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
    public class TourCategoriesService
    {
        private IMapper _iMapper;
        IRepository<TourCategories> _tourCategoriesRepository;
        private readonly LuxuryContext _context;
        public TourCategoriesService(LuxuryContext context)
        {
            _context = context;
            _tourCategoriesRepository = new Repository<TourCategories>(_context);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TourCategories, TourCategoriesDTO>();
            });
            _iMapper = config.CreateMapper();
        }

        public IEnumerable<TourCategoriesDTO> GetAllCategories()
        {
            return _iMapper.Map<List<TourCategories>, List<TourCategoriesDTO>>(_tourCategoriesRepository.All().ToList());
        }

        public IEnumerable<TourCategoriesDTO> GetAllByTourIdCategories(int TourId)
        {
            return _iMapper.Map<List<TourCategories>, List<TourCategoriesDTO>>(_tourCategoriesRepository.Where(x => x.TourId == TourId).ToList());
        }

        public bool Insert(TourCategoriesDTO data)
        {
            return _tourCategoriesRepository.Add(new TourCategories()
            {
                CategoriesId = data.CategoriesId,
                TourId = data.TourId
            });
        }

        public bool Delete(TourCategoriesDTO data)
        {
            var category = _tourCategoriesRepository.First(x => x.Id == data.Id);
            if (category != null)
            {
                _tourCategoriesRepository.Delete(category);
                return true;
            }
            else return false;
        }

        public bool DeleteAllByTourId(int tourId)
        {
            var category = _tourCategoriesRepository.Where(x => x.TourId == tourId);

            if (category.Count() > 0)
            {
                foreach (var item in category)
                {
                    _tourCategoriesRepository.Delete(item);
                }
                return true;
            }
            else return false;
        }
    }
}