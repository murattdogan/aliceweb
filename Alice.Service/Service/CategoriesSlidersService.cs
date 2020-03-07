using Alice.Data.Context;
using Alice.Data.Repository;
using Alice.Service.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alice.Service.Service
{
    public class CategoriesSlidersService
    {
        IRepository<CategoriesSliders> _categoriesSliderRepository;
        private IMapper _iMapper;
        private readonly LuxuryContext _context;
        public CategoriesSlidersService(LuxuryContext context)
        {
            _context = context;
            _categoriesSliderRepository = new Repository<CategoriesSliders>(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CategoriesSliders, CategoriesSlidersDTO>();
            });
            _iMapper = config.CreateMapper();
        }

        public IEnumerable<CategoriesSlidersDTO> GetAllCategories()
        {
            return _iMapper.Map<List<CategoriesSliders>, List<CategoriesSlidersDTO>>(_categoriesSliderRepository.All().ToList());
        }

        public CategoriesSlidersDTO GetById(int Id)
        {
            var category = _categoriesSliderRepository.First(x => x.Id == Id);
            if (category != null)
            {
                return _iMapper.Map<CategoriesSliders, CategoriesSlidersDTO>(category);
            }

            return null;
        }

        public bool AddCategory(CategoriesSlidersDTO categories)
        {
            return _categoriesSliderRepository.Add(new CategoriesSliders()
            {
                CategoryId=categories.CategoryId,
                GalleryId=categories.GalleryId
            });
        }

        public List<CategoriesSlidersDTO> GetGalleriesByCategoryId(int categoryId)
        {
            var categoryGallery = _categoriesSliderRepository.Where(x => x.CategoryId == categoryId).ToList();
            if (categoryGallery.Any())
            {
                return _iMapper.Map<List<CategoriesSliders>, List<CategoriesSlidersDTO>>(categoryGallery);
            }
            return null;
        }

        public bool DeleteCategory(CategoriesSlidersDTO categories)
        {
            var category = _categoriesSliderRepository.First(x => x.Id == categories.Id);
            if (category != null)
            {
                _categoriesSliderRepository.Delete(category);
                return true;
            }

            return false;
        }
    }
}
