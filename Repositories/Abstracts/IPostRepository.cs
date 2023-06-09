﻿using Core.Repositories;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Abstracts
{
    public interface IPostRepository : IEntityRepository<Post>
    {
        List<PostDto> GetAllWithUser();
        PostDto GetPost(int id);
    }
}
