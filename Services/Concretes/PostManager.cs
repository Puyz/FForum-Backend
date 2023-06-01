using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Concretes;
using Entities.DTOs;
using Repositories.Abstracts;
using Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concretes
{
    public class PostManager : IPostService
    {
        IPostRepository postRepository;
        public PostManager(IPostRepository postRepository) { 
            this.postRepository = postRepository;
        }

        public IResult Add(Post post)
        {
            postRepository.Add(post);
            return new SuccessResult("Konu açıldı");
        }

        public IDataResult<List<PostDto>> GetAllWithUser()
        {
            List<PostDto> posts = postRepository.GetAllWithUser();
            return new SuccessDataResult<List<PostDto>>(posts);
        }

        public IDataResult<PostDto> GetPost(int id)
        {
            return new SuccessDataResult<PostDto>(postRepository.GetPost(id));
        }

        
    }
}
