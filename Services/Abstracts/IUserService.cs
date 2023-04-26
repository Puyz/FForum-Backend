using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Services.Abstracts
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByUsername(string username);
        IResult Add(User user);
    }
}
