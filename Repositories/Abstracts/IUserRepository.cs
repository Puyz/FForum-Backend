﻿using Core.Repositories;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Abstracts
{
    public interface IUserRepository : IEntityRepository<User>
    {
        User GetByUsername(string username);
    }
}