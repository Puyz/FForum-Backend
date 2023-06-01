using Core.Repositories.EntityFramework;
using Entities.Concretes;
using Repositories.Abstracts;

namespace Repositories.Concretes.EntityFramework
{
    public class EfSubCategoryRepository : EfEntityRepositoryBase<SubCategory, FForumContext>, ISubCategoryRepository
    {

    }
}
