using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Entities.DTOs;

namespace Services.Abstracts
{
    public interface IUserService
    {
        IDataResult<List<UserDto>> GetAllWithRank();
        IDataResult<User> GetByUsername(string username);
        IResult Add(User user);
    }
}
