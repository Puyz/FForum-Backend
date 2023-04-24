using Core.Repositories.EntityFramework;
using Entities.Concretes;
using Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concretes.EntityFramework
{
    public class EfMessageRepository : EfEntityRepositoryBase<Message, FForumContext>, IMessageRepository
    {
    }
}
