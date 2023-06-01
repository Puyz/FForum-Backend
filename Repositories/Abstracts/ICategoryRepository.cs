using Core.Repositories;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Abstracts
{
    public interface ICategoryRepository : IEntityRepository<Category>
    {
        List<NavbarCategoryDto> GetAllWithSubCategory();
    }
}
