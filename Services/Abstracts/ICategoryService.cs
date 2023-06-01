using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Entities.DTOs;

namespace Services.Abstracts
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<List<NavbarCategoryDto>> GetAllWithSubCategory();
    }
}
