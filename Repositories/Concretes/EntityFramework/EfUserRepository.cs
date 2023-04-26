using Core.Repositories.EntityFramework;
using Entities.Concretes;
using Repositories.Abstracts;

namespace Repositories.Concretes.EntityFramework
{
    public class EfUserRepository : EfEntityRepositoryBase<User, FForumContext>, IUserRepository
    {


        public User GetByUsername(string username)
        {
            using (var context = new FForumContext())
            {
                var result = from user in context.Users where user.Username == username select user;
                return result.SingleOrDefault()!;
            }
        }
    }
}
