using Core.Utilities.Abstracts;
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
