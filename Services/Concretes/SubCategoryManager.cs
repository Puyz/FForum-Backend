using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Concretes;
using Repositories.Abstracts;
using Services.Abstracts;

namespace Services.Concretes
{
    public class SubCategoryManager : ISubCategoryService
    {
        ISubCategoryRepository subCategoryRepository;

        public SubCategoryManager(ISubCategoryRepository subCategoryRepository)
        {
            this.subCategoryRepository = subCategoryRepository;
        }
        public IDataResult<List<SubCategory>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<SubCategory>>(subCategoryRepository.GetAll(sc => sc.CategoryId == id));
        }
    }
}
