using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Entities.DTOs;

namespace Services.Abstracts
{
    public interface IPostService
    {
        IDataResult<List<PostDto>> GetAllWithUser();
        IDataResult<PostDto> GetPost(int id);
        IResult Add(Post post);
    }
}
