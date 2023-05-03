using Core.Repositories.EntityFramework;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstracts;

namespace Repositories.Concretes.EntityFramework
{
    public class EfUserRepository : EfEntityRepositoryBase<User, FForumContext>, IUserRepository
    {
        public List<UserDto> GetAllWithRank()
        {
            using (var context = new FForumContext())
            {
                var result = (from user in context.Users
                             join rank in context.Ranks! on user.RankId equals rank.Id
                             select new UserDto
                             {
                                 UserId = user.Id,
                                 Rank = rank,
                                 Username = user.Username,
                                 Fullname = user.Fullname,
                                 Email = user.Email,
                                 Image = user.Image,
                                 About = user.About,
                                 DateOfBirth = user.DateOfBirth,
                                 CreatedDate = user.CreatedDate
                             }).ToList();


                return result;
            }
        }

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
