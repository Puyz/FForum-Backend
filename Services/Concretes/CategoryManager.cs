using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Concretes;
using Entities.DTOs;
using Repositories.Abstracts;
using Services.Abstracts;

namespace Services.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryRepository categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(categoryRepository.GetAll());
        }

        public IDataResult<List<NavbarCategoryDto>> GetAllWithSubCategory()
        {
            return new SuccessDataResult<List<NavbarCategoryDto>>(categoryRepository.GetAllWithSubCategory());
        }
    }
}
