using Core.Utilities.Results.Abstracts;
using Entities.DTOs;

namespace Services.Abstracts
{
    public interface IPostService
    {
        IDataResult<List<PostDto>> GetAllWithUser();
    }
}
