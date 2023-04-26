using Core.Repositories;
using Entities.Concretes;

namespace Repositories.Abstracts
{
    public interface IUserRepository : IEntityRepository<User>
    {
        User GetByUsername(string username);
    }
}
