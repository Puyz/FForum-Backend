using Core.Repositories;
using Entities.Concretes;
using Entities.DTOs;

namespace Repositories.Abstracts
{
    public interface IMessageRepository : IEntityRepository<Message>
    {
        List<MessageDto> GetMessagesByPostId(int postId);
    }
}
