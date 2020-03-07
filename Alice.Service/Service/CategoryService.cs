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
    public class CategoryService
    {
        IRepository<Categories> _categoryRepository;
        private IMapper _iMapper;
        private readonly LuxuryContext _context;
        public CategoryService(LuxuryContext context)
        {
            _context = context;
            _categoryRepository = new Repository<Categories>(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Categories, CategoriesDTO>();
            });
            _iMapper = config.CreateMapper();
        }

        public CategoriesDTO GetByUrl(string path)
        {
            return _iMapper.Map<Categories, CategoriesDTO>(_categoryRepository.First(x => x.Path == path));

        }
        public IEnumerable<CategoriesDTO> GetAllCategories()
        {
            return _categoryRepository.All().Select(x => new CategoriesDTO() { Id = x.Id, CategoryName = x.CategoryName, Path = x.Path, MainCategoryId = x.MainCategoryId }).ToList();
        }

        public IEnumerable<CategoriesDTO> GetAllSubCategories(int mainCategoryId)
        {
            return _iMapper.Map<List<Categories>, List<CategoriesDTO>>(_categoryRepository.All().Where(x => x.MainCategoryId == mainCategoryId).ToList());
        }
        public CategoriesDTO GetById(int Id)
        {
            var category = _categoryRepository.First(x => x.Id == Id);
            if (category != null)
            {
                return new CategoriesDTO() { Id = category.Id, CategoryName = category.CategoryName, Path = category.Path, MainCategoryId = category.MainCategoryId, ImagePath = category.ImagePath, SEOTitle = category.SEOTitle, SEODescription = category.SEODescription, Title = category.Title, Description=category.Description };
            }

            return null;
        }

        public bool AddCategory(CategoriesDTO categories)
        {
            return _categoryRepository.Add(new Categories()
            {
                CategoryName = categories.CategoryName,
                MainCategoryId = categories.MainCategoryId,
                Path = categories.Path,
                ImagePath = categories.ImagePath
            });
        }
        public bool UploadCategory(CategoriesDTO categories)
        {
            var oldCategory = _categoryRepository.First(c => c.Id == categories.Id);
            if (oldCategory != null)
            {
                oldCategory.CategoryName = categories.CategoryName;
                oldCategory.Path = categories.Path;
                oldCategory.MainCategoryId = categories.MainCategoryId;
                if (categories.ImagePath != "")
                    oldCategory.ImagePath = categories.ImagePath;
                oldCategory.SEODescription = categories.SEODescription;
                oldCategory.SEOTitle = categories.SEOTitle;
                oldCategory.Description = categories.Description;
                oldCategory.Title = categories.Title;

            }
            return _categoryRepository.Update(oldCategory);
        }
        public bool DeleteCategory(CategoriesDTO categories)
        {
            var category = _categoryRepository.First(x => x.Id == categories.Id);
            if (category != null)
            {
                _categoryRepository.Delete(category);
                return true;
            }

            return false;
        }
    }
}
