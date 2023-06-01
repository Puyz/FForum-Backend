using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstracts
{
    public interface ISubCategoryService
    {
        IDataResult<List<SubCategory>> GetAllByCategoryId(int id);
    }
}
