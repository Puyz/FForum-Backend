using Core.Repositories.EntityFramework;
using Entities.Concretes;
using Entities.DTOs;
using Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concretes.EntityFramework
{

    public class EfPostRepository : EfEntityRepositoryBase<Post, FForumContext>, IPostRepository
    {
        public List<PostDto> GetAllWithUser()
        {
            using (var context = new FForumContext())
            {
                var result = (from post in context.Posts
                              join user in context.Users! on post.UserId equals user.Id
                              join category in context.Categories! on post.CategoryId equals category.Id
                              join subCategory in context.SubCategories! on post.SubCategoryId equals subCategory.Id 
                              into subCategories from subCategory in subCategories.DefaultIfEmpty()
                              select new PostDto
                              {
                                  PostId = post.Id,
                                  User = new PostUserDto
                                  {
                                      UserId = user.Id,
                                      Username = user.Username,
                                      Fullname = user.Fullname,
                                      Image = user.Image
                                  },
                                  Category = category,
                                  SubCategory = subCategory!,
                                  Title = post.Title,
                                  Description = post.Description,
                                  CreatedDate = post.CreatedDate,
                                  IsActive = post.IsActive

                              }).ToList();


                return result;
            }
        }
    }
}
