using Core.Repositories;
using Entities.Concretes;
using Entities.DTOs;

namespace Repositories.Abstracts
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {
        List<NavbarCategoryDto> GetAllWithSubCategory();
    }
}
