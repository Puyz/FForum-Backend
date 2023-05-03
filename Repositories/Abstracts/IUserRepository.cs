using Core.Repositories;
using Entities.Concretes;
using Entities.DTOs;

namespace Repositories.Abstracts
{
    public interface IUserRepository : IEntityRepository<User>
    {
        List<UserDto> GetAllWithRank();
        User GetByUsername(string username);
    }
}
