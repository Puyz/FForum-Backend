using Core.Repositories.EntityFramework;
using Entities.Concretes;
using Entities.DTOs;
using Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concretes.EntityFramework
{
    public class EfCategoryRepository : EfEntityRepositoryBase<Category, FForumContext>, ICategoryRepository
    {
        public List<NavbarCategoryDto> GetAllWithSubCategory()
        {
            using (var context = new FForumContext())
            {
                var result = (from category in context.Categories
                              join subCategory in context.SubCategories! on category.Id equals subCategory.CategoryId into subCategories
                              select new NavbarCategoryDto
                              {
                                  Id = category.Id,
                                  Name = category.Name,
                                  SubCategory = subCategories.ToList()
                              }).ToList();


                return result;
            }
        }
    }
}
