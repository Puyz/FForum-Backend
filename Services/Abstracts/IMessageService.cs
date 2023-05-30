using Core.Utilities.Results.Abstracts;
using Entities.DTOs;

namespace Services.Abstracts
{
    public interface IMessageService
    {
        IDataResult<List<MessageDto>> GetMessagesByPostId(int postId);
    }
}
